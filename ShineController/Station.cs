using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineController
{
    class Station
    {
        public System.Net.IPAddress ip;
        public string id;

        public Station(System.Net.IPAddress ip, string deviceID)
        {
            this.ip = ip;
            this.id = deviceID;
            this.Color = new Color(0, 0, 0);
        }

        public Color Color
        {
            get; set;
        }

        public override string ToString()
        {
            return this.id;
        }
    }
}
