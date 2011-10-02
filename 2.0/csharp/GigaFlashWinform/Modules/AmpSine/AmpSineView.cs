using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gigaFlash.Modules;
using gigaFlash.Delegates;

namespace GigaFlashWinform.Modules
{
    public partial class AmpSineView : BaseForm, IAmpSineView
    {
        #region Constructor
        public AmpSineView()
        {
            InitializeComponent();
        }
        #endregion

        #region Members / Properties
        public event TypedDelegate<Color> StartFired;

        public event VoidDelegate StopFired;

        public event VoidDelegate TwinkleFired;

        public event TypedDelegate<int> SpeedChanged; 

        public bool RunButtonEnabled
        {
            get
            {
                return mUniformButton.Enabled;
            }
            set
            {
                mUniformButton.Enabled = value;
            }
        }

        public bool TwinkleButtonEnabled
        {
            get
            {
                return mTwinkleButton.Enabled; 
            }
            set
            {
                mTwinkleButton.Enabled = value; 
            }
        }
        #endregion

        #region Handlers
        private void HandleRunButtonClicked(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                EventUtils.FireTypedEvent(StartFired, cd.Color);
            }
        }

        private void HandleStopButtonClicked(object sender, EventArgs e)
        {
            EventUtils.FireEvent(StopFired); 
        }

        private void mTwinkleButton_Click(object sender, EventArgs e)
        {
            EventUtils.FireEvent(TwinkleFired); 
        }

        private void mIntensityBar_ValueChanged(object sender, EventArgs e)
        {
            EventUtils.FireTypedEvent<int>(SpeedChanged, mIntensityBar.Value * 10); 
        }
        #endregion 
    
        #region IModuleView Members

        public new event VoidDelegate Disposing;

        

        #endregion


    }
}
