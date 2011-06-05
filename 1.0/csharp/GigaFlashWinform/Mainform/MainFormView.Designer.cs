namespace GigaFlashWinform
{
    partial class MainFormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.mRoom = new GigaFlashWinform.RoomUI.Room();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(247, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HandleClearClicked);
            // 
            // mRoom
            // 
            this.mRoom.BackColor = System.Drawing.Color.White;
            this.mRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mRoom.Location = new System.Drawing.Point(14, 26);
            this.mRoom.Name = "mRoom";
            this.mRoom.Size = new System.Drawing.Size(337, 280);
            this.mRoom.TabIndex = 0;
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 341);
            this.Controls.Add(this.mRoom);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "MainFormView";
            this.Text = "HydrogenHaus";
            this.Load += new System.EventHandler(this.MainFormView_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MainFormView_Scroll);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormView_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private GigaFlashWinform.RoomUI.Room mRoom;
        private System.Windows.Forms.Button button1;
    }
}