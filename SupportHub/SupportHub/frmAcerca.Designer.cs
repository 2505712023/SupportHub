﻿namespace Presentacion
{
    partial class frmAcerca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcerca));
            pDerechoAcerca = new Panel();
            rtbAcerca = new RichTextBox();
            SuspendLayout();
            // 
            // pDerechoAcerca
            // 
            pDerechoAcerca.Dock = DockStyle.Right;
            pDerechoAcerca.Location = new Point(1062, 0);
            pDerechoAcerca.Name = "pDerechoAcerca";
            pDerechoAcerca.Size = new Size(99, 515);
            pDerechoAcerca.TabIndex = 7;
            // 
            // rtbAcerca
            // 
            rtbAcerca.Anchor = AnchorStyles.None;
            rtbAcerca.Location = new Point(3, 0);
            rtbAcerca.Name = "rtbAcerca";
            rtbAcerca.Size = new Size(1053, 515);
            rtbAcerca.TabIndex = 8;
            rtbAcerca.Text = resources.GetString("rtbAcerca.Text");
            // 
            // frmAcerca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1161, 515);
            Controls.Add(rtbAcerca);
            Controls.Add(pDerechoAcerca);
            Name = "frmAcerca";
            Text = "frmAcerca";
            ResumeLayout(false);
        }

        #endregion

        private Panel pDerechoAcerca;
        private RichTextBox rtbAcerca;
    }
}