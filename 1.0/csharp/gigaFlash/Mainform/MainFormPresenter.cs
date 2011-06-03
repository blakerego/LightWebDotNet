using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gigaFlash.Modules;
using System.Windows.Forms;
using System.Drawing;

namespace gigaFlash.Mainform
{
    public class MainFormPresenter
    {
        #region Constructor 
        public MainFormPresenter(IMainformView pView, LightState pState)
        {
            mView = pView;
            mState = pState; 
            mView.LightSelectorClicked += new gigaFlash.Delegates.VoidDelegate(OnLightSelectorClicked);
            mView.SnakeModuleClicked += new gigaFlash.Delegates.VoidDelegate(OnSnakeModuleClicked);
            mView.AmpSineClicked += new gigaFlash.Delegates.VoidDelegate(OnAmpSineClicked);
            mView.ThunderClicked += new gigaFlash.Delegates.VoidDelegate(OnThunderClicked);
            mView.MoveLightLeftEvent += new gigaFlash.Delegates.VoidDelegate(OnLightLeftEvent);
            mView.MoveLightRightEvent += new gigaFlash.Delegates.VoidDelegate(OnLightRightEvent);
            mView.ClickEventFired += new gigaFlash.Delegates.VoidDelegate(OnClickEvent);
        }

        #endregion 

        #region Handlers 
        protected virtual void OnLightSelectorClicked()
        {
            GetPresenter<LightSelectorPresenter, LightSelectorFactory>().ShowUI(); 
        }

        protected virtual void OnSnakeModuleClicked()
        {
            GetPresenter<SnakePresenter, SnakePresFactory>().ShowUI(); 
        }

        protected virtual void OnAmpSineClicked()
        {
            GetPresenter<AmpSinePresenter, AmpSinePresFactory>().ShowUI(); 
        }

        protected virtual void OnThunderClicked()
        {
            GetPresenter<ThunderPresenter, ThunderPresenterFactory>().ShowUI();  
        }

        protected int mLightIntensity = 100; 
        protected virtual void OnScrollEvent(int value)
        {
            //set previous light to black
            int lightIndex = mLightIntensity % mState.Lights.Count;
            mState.Lights[lightIndex].Color = Color.Black; 

            // set new light. 
            lightIndex = mLightIntensity++ % mState.Lights.Count; 
            mState.Lights[lightIndex].Color = Color.Red; 

        }

        void OnLightRightEvent()
        {
            if (mLightIntensity <= 99)
            {
                mLightIntensity++; 
            }
            UpdateRandomColor(); 
        }

        void OnLightLeftEvent()
        {
            if (mLightIntensity >= 1)
            {
                mLightIntensity--; 
            }
            UpdateRandomColor(); 
        }

        protected void UpdateRandomColor()
        {
            foreach (Light light in mState.Lights)
            {
                light.Color = Color.FromArgb(
                    mLightIntensity * mCurrentRandomColor.R / 100,
                    mLightIntensity * mCurrentRandomColor.G / 100,
                    mLightIntensity * mCurrentRandomColor.B / 100
                    );
            }
            mState.Update(); 
        }

        protected virtual void OnClickEvent()
        {
            mCurrentRandomColor = ColorUtils.GetRandomColor(); 

            //Get Max val

            //Scale up color to brightest ratio.

            foreach(Light light in mState.Lights) 
            {
                light.Color = mCurrentRandomColor; 
            }
            UpdateRandomColor(); 
        }

        #endregion 

        #region Public Methods
        public Pres GetPresenter<Pres, Factory>()
            where Pres : LightModulePresenterBase
            where Factory : LightModuleFactoryBase<Pres>
        {
            Factory factory = Activator.CreateInstance(typeof(Factory)) as Factory;
            return factory.Create(mState);
        }
        #endregion 

        #region Members / Properties
        protected IMainformView mView;

        protected LightState mState;

        protected Color mCurrentRandomColor;
        #endregion
    }
}
