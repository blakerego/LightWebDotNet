using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using gigaFlash.Mainform;
using gigaFlash;
using gigaFlash.Modules;
using GigaFlashWinform.Modules;

namespace GigaFlashWinform
{
    static class MainEntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadModules(); 

            LightState state = new LightState(4); 
            MainFormView view = new MainFormView();
            MainFormPresenter pres = new MainFormPresenter(view, state);
            Application.Run(view);
        }

        private static void LoadModules()
        {
            ModuleCatalog.Instance.Add(ModuleOptions.LightSelector, new LightSelectorViewFactory()); 
        }
    }
}
