using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;
using System.Drawing;
using System.ComponentModel; 

namespace gigaFlash.Modules
{
	/// <summary>
	/// The logic in this class allows the lights to move in a snake-like fashion around the room. 
	/// By this I mean :         
	/// ... -  (|) - (||) - (|||)  
	/// 
	/// At the snake head, the color will be at full intensity. The next in line will be at half intensity. 
	/// 
	/// </summary>
    public class SnakePresenter : LightModulePresenterBase
    {
        #region Constructor 
        public SnakePresenter(ISnakeView pView, LightState pState)
            : base(pState)
        {
            mView = pView; 
			mView.StartFired += new gigaFlash.Delegates.VoidDelegate(OnSnakeFired);
            mView.StopFired += new VoidDelegate(OnSnakeStopped);
            mSnakeWorker = new BackgroundWorker();
            mSnakeWorker.WorkerSupportsCancellation = true;
            mSnakeWorker.DoWork += new DoWorkEventHandler(StartSnakeThread);
            mSnakeWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SnakeFinished);
        }

        #endregion 

        #region Public Methods
        public override void ShowUI()
        {
			mView.Show(); 
        }
        #endregion 
		
		#region Handlers
		protected virtual void OnSnakeFired() 
		{
            mContinueSnaking = true; 
            mView.RunSnakeButtonEnabled = false; 
            mSnakeWorker.RunWorkerAsync();
		}

        /// <summary>
        /// On the user's command, we signal that this snake will this thread's last.
        /// </summary>
        protected void OnSnakeStopped()
        {
            mContinueSnaking = false;
        }

        /// <summary>
        /// When the snake thread is finished, re-enable the snake button. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void SnakeFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            mView.RunSnakeButtonEnabled = true;
        }


        /// <summary>
        /// This is meant to be run on a background thread which starts when 
        /// the user clicks the snake button. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void StartSnakeThread(object sender, DoWorkEventArgs e)
        {
            while (mContinueSnaking)
            {
                int snakeParts = mLightState.Lights.Count;
                Color c = Color.White;
                foreach (Light turn in mLightState.Lights)
                {
                    // Each light get its turn to be the head of the snake for the given color. 
                    int snakeHead = mLightState.Lights.IndexOf(turn);

                    foreach (Light light in mLightState.Lights)
                    {
                        int currentIndex = mLightState.Lights.IndexOf(light);
                        int distanceFromHead = (snakeHead - currentIndex) % snakeParts;
                        if (distanceFromHead < 0)
                            distanceFromHead += snakeParts;

                        int divideValue = distanceFromHead + 1;

                        light.Red = (int)c.R / divideValue ^ 3;
                        light.Green = (int)c.G / divideValue ^ 3;
                        light.Blue = (int)c.B / divideValue ^ 3;

                    }

                    mLightState.Update();
                    System.Threading.Thread.Sleep(500);
                }
            }
            mLightState.Clear();
        }


		#endregion
		
        #region Members / Properties
        protected ISnakeView mView;

        BackgroundWorker mSnakeWorker;

        protected bool mContinueSnaking = true; 
        #endregion

    }
}
