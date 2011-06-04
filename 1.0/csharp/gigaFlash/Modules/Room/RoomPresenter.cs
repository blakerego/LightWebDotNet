using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;
using System.Drawing;
using gigaFlash.Modules;

namespace gigaFlash.Room
{
    public class RoomPresenter : LightModulePresenterBase
    {
        public RoomPresenter(IRoom pView, LightState pState)
            : base(pView, pState)
        {
            mView = pView; 
            mView.LightUpdate += new DualTypedDelegate<int, Color>(OnLightUpdate);
        }

        public void OnLightUpdate(int val1, Color val2)
        {
            if (val1 >= 0)
            {
                mLightState.Lights[val1].Color = val2;
            }
            else
            {
                foreach (Light light in mLightState.Lights)
                {
                    light.Color = val2; 
                }
            }
            mLightState.Update(); 
        }

        protected IRoom mView;

    }
}
