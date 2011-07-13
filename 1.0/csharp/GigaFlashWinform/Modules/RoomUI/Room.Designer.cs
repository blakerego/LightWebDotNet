namespace GigaFlashWinform.RoomUI
{
    partial class Room
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.mIntensityBar = new System.Windows.Forms.TrackBar();
            this.mBrightnessLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lightView10 = new GigaFlashWinform.RoomUI.LightView();
            this.lightView9 = new GigaFlashWinform.RoomUI.LightView();
            this.lightView8 = new GigaFlashWinform.RoomUI.LightView();
            this.lightView7 = new GigaFlashWinform.RoomUI.LightView();
            this.lightView6 = new GigaFlashWinform.RoomUI.LightView();
            this.lightView5 = new GigaFlashWinform.RoomUI.LightView();
            this.lightView4 = new GigaFlashWinform.RoomUI.LightView();
            this.lightView3 = new GigaFlashWinform.RoomUI.LightView();
            this.lightView2 = new GigaFlashWinform.RoomUI.LightView();
            this.lightView1 = new GigaFlashWinform.RoomUI.LightView();
            this.allLightView1 = new GigaFlashWinform.RoomUI.AllLightView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mIntensityBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mIntensityBar
            // 
            this.mIntensityBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mIntensityBar.Location = new System.Drawing.Point(12, 76);
            this.mIntensityBar.Name = "mIntensityBar";
            this.mIntensityBar.Size = new System.Drawing.Size(148, 45);
            this.mIntensityBar.TabIndex = 11;
            this.mIntensityBar.Value = 10;
            this.mIntensityBar.ValueChanged += new System.EventHandler(this.HandleBrightnessValueChanged);
            // 
            // mBrightnessLabel
            // 
            this.mBrightnessLabel.AutoSize = true;
            this.mBrightnessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mBrightnessLabel.Location = new System.Drawing.Point(35, 55);
            this.mBrightnessLabel.Name = "mBrightnessLabel";
            this.mBrightnessLabel.Size = new System.Drawing.Size(69, 18);
            this.mBrightnessLabel.TabIndex = 12;
            this.mBrightnessLabel.Text = "Intensity: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HandleSetRoomColorClicked);
            // 
            // lightView10
            // 
            this.lightView10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView10.Intensity = 100;
            this.lightView10.LabelName = "06";
            this.lightView10.Location = new System.Drawing.Point(3, 171);
            this.lightView10.Name = "lightView10";
            this.lightView10.Padding = new System.Windows.Forms.Padding(5);
            this.lightView10.Selected = false;
            this.lightView10.Size = new System.Drawing.Size(50, 50);
            this.lightView10.TabIndex = 10;
            // 
            // lightView9
            // 
            this.lightView9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView9.Intensity = 100;
            this.lightView9.LabelName = "09";
            this.lightView9.Location = new System.Drawing.Point(3, 3);
            this.lightView9.Name = "lightView9";
            this.lightView9.Padding = new System.Windows.Forms.Padding(5);
            this.lightView9.Selected = false;
            this.lightView9.Size = new System.Drawing.Size(50, 50);
            this.lightView9.TabIndex = 9;
            // 
            // lightView8
            // 
            this.lightView8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView8.Intensity = 100;
            this.lightView8.LabelName = "08";
            this.lightView8.Location = new System.Drawing.Point(3, 59);
            this.lightView8.Name = "lightView8";
            this.lightView8.Padding = new System.Windows.Forms.Padding(5);
            this.lightView8.Selected = false;
            this.lightView8.Size = new System.Drawing.Size(50, 50);
            this.lightView8.TabIndex = 8;
            // 
            // lightView7
            // 
            this.lightView7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView7.Intensity = 100;
            this.lightView7.LabelName = "07";
            this.lightView7.Location = new System.Drawing.Point(3, 115);
            this.lightView7.Name = "lightView7";
            this.lightView7.Padding = new System.Windows.Forms.Padding(5);
            this.lightView7.Selected = false;
            this.lightView7.Size = new System.Drawing.Size(50, 50);
            this.lightView7.TabIndex = 7;
            // 
            // lightView6
            // 
            this.lightView6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView6.Intensity = 100;
            this.lightView6.LabelName = "05";
            this.lightView6.Location = new System.Drawing.Point(59, 227);
            this.lightView6.Name = "lightView6";
            this.lightView6.Padding = new System.Windows.Forms.Padding(5);
            this.lightView6.Selected = false;
            this.lightView6.Size = new System.Drawing.Size(50, 50);
            this.lightView6.TabIndex = 5;
            // 
            // lightView5
            // 
            this.lightView5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView5.Intensity = 100;
            this.lightView5.LabelName = "04";
            this.lightView5.Location = new System.Drawing.Point(115, 227);
            this.lightView5.Name = "lightView5";
            this.lightView5.Padding = new System.Windows.Forms.Padding(5);
            this.lightView5.Selected = false;
            this.lightView5.Size = new System.Drawing.Size(50, 50);
            this.lightView5.TabIndex = 4;
            // 
            // lightView4
            // 
            this.lightView4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView4.Intensity = 100;
            this.lightView4.LabelName = "03";
            this.lightView4.Location = new System.Drawing.Point(171, 227);
            this.lightView4.Name = "lightView4";
            this.lightView4.Padding = new System.Windows.Forms.Padding(5);
            this.lightView4.Selected = false;
            this.lightView4.Size = new System.Drawing.Size(50, 50);
            this.lightView4.TabIndex = 3;
            // 
            // lightView3
            // 
            this.lightView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView3.Intensity = 100;
            this.lightView3.LabelName = "02";
            this.lightView3.Location = new System.Drawing.Point(227, 227);
            this.lightView3.Name = "lightView3";
            this.lightView3.Padding = new System.Windows.Forms.Padding(5);
            this.lightView3.Selected = false;
            this.lightView3.Size = new System.Drawing.Size(50, 50);
            this.lightView3.TabIndex = 2;
            // 
            // lightView2
            // 
            this.lightView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView2.Intensity = 100;
            this.lightView2.LabelName = "01";
            this.lightView2.Location = new System.Drawing.Point(283, 171);
            this.lightView2.Name = "lightView2";
            this.lightView2.Padding = new System.Windows.Forms.Padding(5);
            this.lightView2.Selected = false;
            this.lightView2.Size = new System.Drawing.Size(50, 50);
            this.lightView2.TabIndex = 1;
            // 
            // lightView1
            // 
            this.lightView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lightView1.Intensity = 100;
            this.lightView1.LabelName = "00";
            this.lightView1.Location = new System.Drawing.Point(283, 115);
            this.lightView1.Name = "lightView1";
            this.lightView1.Padding = new System.Windows.Forms.Padding(5);
            this.lightView1.Selected = false;
            this.lightView1.Size = new System.Drawing.Size(50, 50);
            this.lightView1.TabIndex = 0;
            // 
            // allLightView1
            // 
            this.allLightView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.allLightView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allLightView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.allLightView1.Intensity = 100;
            this.allLightView1.LabelName = "##";
            this.allLightView1.Location = new System.Drawing.Point(0, 0);
            this.allLightView1.Name = "allLightView1";
            this.allLightView1.Padding = new System.Windows.Forms.Padding(5);
            this.allLightView1.Selected = false;
            this.allLightView1.Size = new System.Drawing.Size(50, 50);
            this.allLightView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mBrightnessLabel);
            this.groupBox1.Controls.Add(this.mIntensityBar);
            this.groupBox1.Location = new System.Drawing.Point(77, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 130);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lightView10);
            this.Controls.Add(this.lightView9);
            this.Controls.Add(this.lightView8);
            this.Controls.Add(this.lightView7);
            this.Controls.Add(this.lightView6);
            this.Controls.Add(this.lightView5);
            this.Controls.Add(this.lightView4);
            this.Controls.Add(this.lightView3);
            this.Controls.Add(this.lightView2);
            this.Controls.Add(this.lightView1);
            this.Name = "Room";
            this.Size = new System.Drawing.Size(337, 280);
            ((System.ComponentModel.ISupportInitialize)(this.mIntensityBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LightView lightView1;
        private LightView lightView2;
        private LightView lightView3;
        private LightView lightView4;
        private LightView lightView5;
        private LightView lightView6;
        private LightView lightView7;
        private LightView lightView8;
        private LightView lightView9;
        private LightView lightView10;
        private System.Windows.Forms.TrackBar mIntensityBar;
        private System.Windows.Forms.Label mBrightnessLabel;
        private System.Windows.Forms.Button button1;
        private AllLightView allLightView1;
        private System.Windows.Forms.GroupBox groupBox1;




    }
}
