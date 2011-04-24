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
        }
        #endregion 

        #region Handlers 
        void OnLightSelectorClicked()
        {
            LightSelectorFactory f = new LightSelectorFactory();
            LightSelectorPresenter p = f.Create(ModuleOptions.LightSelector, mState);
            p.ShowUI(); 
        }
        #endregion 

        #region Members / Properties
        protected IMainformView mView;

        protected LightState mState; 

        public Form View
        {
            get
            {
                return mView.Control as Form; 
            }
        }
        #endregion
    }
}
