using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gigaFlash.Delegates;

namespace gigaFlash.Modules.Snake
{
    public partial class SnakeView : Form, ISnakeView
    {
		#region Constructor
        public SnakeView()
        {
            InitializeComponent();
        }
		#endregion
		
		#region Members / Properties
		public event VoidDelegate RunSnakeFired;
		#endregion
    }
}
