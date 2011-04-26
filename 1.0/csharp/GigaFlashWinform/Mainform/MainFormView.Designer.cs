﻿namespace GigaFlashWinform
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
            this.mFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mAmpSineButton = new System.Windows.Forms.Button();
            this.mFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mFlowLayoutPanel
            // 
            this.mFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mFlowLayoutPanel.Controls.Add(this.button1);
            this.mFlowLayoutPanel.Controls.Add(this.button2);
            this.mFlowLayoutPanel.Controls.Add(this.mAmpSineButton);
            this.mFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mFlowLayoutPanel.Name = "mFlowLayoutPanel";
            this.mFlowLayoutPanel.Size = new System.Drawing.Size(136, 328);
            this.mFlowLayoutPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Light Selector";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HandleLightSelectorClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Snake";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.HandleSnakeModuleClicked);
            // 
            // mAmpSineButton
            // 
            this.mAmpSineButton.Location = new System.Drawing.Point(3, 61);
            this.mAmpSineButton.Name = "mAmpSineButton";
            this.mAmpSineButton.Size = new System.Drawing.Size(121, 23);
            this.mAmpSineButton.TabIndex = 2;
            this.mAmpSineButton.Text = "Amp Sine";
            this.mAmpSineButton.UseVisualStyleBackColor = true;
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 328);
            this.Controls.Add(this.mFlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainFormView";
            this.Text = "HydrogenHaus";
            this.mFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mFlowLayoutPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button mAmpSineButton;
    }
}