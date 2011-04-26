using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules
{
    public abstract class LightModulePresenterBase
    {
        #region Constructor
        public LightModulePresenterBase(IModuleView pView, LightState pLightState)
        {
            mLightState = pLightState;
            mModuleView = pView;
        }
        #endregion

        #region Members / Properties
        protected LightState mLightState;

        protected IModuleView mModuleView; 
        #endregion

        #region Public Methods
        public void ShowUI()
        {
            mModuleView.Show(); 
        }
        #endregion 
    }
}
