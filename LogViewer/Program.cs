using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogViewer.LogServiceReference;

namespace LogViewer {
    static class Program {
        public static readonly LogServiceClient logServiceClient = new LogServiceClient();

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}