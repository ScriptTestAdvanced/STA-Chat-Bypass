using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Net;

namespace ChatBypasser1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("https://raw.githubusercontent.com/ScriptTestAdvanced/STA-Chat-Bypass/main/changelogs.txt", "changelogs.txt");
            }
            Application.EnableVisualStyles();
            MessageBox.Show("Some of these bypasses may be bannable! So be careful!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
