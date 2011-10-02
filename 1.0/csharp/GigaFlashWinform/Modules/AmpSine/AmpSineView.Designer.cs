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
            this.mIntensityBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mIntensityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mUniformButton
            // 
            this.mUniformButton.BackColor = System.Drawing.Color.Black;
            this.mUniformButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mUniformButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mUniformButton.Location = new System.Drawing.Point(166, 12);
            this.mUniformButton.Name = "mUniformButton";
            this.mUniformButton.Size = new System.Drawing.Size(96, 23);
            this.mUniformButton.TabIndex = 0;
            this.mUniformButton.Text = "Uniform";
            this.mUniformButton.UseVisualStyleBackColor = false;
            this.mUniformButton.Click += new System.EventHandler(this.HandleRunButtonClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(166, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.HandleStopButtonClicked);
            // 
            // mTwinkleButton
            // 
            this.mTwinkleButton.BackColor = System.Drawing.Color.Black;
            this.mTwinkleButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTwinkleButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mTwinkleButton.Location = new System.Drawing.Point(166, 41);
            this.mTwinkleButton.Name = "mTwinkleButton";
            this.mTwinkleButton.Size = new System.Drawing.Size(96, 23);
            this.mTwinkleButton.TabIndex = 2;
            this.mTwinkleButton.Text = "Twinkle";
            this.mTwinkleButton.UseVisualStyleBackColor = false;
            this.mTwinkleButton.Click += new System.EventHandler(this.mTwinkleButton_Click);
            // 
            // mIntensityBar
            // 
            this.mIntensityBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mIntensityBar.Location = new System.Drawing.Point(12, 48);
            this.mIntensityBar.Name = "mIntensityBar";
            this.mIntensityBar.Size = new System.Drawing.Size(148, 45);
            this.mIntensityBar.TabIndex = 12;
            this.mIntensityBar.Value = 5;
            this.mIntensityBar.ValueChanged += new System.EventHandler(this.mIntensityBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Speed";
            // 
            // AmpSineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 107);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mIntensityBar);
            this.Controls.Add(this.mTwinkleButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mUniformButton);
            this.Name = "AmpSineView";
            this.Text = "Pulse";
            ((System.ComponentModel.ISupportInitialize)(this.mIntensityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mUniformButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mTwinkleButton;
        private System.Windows.Forms.TrackBar mIntensityBar;
        private System.Windows.Forms.Label label1;
    }
}