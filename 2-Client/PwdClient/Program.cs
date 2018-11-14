using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PwdClient
{
    static class Program
    {
        public static string HTTPServer = ConfigurationManager.AppSettings["url"];
        public static string UserId;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Application.Run(new frmMain());
        }
    }
}
