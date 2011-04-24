using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gigaFlash.Mainform;
using gigaFlash.Delegates;

namespace gigaFlash.Mainform
{
    public partial class MainFormView : Form, IMainformView
    {
        #region Constructor 
        public MainFormView()
        {
            InitializeComponent();
        }
        #endregion 

        #region Members / Properties
        public FlowLayoutPanel FlowLayoutPanel
        {
            get { return mFlowLayoutPanel; } 
        }

        public Control Control
        {
            get
            {
                return this;
            }
        }

        public event gigaFlash.Delegates.VoidDelegate LightSelectorClicked;
        #endregion

        #region Handlers
        private void HandleLightSelectorClicked(object sender, EventArgs e)
        {
            EventUtils.FireEvent(LightSelectorClicked);
        }
        #endregion 
    }
}
