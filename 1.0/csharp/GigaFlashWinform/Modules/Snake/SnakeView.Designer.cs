namespace GigaFlashWinform
{
    partial class SnakeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mClockwise = new System.Windows.Forms.RadioButton();
            this.mCounterClockwise = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mSnakeButton = new System.Windows.Forms.Button();
            this.mStopButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mClockwise
            // 
            this.mClockwise.AutoSize = true;
            this.mClockwise.Location = new System.Drawing.Point(6, 19);
            this.mClockwise.Name = "mClockwise";
            this.mClockwise.Size = new System.Drawing.Size(73, 17);
            this.mClockwise.TabIndex = 0;
            this.mClockwise.TabStop = true;
            this.mClockwise.Text = "Clockwise";
            this.mClockwise.UseVisualStyleBackColor = true;
            // 
            // mCounterClockwise
            // 
            this.mCounterClockwise.AutoSize = true;
            this.mCounterClockwise.Location = new System.Drawing.Point(6, 43);
            this.mCounterClockwise.Name = "mCounterClockwise";
            this.mCounterClockwise.Size = new System.Drawing.Size(113, 17);
            this.mCounterClockwise.TabIndex = 1;
            this.mCounterClockwise.TabStop = true;
            this.mCounterClockwise.Text = "Counter-Clockwise";
            this.mCounterClockwise.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mClockwise);
            this.groupBox1.Controls.Add(this.mCounterClockwise);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // mSnakeButton
            // 
            this.mSnakeButton.Location = new System.Drawing.Point(12, 121);
            this.mSnakeButton.Name = "mSnakeButton";
            this.mSnakeButton.Size = new System.Drawing.Size(75, 23);
            this.mSnakeButton.TabIndex = 3;
            this.mSnakeButton.Text = "Snake!";
            this.mSnakeButton.UseVisualStyleBackColor = true;
            this.mSnakeButton.Click += new System.EventHandler(this.HandleRunSnakeClicked);
            // 
            // mStopButton
            // 
            this.mStopButton.Location = new System.Drawing.Point(93, 121);
            this.mStopButton.Name = "mStopButton";
            this.mStopButton.Size = new System.Drawing.Size(75, 23);
            this.mStopButton.TabIndex = 4;
            this.mStopButton.Text = "Stop";
            this.mStopButton.UseVisualStyleBackColor = true;
            this.mStopButton.Click += new System.EventHandler(this.HandleStopSnakeClicked);
            // 
            // SnakeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 187);
            this.Controls.Add(this.mStopButton);
            this.Controls.Add(this.mSnakeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SnakeView";
            this.Text = "SnakeView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton mClockwise;
        private System.Windows.Forms.RadioButton mCounterClockwise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mSnakeButton;
        private System.Windows.Forms.Button mStopButton;
    }
}