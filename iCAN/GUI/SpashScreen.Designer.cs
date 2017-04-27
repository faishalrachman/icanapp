namespace iCAN.GUI
{
    partial class SpashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpashScreen));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.Loading = new MetroFramework.Controls.MetroLabel();
            this.notification = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(242, 86);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(287, 136);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(242, 253);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(287, 23);
            this.metroProgressBar1.TabIndex = 1;
            this.metroProgressBar1.Click += new System.EventHandler(this.metroProgressBar1_Click);
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Loading.Location = new System.Drawing.Point(333, 296);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(85, 25);
            this.Loading.TabIndex = 2;
            this.Loading.Text = "Loading...";
            this.Loading.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // notification
            // 
            this.notification.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.notification.AutoSize = true;
            this.notification.ForeColor = System.Drawing.Color.LimeGreen;
            this.notification.Location = new System.Drawing.Point(294, 331);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(165, 19);
            this.notification.TabIndex = 3;
            this.notification.Text = "Connecting To Database ...";
            this.notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer_tik);
            // 
            // SpashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 491);
            this.Controls.Add(this.notification);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "SpashScreen";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.SpashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel Loading;
        private MetroFramework.Controls.MetroLabel notification;
        private System.Windows.Forms.Timer timer1;
    }
}