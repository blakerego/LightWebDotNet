using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gigaFlash;
using gigaFlash.Mainform;

namespace GigaFlashWinform.UserAccess
{
    public partial class LoginScreen : BaseForm
    {
        public LoginScreen(MainFormView pParentMFV)
        {
            mParentForm = pParentMFV; 
            InitializeComponent();
        }

        private void HandleCancelClicked(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void HandleOKClicked(object sender, EventArgs e)
        {
            MainFormView mainform = this.ParentMainForm;
            if (mainform != null)
            {
                mainform.CurrentUser = textBox1.Text; 
            }
            this.Close(); 
        }

        protected MainFormView mParentForm;

        public MainFormView ParentMainForm
        {
            get { return mParentForm; } 
        }
    }
}
