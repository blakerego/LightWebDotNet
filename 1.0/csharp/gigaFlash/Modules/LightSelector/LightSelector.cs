using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gigaFlash
{
    public partial class LightSelector : Form
    {
        #region Constructor
        public LightSelector()
        {
            InitializeComponent();
            mState = new LightState();

            int counter = 1; 
            foreach (Light l in mState.Lights)
            {
                mListbox.Items.Add("Light" + counter.ToString());
                counter++;
            }
            mObjectCollection = mListbox.Items; 

        }
        #endregion

        #region Handlers 
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = colorDialog1.ShowDialog(this);

            if (r == DialogResult.OK)
            {
                //mState.Update(colorDialog1.Color);

                ListBox.SelectedObjectCollection items = mListbox.SelectedItems;
                
                foreach (object selectedObject in items)
                {
                    int selectedindex = mListbox.Items.IndexOf(selectedObject);
                    mState.Lights[selectedindex].Color = colorDialog1.Color; 
                }
                mState.Update(); 
                mRedTextbox.Text = colorDialog1.Color.R.ToString();
                mGreenTextbox.Text = colorDialog1.Color.G.ToString();
                mBlueTextbox.Text = colorDialog1.Color.B.ToString(); 
            }
        }

        private void HandleClearClicked(object sender, EventArgs e)
        {
            mState.Clear();
            mRedTextbox.Text = "0";
            mGreenTextbox.Text = "0";
            mBlueTextbox.Text = "0";
        }
        #endregion

        #region Members / Properties
        protected LightState mState;

        protected ListBox.ObjectCollection mObjectCollection; 
        #endregion 

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            mState.Clear(); 

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        private void LightSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            mState.Clear(); 
        }
    }
}
