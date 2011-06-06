using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using gigaFlash.Delegates;
using GigaFlashWinform.RoomUI;

namespace GigaFlashWinform
{
    public interface ILightView
    {
        /// <summary>
        /// Gets or sets whether the current light is selected
        /// </summary>
        bool Selected { get; set; }

        /// <summary>
        /// Gets or sets the current light's Color
        /// </summary>
        Color Color { get; set; }

        /// <summary>
        /// Gets or sets the light's name. 
        /// </summary>
        String LabelName { get; set; }

        /// <summary>
        /// Announces that the color has been set. 
        /// </summary>
        event TypedDelegate<ILightView> ColorSet;  
    }
}
