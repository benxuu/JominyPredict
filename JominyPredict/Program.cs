using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JominyPredict
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        private static System.Threading.Mutex onlyOne;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            onlyOne = new System.Threading.Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            if (onlyOne.WaitOne(0, false))
            {
                FormStarting s = new FormStarting();
                s.Show();
                Application.Run(new FormMain());
            }
            else
            {
                MessageBox.Show("应用程序已启动！");
            }
 
        }
    }
}
