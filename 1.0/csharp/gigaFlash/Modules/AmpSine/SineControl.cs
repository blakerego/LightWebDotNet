using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;

namespace gigaFlash.Modules
{
    public class SineControl : IAmpSineView
    {
        #region IAmpSineView Members

        public event gigaFlash.Delegates.VoidDelegate TwinkleFired;

        public bool TwinkleButtonEnabled
        {
            get
            {
                return false; 
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region IThreadedView Members

        public event gigaFlash.Delegates.VoidDelegate StartFired;

        public event gigaFlash.Delegates.VoidDelegate StopFired;

        public void Start()
        {
            EventUtils.FireEvent(StartFired);
        }

        public void Stop()
        {
            EventUtils.FireEvent(StopFired); 
        }


        public bool RunButtonEnabled
        {
            get
            {
                return false; 
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region IModuleView Members

        public void Show() { }

        public event gigaFlash.Delegates.VoidDelegate Disposing;

        #endregion
    }
}
