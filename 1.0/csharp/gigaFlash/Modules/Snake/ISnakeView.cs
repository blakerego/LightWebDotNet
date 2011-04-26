using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;
using System.Drawing;

namespace gigaFlash.Modules
{
    public interface ISnakeView : IThreadedView
    {

        /// <summary>
        /// Allows the RunSnake button to be enabled. 
        /// </summary>
        bool RunSnakeButtonEnabled { get; set; } 
    }
}
