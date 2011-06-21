using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash.Modules
{
	public class LightViewPresenter
	{
		#region Constructor
		public LightViewPresenter(ILightView pView)
		{
			mView = pView;
			//mModel = pModel; 
		}
		#endregion 

		#region Public API

		#endregion

		#region Members / Properties
		protected ILightView mView;

		protected Light mModel;

		protected SineControl mSineControl; 
		#endregion
	}
}
