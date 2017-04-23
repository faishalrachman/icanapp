namespace iCAN.GUI
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mPanel
            // 
            this.mPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(23, 63);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(744, 401);
            this.mPanel.TabIndex = 0;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // mlBack
            // 
            this.mlBack.Image = ((System.Drawing.Image)(resources.GetObject("mlBack.Image")));
            this.mlBack.ImageSize = 32;
            this.mlBack.Location = new System.Drawing.Point(137, 21);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(67, 36);
            this.mlBack.TabIndex = 1;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.MlBack);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 487);
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mlBack);
            this.Name = "MainDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardSiswa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLink mlBack;
    }
}