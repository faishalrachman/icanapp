﻿namespace iCAN.GUI.Guru
{
    partial class Mapel
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
            this.listviewMapel = new MetroFramework.Controls.MetroListView();
            this.SuspendLayout();
            // 
            // listviewMapel
            // 
            this.listviewMapel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listviewMapel.FullRowSelect = true;
            this.listviewMapel.Location = new System.Drawing.Point(24, 85);
            this.listviewMapel.Name = "listviewMapel";
            this.listviewMapel.OwnerDraw = true;
            this.listviewMapel.Size = new System.Drawing.Size(741, 321);
            this.listviewMapel.TabIndex = 0;
            this.listviewMapel.UseCompatibleStateImageBehavior = false;
            this.listviewMapel.UseSelectable = true;
            this.listviewMapel.View = System.Windows.Forms.View.Details;
            this.listviewMapel.SelectedIndexChanged += new System.EventHandler(this.listviewMapel_SelectedIndexChanged);
            // 
            // Mapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 437);
            this.Controls.Add(this.listviewMapel);
            this.Name = "Mapel";
            this.Text = "Mata Pelajaran";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listviewMapel;
    }
}