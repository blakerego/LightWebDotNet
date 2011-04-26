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
        public event gigaFlash.Delegates.VoidDelegate StartFired;

        public event gigaFlash.Delegates.VoidDelegate StopFired;
        #endregion

        #region Handlers
        private void HandleRunButtonClicked(object sender, EventArgs e)
        {
            EventUtils.FireEvent(StartFired); 
        }

        private void HandleStopButtonClicked(object sender, EventArgs e)
        {
            EventUtils.FireEvent(StopFired); 
        }
        #endregion 
    }
}
