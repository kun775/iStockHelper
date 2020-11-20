using System;
using System.Threading;
using System.Windows.Forms;

namespace iStock
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {      
#if DEBUG
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IStock());
#else
            using (Mutex mutex = new Mutex(true, Application.ProductName, out bool createNew))
            {
                if (createNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new IStock());
                }
                else
                {
                    MessageBox.Show("股票行情助手已经在运行中", "股票行情助手", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(1);
                }
            }
#endif
        }
    }
}
