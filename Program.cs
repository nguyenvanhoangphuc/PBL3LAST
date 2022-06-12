using QuanLyPhongTroLinQ.View;
using System;
using System.Windows.Forms;

using QuanLyPhongTroLinQ.BLL;

namespace QuanLyPhongTroLinQ
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //push lan dau tien
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
           

        }
    }
}
