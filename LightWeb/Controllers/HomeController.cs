using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using gigaFlash.Modules;
using System.Threading;
using gigaFlash;
using LightWeb.Models;

namespace LightWeb.Controllers
{
    public class HomeController : Controller
    {
        LightState mState = new LightState(10);

        LightDB mModel = new LightDB();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public void ColorPick(int r, int g, int b)
        {
            try
            {
                foreach (Light light in mState.Lights)
                {
                    light.Red = r;
                    light.Green = g;
                    light.Blue = b;
                }
                mState.Update();
            }
            catch (Exception e)
            {
            }
        }

        public void Fade()
        {
            Color start = Color.Red;
            Color end = Color.Green;

            int time = 0;
            while (true)
            {
                double sineVal = AmpSinePresenter.PowerSine(time, 0);
                int red = (int)((end.R - start.R) * sineVal + start.R);
                int green = (int)((end.G - start.G) * sineVal + start.G);
                int blue = (int)((end.B - start.B) * sineVal + start.B);
                foreach (Light light in mState.Lights)
                {
                    light.Red = red;
                    light.Green = green;
                    light.Blue = blue;
                }
                Thread.Sleep(50);
                mState.Update();
                time++;
            }
        }

        public ActionResult ColorPick2(int r, int g, int b)
        {

            LightState s = new LightState(10);

            return null;
        }

    }
}
