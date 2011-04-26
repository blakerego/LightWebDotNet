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
        /// <summary>
        /// The event that is raised when the light selector 
        /// module is selected. 
        /// </summary>
        event VoidDelegate LightSelectorClicked;

        /// <summary>
        /// The event that is raised when the snake module 
        /// is selected. 
        /// </summary>
        event VoidDelegate SnakeModuleClicked; 
    }
}
