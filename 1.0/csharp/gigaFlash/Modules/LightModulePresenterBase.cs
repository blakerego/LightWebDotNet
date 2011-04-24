using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules
{
    public abstract class LightModulePresenterBase
    {
        #region Constructor
        public LightModulePresenterBase(LightState pLightState)
        {
            mLightState = pLightState; 
        }
        #endregion

        #region Members / Properties
        protected LightState mLightState;
        #endregion

        #region Abstract Methods
        public abstract void ShowUI(); 
        #endregion 
    }
}
