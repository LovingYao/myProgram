using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RFIDProgram
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //登录窗体
            var login = new FrmLogin();
            login.ShowDialog();
            if (login.DialogResult != DialogResult.OK)
                return;

            //主窗体
            Application.Run(FrmMainClient.Form);
        }
    }
}
