using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace gigaFlash
{
    public class LightGroup : ILightState
    {
        #region Constructor
        public LightGroup(List<int> pLights, ILightState pState)
        {
            mState = pState;
            foreach (int index in pLights)
            {
                try
                {
                    mLights.Add(pState.Lights[index]);
                }
                catch (IndexOutOfRangeException)
                {
                    //Index does not exist in this light state. 
                }
            }
        }
        #endregion 

        #region Public API
        public void Update(Color color)
        {
            foreach (Light light in mLights)
            {
                light.Color = color; 
            }
            Update(); 
        }

        public void Update()
        {
            mState.Update();
        }

        public void Clear()
        {
            foreach (Light light in mLights)
            {
                light.Color = Color.Black; 
            }
            Update(); 
        }

        public List<Light> Lights
        {
            get
            {
                return mLights; 
            }
            set
            {
                mLights = value;
            }
        }
        #endregion 

        #region Members / Fields
        protected List<Light> mLights = new List<Light>();

        protected ILightState mState; 
        #endregion 
    }
}
