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
            this.mLightSelectorButton = new System.Windows.Forms.Button();
            this.mSnakeButton = new System.Windows.Forms.Button();
            this.mAmpSineButton = new System.Windows.Forms.Button();
            this.mThunderButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mRoom = new GigaFlashWinform.RoomUI.Room();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mLightSelectorButton
            // 
            this.mLightSelectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mLightSelectorButton.Location = new System.Drawing.Point(11, 12);
            this.mLightSelectorButton.Name = "mLightSelectorButton";
            this.mLightSelectorButton.Size = new System.Drawing.Size(114, 23);
            this.mLightSelectorButton.TabIndex = 0;
            this.mLightSelectorButton.Text = "Light Selector";
            this.mLightSelectorButton.UseVisualStyleBackColor = true;
            this.mLightSelectorButton.Click += new System.EventHandler(this.HandleLightSelectorClicked);
            // 
            // mSnakeButton
            // 
            this.mSnakeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mSnakeButton.Location = new System.Drawing.Point(11, 41);
            this.mSnakeButton.Name = "mSnakeButton";
            this.mSnakeButton.Size = new System.Drawing.Size(114, 23);
            this.mSnakeButton.TabIndex = 1;
            this.mSnakeButton.Text = "Snake";
            this.mSnakeButton.UseVisualStyleBackColor = true;
            this.mSnakeButton.Click += new System.EventHandler(this.HandleSnakeModuleClicked);
            // 
            // mAmpSineButton
            // 
            this.mAmpSineButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mAmpSineButton.Location = new System.Drawing.Point(11, 70);
            this.mAmpSineButton.Name = "mAmpSineButton";
            this.mAmpSineButton.Size = new System.Drawing.Size(114, 23);
            this.mAmpSineButton.TabIndex = 2;
            this.mAmpSineButton.Text = "Sine";
            this.mAmpSineButton.UseVisualStyleBackColor = true;
            this.mAmpSineButton.Click += new System.EventHandler(this.mAmpSineButton_Click);
            // 
            // mThunderButton
            // 
            this.mThunderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mThunderButton.Location = new System.Drawing.Point(11, 99);
            this.mThunderButton.Name = "mThunderButton";
            this.mThunderButton.Size = new System.Drawing.Size(114, 23);
            this.mThunderButton.TabIndex = 2;
            this.mThunderButton.Text = "Thunder";
            this.mThunderButton.UseVisualStyleBackColor = true;
            this.mThunderButton.Click += new System.EventHandler(this.mThunderButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.mLightSelectorButton);
            this.splitContainer1.Panel1.Controls.Add(this.mSnakeButton);
            this.splitContainer1.Panel1.Controls.Add(this.mThunderButton);
            this.splitContainer1.Panel1.Controls.Add(this.mAmpSineButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mRoom);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(485, 295);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 2;
            // 
            // room1
            // 
            this.mRoom.BackColor = System.Drawing.Color.White;
            this.mRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mRoom.Location = new System.Drawing.Point(8, 8);
            this.mRoom.Name = "room1";
            this.mRoom.Size = new System.Drawing.Size(337, 280);
            this.mRoom.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(11, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HandleClearClicked);
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 295);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "MainFormView";
            this.Text = "HydrogenHaus";
            this.Load += new System.EventHandler(this.MainFormView_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MainFormView_Scroll);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormView_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mLightSelectorButton;
        private System.Windows.Forms.Button mSnakeButton;
        private System.Windows.Forms.Button mAmpSineButton;
        private System.Windows.Forms.Button mThunderButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private GigaFlashWinform.RoomUI.Room mRoom;
        private System.Windows.Forms.Button button1;
    }
}