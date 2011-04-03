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
    public partial class InitialUI : Form
    {
        public InitialUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LightState s = new LightState();
            s.Update(); 
        }
    }
}
