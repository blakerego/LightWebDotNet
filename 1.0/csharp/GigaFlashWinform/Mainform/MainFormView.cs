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


namespace GigaFlashWinform
{
    public partial class MainFormView : BaseForm, IMainformView
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

        public event VoidDelegate LightSelectorClicked;

        public event VoidDelegate SnakeModuleClicked;

        public event VoidDelegate AmpSineClicked; 
        #endregion

        #region Handlers
        private void HandleLightSelectorClicked(object sender, EventArgs e)
        {
            EventUtils.FireEvent(LightSelectorClicked);
        }
        #endregion 

        private void HandleSnakeModuleClicked(object sender, EventArgs e)
        {
            EventUtils.FireEvent(SnakeModuleClicked); 
        }

        private void mAmpSineButton_Click(object sender, EventArgs e)
        {
            EventUtils.FireEvent(AmpSineClicked); 
        }
    }
}
