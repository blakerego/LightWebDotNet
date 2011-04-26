namespace GigaFlashWinform.Modules
{
    partial class AmpSineView
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
            this.mUniformButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mTwinkleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mUniformButton
            // 
            this.mUniformButton.Location = new System.Drawing.Point(12, 12);
            this.mUniformButton.Name = "mUniformButton";
            this.mUniformButton.Size = new System.Drawing.Size(75, 23);
            this.mUniformButton.TabIndex = 0;
            this.mUniformButton.Text = "Uniform";
            this.mUniformButton.UseVisualStyleBackColor = true;
            this.mUniformButton.Click += new System.EventHandler(this.HandleRunButtonClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.HandleStopButtonClicked);
            // 
            // mTwinkleButton
            // 
            this.mTwinkleButton.Location = new System.Drawing.Point(93, 12);
            this.mTwinkleButton.Name = "mTwinkleButton";
            this.mTwinkleButton.Size = new System.Drawing.Size(75, 23);
            this.mTwinkleButton.TabIndex = 2;
            this.mTwinkleButton.Text = "Twinkle";
            this.mTwinkleButton.UseVisualStyleBackColor = true;
            this.mTwinkleButton.Click += new System.EventHandler(this.mTwinkleButton_Click);
            // 
            // AmpSineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 51);
            this.Controls.Add(this.mTwinkleButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mUniformButton);
            this.Name = "AmpSineView";
            this.Text = "AmpSineView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mUniformButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mTwinkleButton;
    }
}