using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;
using System.Windows.Forms;

namespace gigaFlash.Mainform
{
    public interface IMainformView
    {
        event VoidDelegate LightSelectorClicked;
    }
}
