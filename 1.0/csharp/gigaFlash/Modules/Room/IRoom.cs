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
        /// <summary>
        /// Announces a color change to a specific light index. 
        /// 
        /// If int is less than 0, we will update all lights. 
        /// </summary>
        event DualTypedDelegate<int, Color> LightUpdate;

        /// <summary>
        /// Meant to be run after events are hooked up from the presenter.
        /// </summary>
        void PostInitializiation();
    }
}
