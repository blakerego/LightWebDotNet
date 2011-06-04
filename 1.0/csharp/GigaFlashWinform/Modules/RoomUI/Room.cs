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
        #region Constructor
        public Room()
        {
            InitializeComponent();
            AddLight(lightView1);
            AddLight(lightView2);
            AddLight(lightView3);
            AddLight(lightView4);
            AddLight(lightView5);
            AddLight(lightView6);
            AddLight(lightView10); 
            AddLight(lightView7);
            AddLight(lightView8);
            AddLight(lightView9);
            lightView1.Selected = true;
            this.MouseWheel += new MouseEventHandler(OnMouseWheel);
            this.Click += new EventHandler(OnRoomClickEvent);
        }
        #endregion 

        #region Public Methods
        public void UpdateRoom(Color c)
        {
            foreach (LightView lv in mLightViews)
            {
                lv.Color = c; 
            }

            // -1 updates all lights. 
            EventUtils.FireDualTypedEvent(LightUpdate, -1, c); 
        }
        #endregion 

        #region Handlers / Helpers
        protected void AddLight(LightView pView)
        {
            pView.DirectClickEvent += new TypedDelegate<LightView>(OnDirectLightClick);
            mLightViews.Add(pView); 
        }

        protected void OnDirectLightClick(LightView pSelectedLight)
        {
            foreach (LightView lv in mLightViews)
            {
                if (lv != pSelectedLight)
                {
                    lv.Selected = false; 
                }
            }
            pSelectedLight.Selected = true;
            mColorModeSelected = true;
            InitializeSelectedLight(pSelectedLight); 

        }

        protected void OnMouseWheel(object sender, MouseEventArgs e)
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

        protected void OnRoomClickEvent(object sender, EventArgs e)
        {
            // Toggles the mode selection. 
            mColorModeSelected = !mColorModeSelected;

            // Chooses random color if in color mode. 
            if (mColorModeSelected)
            {
                InitializeSelectedLight(mLightViews[mHoverIndex]); 
            }
        }

        protected void InitializeSelectedLight(LightView pSelectedLight)
        {
            mHoverIndex = mLightViews.IndexOf(pSelectedLight); 
            Color curColor = ColorUtils.GetRandomColor();
            pSelectedLight.Color = curColor;
            EventUtils.FireDualTypedEvent(LightUpdate,
                mHoverIndex, 
                curColor);  
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

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (DialogResult.OK == d.ShowDialog())
            {
                Color color = d.Color; 
                EventUtils.FireDualTypedEvent(LightUpdate, 
                    -1, 
                    color);
                foreach (LightView lv in mLightViews)
                {
                    lv.LightIntensity = 100; 
                    lv.Color = color;
                }
            }
        }
    }
}
