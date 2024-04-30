namespace Presentacion
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
            pDerechoAcerca = new Panel();
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
            // frmAcerca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1161, 515);
            Controls.Add(pDerechoAcerca);
            Name = "frmAcerca";
            Text = "frmAcerca";
            ResumeLayout(false);
        }

        #endregion

        private Panel pDerechoAcerca;
    }
}