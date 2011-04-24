using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using gigaFlash.Mainform;

namespace GigaFlashWinform
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
            MainFormView view = new MainFormView();
            MainFormPresenter pres = new MainFormPresenter(view);
            Application.Run(pres.View);
        }
    }
}
