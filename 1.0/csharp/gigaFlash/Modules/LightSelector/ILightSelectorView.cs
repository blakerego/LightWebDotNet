using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;
using System.Drawing;
using System.Windows.Forms;

namespace gigaFlash.Modules
{
    public interface ILightSelectorView
    {
        /// <summary>
        /// Event that fires when a new color is selected. 
        /// </summary>
        event TypedDelegate<Color> UpdateColorFired;

        /// <summary>
        /// Queues the UI form or website to be shown. 
        /// </summary>
        void Show();

        /// <summary>
        /// Gets or sets the selected items from the light selector view. 
        /// </summary>
        List<Object> SelectedItems { get; set; }

        /// <summary>
        /// Gets or sets the color to be sent to the light state. 
        /// </summary>
        Color Color { get; set; }

        /// <summary>
        /// Event that fires when the user triggers a clear. 
        /// </summary>
        event VoidDelegate ClearClicked; 
    }
}
