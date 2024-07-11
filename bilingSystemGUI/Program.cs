using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace bilingSystemGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmlogin());
        }
        public static void addMessageIntoFile(string date, string message,string path)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(date + "," + message);
            f.Flush();
            f.Close();
        }
    }
}
