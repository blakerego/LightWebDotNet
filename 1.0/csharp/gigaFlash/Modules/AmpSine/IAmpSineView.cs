using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;

namespace gigaFlash.Modules
{
    public interface IAmpSineView : IThreadedView
    {
        event VoidDelegate TwinkleFired;

        bool TwinkleButtonEnabled { get; set; }
    }
}
