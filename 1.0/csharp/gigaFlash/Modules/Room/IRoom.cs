using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using gigaFlash.Delegates;

namespace gigaFlash
{
    public interface IRoom : IModuleView
    {
        event DualTypedDelegate<int, Color> LightUpdate;
    }
}
