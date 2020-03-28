using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineController
{
    class MusicAnalyzer
    {
        private StationController sc;

        public MusicAnalyzer(Color color, StationController sc, List<Station> stations)
        {
            this.Color = color;
            this.sc = sc;
            this.Stations = stations;
            StartInterestZone = 0;
            EndInterestZone = 48;
        }

        public List<Station> Stations
        {
            get; set;
        }

        public Color Color
        {
            get; set;
        }

        public int StartInterestZone
        {
            get; set;
        }

        public int EndInterestZone
        {
            get; set;
        }

        private int GetVolume(List<byte> sd, int low, int high)
        {
            int InterestVolume = 0;
            for (int i = low; i < high; i++)
            {
                InterestVolume += sd[i];
            }
            InterestVolume /= high - low;
            return InterestVolume;
        }

        public void Tick(List<List<byte>> history)
        {

            List<byte> spectrumdata = history[history.Count - 1];

            int lowest = 254;
            int highest = 1;
            for (int i = 1; i < history.Count - 1; i++)
            {
                int volume = GetVolume(history[i], StartInterestZone, EndInterestZone);
                if (volume < lowest) lowest = volume;
                if (volume > highest) highest = volume;
            }

            int volumeRange = highest - lowest;
            if (volumeRange < 1) volumeRange = 1;
            double volumeFactor = (254 / volumeRange);

            int InterestVolume = GetVolume(spectrumdata, StartInterestZone, EndInterestZone);

            InterestVolume -= lowest;
            InterestVolume = (int)((double)InterestVolume * volumeFactor);

            if (InterestVolume < 0) InterestVolume = 0;
            if (InterestVolume > 254) InterestVolume = 254;
            
            if (Stations == null)
            {
                sc.SendColor(ColorChannel.Red, (int)(InterestVolume * ((double)Color.Red / 255)));
                sc.SendColor(ColorChannel.Green, (int)(InterestVolume * ((double)Color.Green / 255)));
                sc.SendColor(ColorChannel.Blue, (int)(InterestVolume * ((double)Color.Blue / 255)));
            }
            else
            {
                foreach (Station s in Stations)
                {
                    sc.SendColor(ColorChannel.Red, (int)(InterestVolume * ((double)Color.Red / 255)), s.id);
                    sc.SendColor(ColorChannel.Green, (int)(InterestVolume * ((double)Color.Green / 255)), s.id);
                    sc.SendColor(ColorChannel.Blue, (int)(InterestVolume * ((double)Color.Blue / 255)), s.id);
                }
            }
        }

        public override string ToString()
        {
            string result = "";
            result += Color.ToString();
            result += " Stations:";
            if (Stations == null)
            {
                result += "global";
            }
            else
            {
                foreach (Station s in Stations)
                {
                    result += s.id;
                    result += "-";
                }
            }
            
            result += $" range:{StartInterestZone}-{EndInterestZone}";
            return result;
        }
    }
}
