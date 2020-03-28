using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Un4seen.Bass;
using Un4seen.BassWasapi;


namespace ShineController
{
    struct AudioDevice
    {
        public int deviceIndex;
        public string Name;
    }

    class MusicProcessor
    {
        private StationController sc;
        public List<MusicAnalyzer> musicAnalyzers;

        private bool _enabled;
        private DispatcherTimer _t;         //timer that refreshes the display
        private float[] _fft;               //buffer for fft data        
        private WASAPIPROC _process;        //callback function to obtain data        
        private int _hanctr;                //last output level counter
        private List<byte> spectrumdata;   //spectrum data buffer
        public List<AudioDevice> _devicelist;       //device list
        public bool _initialized;          //initialized flag
        private int _lines;            // number of spectrum lines
        private List<List<byte>> spectrumdataHistory;
        private int spectrumdataHistoryLength;

        // lines 64, sdhistorylength 1600
        public MusicProcessor(StationController sc, int interval, int spectrumWidth, int spectrumdataHistoryLength)
        {
            this.sc = sc;
            _fft = new float[1024];
            _lines = spectrumWidth;
            this.spectrumdataHistoryLength = spectrumdataHistoryLength;
            _hanctr = 0;
            _t = new DispatcherTimer();
            _t.Tick += _t_Tick;
            _t.Interval = TimeSpan.FromMilliseconds(interval); //25 -> 40hz refresh rate
            _t.IsEnabled = false;
            _process = new WASAPIPROC(Process);
            spectrumdata = new List<byte>();
            spectrumdataHistory = new List<List<byte>>();
            _devicelist = new List<AudioDevice>();
            _initialized = false;
            this.musicAnalyzers = new List<MusicAnalyzer>();

            Init();
        }

        public bool GetIsEnabled()
        {
            return _enabled;
        }

        public bool Disable()
        {
            if (_enabled)
            {
                BassWasapi.BASS_WASAPI_Stop(true);
                _t.IsEnabled = false;
                _enabled = false;
                return true;
            }
            return false;
        }

        public int interval
        {
            // TODO: check the getter for valididty
            get { return _t.Interval.Milliseconds; }
            set { _t.Interval = TimeSpan.FromMilliseconds(value); }
        }

        public Color color { get; set; }

        public bool Enable(int deviceIndex)
        {
            if (!_enabled)
            {
                if (!_initialized)
                {
                    bool result = BassWasapi.BASS_WASAPI_Init(deviceIndex, 0, 0,
                                                                BASSWASAPIInit.BASS_WASAPI_BUFFER,
                                                                1f, 0.05f,
                                                                _process, IntPtr.Zero);
                    if (!result)
                    {
                        var error = Bass.BASS_ErrorGetCode();
                        Console.WriteLine(error.ToString());
                        return false;
                    }
                    else
                    {
                        _initialized = true;
                    }
                }
                BassWasapi.BASS_WASAPI_Start();
            }
            else
            {
                return false;
            }
            System.Threading.Thread.Sleep(500);
            _t.IsEnabled = true;
            return true;
        }

        private void Init()
        {
            bool result = false;
            for (int i = 0; i < BassWasapi.BASS_WASAPI_GetDeviceCount(); i++)
            {
                var device = BassWasapi.BASS_WASAPI_GetDeviceInfo(i);
                if (device.IsEnabled && device.IsLoopback)
                {
                    AudioDevice newdevice = new AudioDevice();
                    newdevice.deviceIndex = i;
                    newdevice.Name = device.name;
                    _devicelist.Add(newdevice);
                }
            }
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATETHREADS, false);
            result = Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            if (!result) throw new Exception("Init Error");
        }

        private void _t_Tick(object sender, EventArgs e)
        {
            // get fft data. Return value is -1 on error
            int ret = BassWasapi.BASS_WASAPI_GetData(_fft, (int)BASSData.BASS_DATA_FFT2048);
            if (ret < 0) return;
            int x, y;
            int b0 = 0;

            //computes the spectrum data, the code is taken from a bass_wasapi sample.
            for (x = 0; x < _lines; x++)
            {
                float peak = 0;
                int b1 = (int)Math.Pow(2, x * 10.0 / (_lines - 1));
                if (b1 > 1023) b1 = 1023;
                if (b1 <= b0) b1 = b0 + 1;
                for (; b0 < b1; b0++)
                {
                    if (peak < _fft[1 + b0]) peak = _fft[1 + b0];
                }
                y = (int)(Math.Sqrt(peak) * 3 * 255 - 4);
                if (y > 255) y = 255;
                if (y < 0) y = 0;
                spectrumdata.Add((byte)y);
            }

            // use (_spectrumdata)
            // it's an array of values 0-255
            spectrumdataHistory.Add(new List<byte>(spectrumdata));
            if (spectrumdataHistory.Count > spectrumdataHistoryLength)
            {
                // If the list gets bigger than set number, remove oldest entry
                spectrumdataHistory.RemoveAt(0);
            }
            
            foreach (MusicAnalyzer ma in musicAnalyzers)
            {
                ma.Tick(spectrumdataHistory);
            }
            spectrumdata.Clear();
            //int level = BassWasapi.BASS_WASAPI_GetLevel();
            
            //Required, because some programs hang the output. If the output hangs for a 75ms
            //this piece of code re initializes the output
            //so it doesn't make a gliched sound for long.
            if (_hanctr > 3)
            {
                _hanctr = 0;
                Free();
                Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                _initialized = false;
                Enable(0);
            }
        }

        private int Process(IntPtr buffer, int length, IntPtr user)
        {
            return length;
        }

        public void Free()
        {
            BassWasapi.BASS_WASAPI_Free();
            Bass.BASS_Free();
        }
    }
}
