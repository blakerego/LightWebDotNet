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
            this.mFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mLightSelectorButton = new System.Windows.Forms.Button();
            this.mSnakeButton = new System.Windows.Forms.Button();
            this.mAmpSineButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mFlowLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mFlowLayoutPanel
            // 
            this.mFlowLayoutPanel.Controls.Add(this.mLightSelectorButton);
            this.mFlowLayoutPanel.Controls.Add(this.mSnakeButton);
            this.mFlowLayoutPanel.Controls.Add(this.mAmpSineButton);
            this.mFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mFlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.mFlowLayoutPanel.Name = "mFlowLayoutPanel";
            this.mFlowLayoutPanel.Size = new System.Drawing.Size(153, 109);
            this.mFlowLayoutPanel.TabIndex = 0;
            // 
            // mLightSelectorButton
            // 
            this.mLightSelectorButton.Location = new System.Drawing.Point(3, 3);
            this.mLightSelectorButton.Name = "mLightSelectorButton";
            this.mLightSelectorButton.Size = new System.Drawing.Size(146, 23);
            this.mLightSelectorButton.TabIndex = 0;
            this.mLightSelectorButton.Text = "Light Selector";
            this.mLightSelectorButton.UseVisualStyleBackColor = true;
            this.mLightSelectorButton.Click += new System.EventHandler(this.HandleLightSelectorClicked);
            // 
            // mSnakeButton
            // 
            this.mSnakeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mSnakeButton.Location = new System.Drawing.Point(3, 32);
            this.mSnakeButton.Name = "mSnakeButton";
            this.mSnakeButton.Size = new System.Drawing.Size(146, 23);
            this.mSnakeButton.TabIndex = 1;
            this.mSnakeButton.Text = "Snake";
            this.mSnakeButton.UseVisualStyleBackColor = true;
            this.mSnakeButton.Click += new System.EventHandler(this.HandleSnakeModuleClicked);
            // 
            // mAmpSineButton
            // 
            this.mAmpSineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mAmpSineButton.Location = new System.Drawing.Point(3, 61);
            this.mAmpSineButton.Name = "mAmpSineButton";
            this.mAmpSineButton.Size = new System.Drawing.Size(146, 23);
            this.mAmpSineButton.TabIndex = 2;
            this.mAmpSineButton.Text = "Amp Sine";
            this.mAmpSineButton.UseVisualStyleBackColor = true;
            this.mAmpSineButton.Click += new System.EventHandler(this.mAmpSineButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.19889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.80111F));
            this.tableLayoutPanel1.Controls.Add(this.mFlowLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 115);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 115);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "MainFormView";
            this.Text = "HydrogenHaus";
            this.mFlowLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mFlowLayoutPanel;
        private System.Windows.Forms.Button mLightSelectorButton;
        private System.Windows.Forms.Button mSnakeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mAmpSineButton;
    }
}