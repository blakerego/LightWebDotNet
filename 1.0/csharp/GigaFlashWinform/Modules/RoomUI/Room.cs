using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gigaFlash;
using gigaFlash.Delegates;

namespace GigaFlashWinform.RoomUI
{
    public partial class Room : UserControl, IRoom
    {
        public Room()
        {
            InitializeComponent();
            mLightViews.Add(lightView1);
            mLightViews.Add(lightView2);
            mLightViews.Add(lightView3);
            mLightViews.Add(lightView4);
            mLightViews.Add(lightView5);
            mLightViews.Add(lightView6);
            mLightViews.Add(lightView10); 
            mLightViews.Add(lightView7);
            mLightViews.Add(lightView8);
            mLightViews.Add(lightView9);
            lightView1.Selected = true;
            this.MouseWheel += new MouseEventHandler(OnMouseWheel);
            this.Click += new EventHandler(Room_Click);
        }

        #region Handlers
        void OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (mColorModeSelected)
            {
                // Send value to the focused light
                LightView currentLight = mLightViews[mHoverIndex];
                if (e.Delta < 0)
                {
                    currentLight.IncreaseBrightness();
                }
                else if (e.Delta > 0)
                {
                    currentLight.DecreaseBrightness(); 
                }
                EventUtils.FireDualTypedEvent(LightUpdate, mHoverIndex, currentLight.Color);
            }
            else
            {
                // Move focus around the room.
                mLightViews[mHoverIndex].Selected = false;
                if (e.Delta < 0)
                    mHoverIndex++;
                else
                    if (mHoverIndex == 0)
                        mHoverIndex += mLightViews.Count - 1;
                    else
                        mHoverIndex--;

                mHoverIndex = mHoverIndex % (mLightViews.Count);
                mLightViews[mHoverIndex].Selected = true;
            }
        }

        void Room_Click(object sender, EventArgs e)
        {
            // Toggles the mode selection. 
            mColorModeSelected = !mColorModeSelected;

            // Chooses random color if in color mode. 
            if (mColorModeSelected)
            {
                Color curColor = ColorUtils.GetRandomColor(); 
                mLightViews[mHoverIndex].Color = curColor;
                EventUtils.FireDualTypedEvent(LightUpdate, mHoverIndex, curColor);  
            }
        }
        #endregion

        #region Members / Properties
        protected List<LightView> mLightViews = new List<LightView>();

        protected int mHoverIndex = 0;

        public event DualTypedDelegate<int, Color> LightUpdate;

        protected bool mColorModeSelected = false;

        public new event VoidDelegate Disposing;
        #endregion

        #region Dispose
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            EventUtils.FireEvent(Disposing); 
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
