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
using gigaFlash.ConfigObjects;
using GigaFlashWinform.Modules.RoomUI;

namespace GigaFlashWinform.RoomUI
{
    public partial class LightView : UserControl, ILightView
    {
        #region Constructor 
        public LightView()
        {
            InitializeComponent();

            ContextMenu menu = new ContextMenu();
            MenuItem saveColorMenuItem = new MenuItem("Save Color");
            saveColorMenuItem.Click += new EventHandler(SaveColorClicked);
            menu.MenuItems.Add(saveColorMenuItem);
            button1.ContextMenu = menu;

        }

        #endregion 

        #region Methods / Handlers 
        public void IncreaseBrightness()
        {
            if (mLightIntensity <= 100 - mSensitivity)
            {
                for (int i = 0; i < mSensitivity; i++)
                {
                    mLightIntensity++;
                }
                this.BackColor = Color;
            }
        }

        public void DecreaseBrightness()
        {
            if (mLightIntensity >= mSensitivity)
            {
                for (int i = 0; i < mSensitivity; i++)
                {
                    mLightIntensity--;
                }
                this.BackColor = Color; 
            }
        }

        protected virtual void SaveColorClicked(object sender, EventArgs e)
        {
            ColorConfig colorconfig = new ColorConfig(); 
            colorconfig.Color = mColor;
            ColorSaveDialog cd = new ColorSaveDialog(); 
            if (cd.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                colorconfig.Name = cd.ColorName; 
                colorconfig.TotalUseCount = 1; 
                colorconfig.LastUseDate = DateTime.Now.ToString();
                EventUtils.FireTypedEvent(SaveFired, colorconfig); 
            }
        }

        protected void HandleDirectButtonClick(object sender, EventArgs e)
        {
            EventUtils.FireTypedEvent(DirectClickEvent, this); 
        }
        #endregion 

        #region Members / Properties
        protected bool mSelected; 
        public bool Selected
        {
            get
            {
                return mSelected;
            }
            set
            {
                mSelected = value;

                // button.Font.Bold is read-only. 
                // needed to re-instatiate the Font class to update 
                // whether or not the font button was selected.
                FontStyle fontstyle;
                if (value == true)
                    fontstyle = FontStyle.Underline;
                else
                    fontstyle = FontStyle.Regular; 
                button1.Font = 
                    new System.Drawing.Font(
                        button1.Font.FontFamily,
                        button1.Font.Size,
                        fontstyle,
                        System.Drawing.GraphicsUnit.Point, 
                        button1.Font.GdiCharSet)
                        ;
            }
        }

        protected Color mColor;
        public virtual Color Color
        {
            get
            {
                return Color.FromArgb(
                    mColor.R * mLightIntensity / 100,
                    mColor.G * mLightIntensity / 100, 
                    mColor.B * mLightIntensity / 100); 
            }
            set
            {
                mColor = value; 
                this.BackColor = Color; 
            }
        }

        protected int mLightIntensity = 100;
        public int Intensity
        {
            get { return mLightIntensity; }
            set 
            { 
                mLightIntensity = value;
                this.BackColor = Color;
            }
        }

        public string LabelName
        {
            get { return button1.Text;  }
            set { button1.Text = value; }
        }

        protected int mSensitivity = 3;

        /// <summary>
        /// Occurs when a user clicks on a light directly. 
        /// </summary>
        public event TypedDelegate<LightView> DirectClickEvent;

        public event TypedDelegate<ColorConfig> SaveFired; 
        #endregion
    }
}
