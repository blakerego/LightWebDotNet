﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace gigaFlash.Modules
{
    public class AmpSinePresenter : LightModulePresenterBase
    {
        #region Constructor 
        public AmpSinePresenter(IAmpSineView pView, LightState pState)
            : base(pView, pState)
        {
            mView = pView;
            mView.StartFired += new gigaFlash.Delegates.VoidDelegate(OnStartFired);
            mView.StopFired += new gigaFlash.Delegates.VoidDelegate(OnStopFired);
            mView.TwinkleFired += new gigaFlash.Delegates.VoidDelegate(OnTwinkleFired);
            mSineWorker = new BackgroundWorker();
            mSineWorker.WorkerSupportsCancellation = true;
            mSineWorker.DoWork += new DoWorkEventHandler(OnSineThreadFired);
            mSineWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnSineFinished);

            mTwinkleWorker = new BackgroundWorker();
            mTwinkleWorker.WorkerSupportsCancellation = true;
            mTwinkleWorker.DoWork += new DoWorkEventHandler(OnTwinkleThreadFired);
            mTwinkleWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnSineFinished);
        }

        #endregion 

        #region Public Methods
        public static double PowerSine(double time, double phase)
        {
            double amp = 100;
            double freq = 100;
            double stepsPerCycle = 100;
            double sine = amp / 100 * Math.Sin(Math.PI * freq / 100 * time / stepsPerCycle + phase);
            return Math.Round(sine * sine, 4); 
        }
        #endregion 

        #region Handlers
        protected virtual void OnStopFired()
        {
            mContinueSine = false; 
        }

        protected virtual void OnStartFired()
        {
            mSineWorker.RunWorkerAsync();
            mContinueSine = true; 
        }

        void OnTwinkleFired()
        {
            mTwinkleWorker.RunWorkerAsync(); 
            mContinueSine = true;
        }


        protected virtual void OnSineFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            mLightState.Clear(); 
        }

        protected virtual void OnSineThreadFired(object sender, DoWorkEventArgs e)
        {
            Random r = new Random();

            double baseRed = r.Next(255);
            double baseBlue = r.Next(255);
            double baseGreen = r.Next(255); 

            double time = 0; 
            while (mContinueSine)
            {
                double scale = PowerSine(time, 0); 
                Color c = Color.FromArgb(
                    Convert.ToInt16(baseRed   * scale),
                    Convert.ToInt16(baseGreen * scale),
                    Convert.ToInt16(baseBlue  * scale)
                    );
                foreach (Light light in mLightState.Lights)
                {
                    light.Color = c; 
                }
                mLightState.Update();
                System.Threading.Thread.Sleep(50);
                time++; 
            }
        }

        protected virtual void OnTwinkleThreadFired(object sender, DoWorkEventArgs e)
        {
            Random r = new Random(); 
            double time = 0;

            List<double> phaseMap = new List<double>();
            List<Color> colorMap = new List<Color>(); 
            foreach (Light l in mLightState.Lights)
            {
                phaseMap.Add(r.Next(2 * 314));
                colorMap.Add(ColorUtils.GetRandomColor()); 
            }

            while (mContinueSine)
            {
                
                int index = 0; 
                foreach (Light light in mLightState.Lights)
                {
                    double scale = PowerSine(time, phaseMap[index] / 100); 
                    light.Color = Color.FromArgb(
                    Convert.ToInt16(colorMap[index].R * scale),
                    Convert.ToInt16(colorMap[index].G * scale),
                    Convert.ToInt16(colorMap[index].B * scale)
                    );

                    index++; 
                }
                mLightState.Update();
                System.Threading.Thread.Sleep(50);
                time++;
            }

        }

        #endregion 

        #region Members / Properties
        protected IAmpSineView mView;

        protected BackgroundWorker mSineWorker;

        protected BackgroundWorker mTwinkleWorker; 

        protected bool mContinueSine; 
        #endregion 
    }
}