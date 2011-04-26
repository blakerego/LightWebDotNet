using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace gigaFlash
{
    public class ColorUtils
    {
        public static Color GetRandomColor()
        {
            Random r = new Random();
            return Color.FromArgb(
                Convert.ToInt16(r.Next(255)),
                Convert.ToInt16(r.Next(255)),
                Convert.ToInt16(r.Next(255))
                );
        }
    }
}
