using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace gigaFlash.Modules
{
    public class ThunderPresenter : ThreadPresenterBase
    {
        #region Constructor 
        public ThunderPresenter(IThunderView pView, LightState pState)
            : base(pView, pState)
        {
            mView = pView;
        }
        #endregion 

        #region Overriden Methods
        protected override void RunContinuously(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //play rain here

            while (mContinueThread)
            {
                Color weather = GetWeather(ColorUtils.RandomSeededGenerator.Next(0, mLightState.Lights.Count - 1));
                foreach (Light light in mLightState.Lights)
                {
                    light.Color = weather; 
                }
                mLightState.Update(); 
                System.Threading.Thread.Sleep(RAIN_TIME);

                if (weather == Color.White) //Lightning has struck
                {
                    //Play thunder
                    //Pause on White. 
                    Thread.Sleep(LIGHTNING_TIME); 
                }
            }
        }

        protected Color GetWeather(int lightNumber)
        {
            Light currentLight = mLightState.Lights[lightNumber];
            int choice = ColorUtils.RandomSeededGenerator.Next(1, 100);
            if (choice == 1)
            {
                for (int i = 0; i < ColorUtils.RandomSeededGenerator.Next(3, 7); i++)
                {
                    ColorUtils.Flash(mLightState, currentLight, Color.White, THUNDER_TIME);
                    ColorUtils.Flash(mLightState, currentLight, Color.Black, THUNDER_TIME);
                }
                return Color.White; 
            }

            else if (choice > 1 && choice <= 60)
            {
                return Color.FromArgb(50, 50, 255);
            }

            else
            {
                return Color.FromArgb(80, 80, 255); 
            }
        }

        #endregion 

        #region Members / Properties
        protected IThunderView mView;

        protected const int RAIN_TIME = 100;

        protected const int THUNDER_TIME = 100;

        protected const int LIGHTNING_TIME = 1000; 
        #endregion

    }
}
