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
    }
}
