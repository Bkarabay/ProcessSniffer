namespace ProcessSniffer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Form1 form1 = new Form1();
            DeviceList deviceList = new DeviceList();
            form1.Load += (s, args) => form1.Hide();
            deviceList.FormClosed += (s, args) => { form1.Show(); };
            deviceList.Show();
            Application.Run();
        }
    }
}