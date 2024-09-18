using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProcessSniffer
{
    public partial class Form1 : Form
    {
        private Processport pp;
        private PacketSniffer sniffer;
        private bool isCapture = false;
        public Form1()
        {
            InitializeComponent();
            sniffer = new PacketSniffer();
            pp = new Processport();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            TypeCB.SelectedIndex = 0;
            GetProcessList();
        }

        private void GetProcessList()
        {
            Process[] processList = Process.GetProcesses();

            foreach (Process process in processList)
            {
                if (IsSystemProcess(process))
                {
                    continue;
                }
                listBox1.Items.Add($"Process Name: {process.ProcessName}, ID: {process.Id}");
            }
        }
        private bool IsSystemProcess(Process process)
        {
            string[] systemProcessNames = { "Idle", "System", "svchost", "explorer", "lsass", "csrss", "winlogon", "services", "smss" };
            if (systemProcessNames.Contains(process.ProcessName, StringComparer.OrdinalIgnoreCase))
            {
                return true;
            }
            if (process.SessionId == 0)
            {
                return true;
            }
            return false;
        }

        private bool ValidateProcessInput(out int processId)
        {
            processId = 0;

            if (!string.IsNullOrWhiteSpace(ProcessNameTxt.Text))
            {
                string processName = ProcessNameTxt.Text;
                processId = pp.ListPorts(processName);
                return true;
            }


            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                string processIdStr = ExtractProcessId(selectedItem);

                if (int.TryParse(processIdStr, out int parsedId))
                {
                    processId = pp.ListPorts(parsedId);
                    return true;
                }
            }

            return false;
        }

        private string ExtractProcessId(string selectedItem)
        {
            string[] parts = selectedItem.Split(',');
            string idPart = parts.Length > 1 ? parts[1].Trim() : string.Empty;
            return idPart.Replace("ID: ", "").Trim();
        }

        private string GetSelectedPacketType()
        {
            string selectedType = TypeCB.SelectedItem?.ToString();
            return string.IsNullOrEmpty(selectedType) || selectedType == "Select Type" ? "TCP" : selectedType;
        }

        private void ProcessLoadBtn_Click(object sender, EventArgs e)
        {
            Config.GetConfig().packetType = GetSelectedPacketType();
            if (ValidateProcessInput(out int processId))
            {
                Config.GetConfig().PortNumber = processId;
                protIDLbl.Text = Config.GetConfig().PortNumber.ToString();
                SnifferBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid process name or select a process from the list.");
            }
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();
        private void SnifferBtn_Click(object sender, EventArgs e)
        {
            if (!isCapture)
            {
                AllocConsole();
                sniffer.StartCapture();
                isCapture = true;
                SnifferBtn.Text = "Stop";
            }
            else
            {
                sniffer.StopCapture();
                FreeConsole();
                isCapture = false;
                SnifferBtn.Text = "Start Capture";
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GetProcessList();
        }

        private void deviceListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceList deviceList = new DeviceList();
            deviceList.Show();
        }
    }
}
