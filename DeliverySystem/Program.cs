using DeliverySystem.PL.BasicFiles;
using DeliverySystem.PL.Main;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DeliverySystem
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
            Application.Run(new FRM_Login());
        }
    }
}