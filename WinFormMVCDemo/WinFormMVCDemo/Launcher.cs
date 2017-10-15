using System;
using System.Windows.Forms;
using WinFormMVCDemo.Views;

namespace WinFormMVCDemo
{
    static class Launcher
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DependencyContainer.BuildDependencies();
            Application.Run(new FrmHome());
        }
    }
}
