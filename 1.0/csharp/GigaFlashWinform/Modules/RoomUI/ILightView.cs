using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

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
    }
}
