using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules.Snake
{
    public class SnakePresenter : LightModulePresenterBase
    {
        #region Constructor 
        public SnakePresenter(ISnakeView pView, LightState pState)
            : base(pState)
        {
            mView = pView; 
        }
        #endregion 

        #region Public Methods
        public override void ShowUI()
        {
            throw new NotImplementedException();
        }
        #endregion 

        #region Members / Properties
        protected ISnakeView mView;
        #endregion

    }
}
