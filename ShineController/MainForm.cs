using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShineController
{
    public partial class MainForm : Form
    {
        StationController sc;
        MusicProcessor mp;

        public MainForm()
        {
            InitializeComponent();

            RestartStationController();
            sc.RequestRegistration();
            PopulateStationsListbox();
            RestartMusicProcessor();
            mp.musicAnalyzers.Add(new MusicAnalyzer(new Color(Convert.ToByte(tbrRed.Value), Convert.ToByte(tbrGreen.Value), Convert.ToByte(tbrBlue.Value)), sc, null));
            UpdateAnalyzers();
            UpdateAnalyzerData();

            // automatically start with last device
            // remove when not necessary anymore
            lbxAudioDevices.SelectedIndex = lbxAudioDevices.Items.Count - 1;
            btnEnableMusic_Click(null, null);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sc.SendColor(ColorChannel.Red, 0);
            sc.SendColor(ColorChannel.Green, 0);
            sc.SendColor(ColorChannel.Blue, 0);
        }

        private void PopulateStationsListbox()
        {
            // TODO: fix null exception
            lbxStations.Items.Clear();
            foreach (Station s in sc.GetStations())
            {
                lbxStations.Items.Add(s);
            }
            
        }

        private void updateStationsTimer_Tick(object sender, EventArgs e)
        {
            int previousCount = lbxStations.Items.Count;
            if (lbxStations.Items.Count != sc.GetStations().Count)
            {
                PopulateStationsListbox();
            }
            int currentCount = lbxStations.Items.Count;
            if (previousCount == 0 && currentCount > 0)
            {
                lbxStations.SelectedIndex = 0;
            }
        }

        private void btnRequestRegistration_Click(object sender, EventArgs e)
        {
            sc.RequestRegistration();
        }

        private void RestartStationController()
        {
            IPAddress ip;
            int localport;
            int remoteport;

            bool ipsuccess = IPAddress.TryParse(tbxIP.Text, out ip);
            if (!ipsuccess)
            {
                MessageBox.Show("Invalid IP");
                return;
            }
            bool localsuccess = int.TryParse(tbxLocalPort.Text, out localport);
            if (!localsuccess)
            {
                MessageBox.Show("Invalid local port");
                return;
            }
            bool remotesuccess = int.TryParse(tbxRemotePort.Text, out remoteport);
            if (!remotesuccess)
            {
                MessageBox.Show("Invalid remote port");
                return;
            }
            sc = new StationController(ip, localport, remoteport);
        }

        private void btnRestartStationController_Click(object sender, EventArgs e)
        {
            RestartStationController();
        }

        private void RestartMusicProcessor()
        {
            // TODO: remove magic numbers
            mp = new MusicProcessor(sc, (int)nudMusicProcessorInterval.Value, 64, 1600);
            if (mp._devicelist.Count < 1)
            {
                return;
            }
            foreach (AudioDevice a in mp._devicelist)
            {
                lbxAudioDevices.Items.Add(a.deviceIndex);
            }
            lbxAudioDevices.SelectedIndex = 0;
        }


        private void btnEnableMusic_Click(object sender, EventArgs e)
        {
            mp.Enable((int)lbxAudioDevices.SelectedItem);
        }

        private void btnDisableMusic_Click(object sender, EventArgs e)
        {
            // FIXME
            mp.Disable();
            //ma._initialized = false;
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            Color c = new Color((byte)tbrRed.Value, (byte)tbrGreen.Value, (byte)tbrBlue.Value);
            MusicAnalyzer ma = ((MusicAnalyzer)lbxAnalyzers.SelectedItem);
            ma.Color = c;
            UpdateAnalyzers();
        }


        /// Update the analyzers. retrieve them from the musicprocessor
        private void UpdateAnalyzers()
        {
            bool analyzerIndexExists = false;
            MusicAnalyzer selectedAnalyzer = null;
            if (lbxAnalyzers.Items.Count > 0)
            {
                selectedAnalyzer = (MusicAnalyzer)lbxAnalyzers.SelectedItem;
                analyzerIndexExists = true;
            }
            
            lbxAnalyzers.Items.Clear();
            foreach (MusicAnalyzer analyzer in mp.musicAnalyzers)
            {
                lbxAnalyzers.Items.Add(analyzer);
            }
            if (analyzerIndexExists)
            {
                lbxAnalyzers.SelectedIndex = (lbxAnalyzers.Items.IndexOf(selectedAnalyzer));
            }
            else if (lbxAnalyzers.Items.Count > 0)
            {
                lbxAnalyzers.SelectedIndex = 0;
            }
            
        }

        private void UpdateAnalyzerData()
        {
            if (lbxAnalyzers.SelectedItem == null)
            {
                return;
            }
            MusicAnalyzer selectedAnalyzer = (MusicAnalyzer)lbxAnalyzers.SelectedItem;
            lbxAnalyzerStations.Items.Clear();
            if (selectedAnalyzer.Stations != null)
            {
                foreach (Station s in selectedAnalyzer.Stations)
                {
                    lbxAnalyzerStations.Items.Add(s);
                }
            }

            tbrBlue.Value = selectedAnalyzer.Color.Blue;
            tbrGreen.Value = selectedAnalyzer.Color.Green;
            tbrRed.Value = selectedAnalyzer.Color.Red;
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            MusicAnalyzer ma = ((MusicAnalyzer)lbxAnalyzers.SelectedItem);
            if (ma.Stations == null)
            {
                ma.Stations = new List<Station>();
            }
            ma.Stations.Add((Station)lbxStations.SelectedItem);
            UpdateAnalyzers();
            UpdateAnalyzerData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveStation_Click(object sender, EventArgs e)
        {
            MusicAnalyzer ma = ((MusicAnalyzer)lbxAnalyzers.SelectedItem);
            ma.Stations.Remove((Station)lbxAnalyzerStations.SelectedItem);
            UpdateAnalyzers();
            UpdateAnalyzerData();
        }

        private void btnAddAnalyzer_Click(object sender, EventArgs e)
        {
            mp.musicAnalyzers.Add(new MusicAnalyzer(new Color(0, 0, 0), sc, null));
            UpdateAnalyzers();
            UpdateAnalyzerData();
        }

        private void btnRemoveAnalyzer_Click(object sender, EventArgs e)
        {
            mp.musicAnalyzers.Remove((MusicAnalyzer)lbxAnalyzers.SelectedItem);
            UpdateAnalyzers();
            UpdateAnalyzerData();
        }

        private void lbxAnalyzers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAnalyzerData();
        }

        private void nudMusicProcessorInterval_ValueChanged(object sender, EventArgs e)
        {
            mp.interval = (int)nudMusicProcessorInterval.Value;
        }
    }
}
