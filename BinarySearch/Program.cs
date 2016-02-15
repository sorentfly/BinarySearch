using System;
using System.Windows.Forms;

namespace BinarySearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. NICE!!!
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
