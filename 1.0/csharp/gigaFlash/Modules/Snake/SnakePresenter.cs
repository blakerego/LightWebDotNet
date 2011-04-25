using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Delegates;
using System.Drawing; 

namespace gigaFlash.Modules.Snake
{
	/// <summary>
	/// The logic in this class allows the lights to move in a snake-like fashion around the room. 
	/// By this I mean :         
	/// ... -  (|) - (||) - (|||)  
	/// </summary>
    public class SnakePresenter : LightModulePresenterBase
    {
        #region Constructor 
        public SnakePresenter(ISnakeView pView, LightState pState)
            : base(pState)
        {
            mView = pView; 
			mView.RunSnakeFired += new gigaFlash.Delegates.VoidDelegate(OnSnakeFired);
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
			int snakeParts = mLightState.Lights.Count; 
			Color c = Color.Aqua; 
			foreach (Light turn in mLightState.Lights) 
			{
				// Each light get its turn to be the head of the snake for the given color. 
				
				int snakeHead = mLightState.Lights.IndexOf(turn); 
				
				foreach(Light light in mLightState.Lights) 
				{
					int currentIndex = mLightState.Lights.IndexOf(light); 
					if (currentIndex == snakeHead) 
					{
						light.Color = c; 
					}
					else if (currentIndex == snakeHead - 1 
					         || currentIndex == snakeHead + snakeParts - 1) 
					{
						light.Red   = (int) c.R / 2;
						light.Green = (int) c.G / 2; 
						light.Blue  = (int) c.B / 2; 
					}
					else if (currentIndex == snakeHead - 2
					         || currentIndex == snakeHead + snakeParts - 2)
					{
						light.Red   = (int) c.R / 4; 
						light.Green = (int) c.G / 4; 
						light.Blue  = (int) c.B / 4; 
					}
					else 
					{
						light.Color = Color.Black; 
					}
				}
				
				mLightState.Update(); 
			}
		}
		#endregion
		
        #region Members / Properties
        protected ISnakeView mView;
        #endregion

    }
}
