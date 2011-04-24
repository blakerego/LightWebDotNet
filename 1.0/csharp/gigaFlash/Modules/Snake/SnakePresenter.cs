using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules.Snake
{
    public class SnakePresenter : LightModulePresenterBase
    {
        #region Constructor 
        public SnakePresenter(SnakeView pView, LightState pState)
            : base(pState)
        {
            mView = pView; 
        }
        #endregion 

        #region Members / Properties
        protected SnakeView mView;
        #endregion

        public override void ShowUI()
        {
            throw new NotImplementedException();
        }
    }
}
