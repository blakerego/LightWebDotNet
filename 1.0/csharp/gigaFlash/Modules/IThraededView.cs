using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;

namespace gigaFlash.Modules
{
    public interface IThraededView : IModuleView
    {
        /// <summary>
        /// The user has triggered the event to run the snake.  
        /// </summary>
        event VoidDelegate StartFired;

        /// <summary>
        /// The user wants to stop the snake. 
        /// </summary>
        event VoidDelegate StopFired;
    }
}
