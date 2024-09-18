using SharpPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessSniffer
{
    public partial class DeviceList : Form
    {
        public DeviceList()
        {
            InitializeComponent();
        }

        private void DeviceList_Load(object sender, EventArgs e)
        {
            GetDeviceList();
        }

        private void GetDeviceList()
        {
            var devices = CaptureDeviceList.Instance;

            if (devices.Count < 1)
            {
                DeviceListBox.Items.Clear();
                DeviceListBox.Items.Add(new ListViewItem("Device not found!"));
                return;
            }
            else
            {
                SelectDeviceBtn.Enabled = true;
                foreach (var device in devices)
                {
                    DeviceListBox.Items.Add(device.Description);
                }
            }

        }

        private void SelectDeviceBtn_Click(object sender, EventArgs e)
        {
            Config.GetConfig().DeviceID = DeviceListBox.SelectedIndex;
            this.Close();
        }
    }
}
