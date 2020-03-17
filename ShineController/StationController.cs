using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShineController
{
    enum Commands
    {
        SetColor = 1,
        Response,
        RegisterRequest,
        ChangeSetting
    }


    class StationController
    {
        private int listenPort;
        private int sendPort;
        private IPAddress broadcastIP;
        private volatile List<Station> stations;
        private UdpClient listener;


        public StationController(IPAddress broadcastIP, int listenPort, int sendPort)
        {
            this.broadcastIP = broadcastIP;
            this.listenPort = listenPort;
            this.sendPort = sendPort;
            this.stations = new List<Station>();
            listener = new UdpClient(listenPort);

            listener.EnableBroadcast = true;
            listener.BeginReceive(new AsyncCallback(recv), null);
        }

        private void recv(IAsyncResult res)
        {
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, this.listenPort);
            byte[] received = listener.EndReceive(res, ref RemoteIpEndPoint);
            
            if (received[0] == 0b01000000)
            {
                bool alreadyExists = false;
                string id = Encoding.UTF8.GetString(received).Substring(1, 6);
                foreach (Station s in this.stations)
                {
                    if (s.id == id)
                    {
                        alreadyExists = true;
                    }
                }
                if (!alreadyExists)
                {
                    this.stations.Add(new Station(RemoteIpEndPoint.Address, id));
                }
            }
            else
            {
                Console.WriteLine("Bad message received: " + Encoding.UTF8.GetString(received));
            }
            

            listener.BeginReceive(new AsyncCallback(recv), null);
        }


        public List<Station> GetStations()
        {
            return this.stations;
        }

        public void RequestRegistration()
        {
            this.stations.Clear();
            SendRequestForRegistration();
        }

        public void SendRequestForRegistration()
        {
            SendMessage(Commands.RegisterRequest);
        }

        public void SendColor(Color color, int brightness)
        {
            byte[] message = new byte[2];
            message[0] = (byte)color;
            message[1] = (byte)brightness;
            SendMessage(Commands.SetColor, message);
        }

        public void SendColor(Color color, int brightness, string deviceID)
        {
            foreach (Station s in this.stations)
            {
                if (s.id == deviceID)
                {
                    byte[] message = new byte[2];
                    message[0] = (byte)color;
                    message[1] = (byte)brightness;
                    SendMessage(Commands.SetColor, s.ip, message);
                    return;
                }
            }
            throw new ArgumentException();
        }

        public void SendMessage(Commands command, byte[] arguments = null)
        {
            SendMessage(command, this.broadcastIP, arguments);
        }

        public void SendMessage(Commands command, IPAddress ip, byte[] arguments = null)
        {
            byte commandByte = (byte)(((int)command) << 5);
            byte[] message;
            int argumentsSize = 0;
            if (arguments != null)
            {
                argumentsSize = arguments.Length;
            }
            message = new byte[1 + argumentsSize];

            message[0] = commandByte;
            for (int i = 0; i < argumentsSize; i++)
            {
                message[i + 1] = arguments[i];
            }
            try
            {
                using (var client = new UdpClient())
                {
                    IPEndPoint ep = new IPEndPoint(ip, sendPort);
                    client.Connect(ep);
                    client.Send(message, message.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
