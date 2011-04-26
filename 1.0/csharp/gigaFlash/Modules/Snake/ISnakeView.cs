using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;
using System.Drawing;

namespace gigaFlash.Modules
{
    public interface ISnakeView : IModuleView
    {
		/// <summary>
		/// The user has triggered the event to run the snake.  
		/// </summary>
		event VoidDelegate RunSnakeFired;

        /// <summary>
        /// The user wants to stop the snake. 
        /// </summary>
        event VoidDelegate StopSnakeFired;

        /// <summary>
        /// Allows the RunSnake button to be enabled. 
        /// </summary>
        bool RunSnakeButtonEnabled { get; set; } 
    }
}
