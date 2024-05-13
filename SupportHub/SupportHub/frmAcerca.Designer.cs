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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcerca));
            rtbAcerca = new RichTextBox();
            SuspendLayout();
            // 
            // rtbAcerca
            // 
            rtbAcerca.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbAcerca.Enabled = false;
            rtbAcerca.Location = new Point(21, 49);
            rtbAcerca.Name = "rtbAcerca";
            rtbAcerca.Size = new Size(1128, 454);
            rtbAcerca.TabIndex = 8;
            rtbAcerca.Text = resources.GetString("rtbAcerca.Text");
            rtbAcerca.TextChanged += rtbAcerca_TextChanged;
            // 
            // frmAcerca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1161, 515);
            Controls.Add(rtbAcerca);
            Name = "frmAcerca";
            Text = "frmAcerca";
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rtbAcerca;
    }
}