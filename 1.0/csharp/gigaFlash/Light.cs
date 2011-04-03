using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gigaFlash
{
    public class Light
    {
        #region Constructor 
        public Light(int pRed, int pGreen, int pBlue)
        {
            mRed = pRed;
            mGreen = pGreen;
            mBlue = pBlue; 
        }
        #endregion 

        #region Members / Properties
        protected int mRed;
        public int Red
        {
            get { return mRed; }
            set { mRed = value; } 
        }

        protected int mGreen;
        public int Green
        {
            get { return mGreen; }
            set { mGreen = value; } 
        }

        protected int mBlue;
        public int Blue
        {
            get { return mBlue; }
            set { mBlue = value; } 
        }
        #endregion 
    }
}
