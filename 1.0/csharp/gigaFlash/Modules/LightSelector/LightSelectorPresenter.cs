using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules
{
    public class LightSelectorPresenter : LightModulePresenterBase
    {

        #region Constructor
        public LightSelectorPresenter(LightSelector pView, LightState pState)
            : base(pState)
        {
            mView = pView; 
        }
        #endregion 

        #region Public UI
        public override void ShowUI()
        {
            mView.Show(); 
        }
        #endregion 

        #region Members / Properties
        protected LightSelector mView; 
        #endregion 
    }
}
