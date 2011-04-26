using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Modules;
using System.Windows.Forms;

namespace gigaFlash.Mainform
{
    public class MainFormPresenter
    {
        #region Constructor 
        public MainFormPresenter(IMainformView pView, LightState pState)
        {
            mView = pView;
            mState = pState; 
            mView.LightSelectorClicked += new gigaFlash.Delegates.VoidDelegate(OnLightSelectorClicked);
            mView.SnakeModuleClicked += new gigaFlash.Delegates.VoidDelegate(OnSnakeModuleClicked);
        }
        #endregion 

        #region Handlers 
        protected virtual void OnLightSelectorClicked()
        {
            LightSelectorFactory f = new LightSelectorFactory();
            LightSelectorPresenter p = f.Create(ModuleOptions.LightSelector, mState);
            p.ShowUI(); 
        }

        protected virtual void OnSnakeModuleClicked()
        {
            SnakePresFactory factory = new SnakePresFactory();
            SnakePresenter pres = factory.Create(ModuleOptions.Snake, mState);
            pres.ShowUI(); 
        }
        #endregion 

        #region Members / Properties
        protected IMainformView mView;

        protected LightState mState; 

        #endregion
    }
}
