using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace gigaFlash.Modules
{
    public class LightSelectorPresenter : LightModulePresenterBase
    {
        #region Constructor
        public LightSelectorPresenter(ILightSelectorView pView, LightState pLightState)
            : base(pLightState)
        {
            mView = pView;
            mView.UpdateColorFired += new gigaFlash.Delegates.TypedDelegate<System.Drawing.Color>(OnUpdateColorFired);
            mView.ClearClicked += new gigaFlash.Delegates.VoidDelegate(OnClearClicked);
        }
        #endregion 

        #region Public UI
        public override void ShowUI()
        {
            mView.Show(); 
        }
        #endregion 

        #region Handlers 
        protected virtual void OnUpdateColorFired(Color value)
        {
            foreach (object selectedObject in mView.SelectedItems)
            {
                int selectedindex = mView.SelectedItems.IndexOf(selectedObject);
                mLightState.Lights[selectedindex].Color = value;
            }
            mLightState.Update();
            mView.Color = value; 
        }

        protected virtual void OnClearClicked()
        {
            mLightState.Clear();
            mView.Color = Color.Black; 
        }

        #endregion 

        #region Members / Properties
        protected ILightSelectorView mView; 
        #endregion 
    }
}
