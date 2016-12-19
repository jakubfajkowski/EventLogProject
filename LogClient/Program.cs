using EventLogProject.LogServiceReference;
using System;
using System.Windows.Forms;

namespace EventLogProject {
    static class Program {
        public static readonly LogServiceClient logServiceClient = new LogServiceClient();
        public static string clientId = Environment.MachineName;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}