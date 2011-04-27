using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace gigaFlash
{
    public class ColorUtils
    {
        public static Color GetRandomColor()
        {
            return Color.FromArgb(
                Convert.ToInt16(RandomSeededGenerator.Next(255)),
                Convert.ToInt16(RandomSeededGenerator.Next(255)),
                Convert.ToInt16(RandomSeededGenerator.Next(255))
                );
        }
        
        public static Random RandomSeededGenerator = new Random();

        public static void Flash(LightState pState,
            List<Light> pLightRange, Color pFlashColor, 
            int flashRate)
        {
            foreach (Light l in pLightRange)
            {
                l.Color = pFlashColor;
                pState.Update();
                Thread.Sleep(flashRate);
            }
        }

        public static void Flash(LightState pState, Light light, Color pFlashColor, int flashRate)
        {
            List<Light> lights = new List<Light>();
            lights.Add(light);
            Flash(pState, lights, pFlashColor, flashRate); 
        }
    }
}
