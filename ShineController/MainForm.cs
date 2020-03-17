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
        

        public MainForm()
        {
            InitializeComponent();
            RestartStationController();
            for (int i = 1; i < 4; i++)
            {
                cbxColor.Items.Add(i);
            }
            cbxColor.SelectedIndex = 0;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void updateStationsTimer_Tick(object sender, EventArgs e)
        {
            if (lbxStations.Items.Count != sc.GetStations().Count)
            {
                lbxStations.Items.Clear();
                foreach (Station s in sc.GetStations())
                {
                    lbxStations.Items.Add(s.id);
                }
            }
        }

        private void btnRequestRegistration_Click(object sender, EventArgs e)
        {
            sc.RequestRegistration();
        }

        private void btnSendColor_Click(object sender, EventArgs e)
        {
            string id = (string)lbxStations.SelectedItem;
            sc.SendColor((Color)cbxColor.SelectedItem, tbrIntensity.Value, id);
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

        private void btnLaunchMusicAnalyzer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
