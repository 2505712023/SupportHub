namespace Presentacion
{
    partial class frmCarga
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            pCargaLateral = new Panel();
            imgFondoCarga = new PictureBox();
            imgCarga = new PictureBox();
            pCargaSuperior = new Panel();
            lblBienve = new Label();
            cpbCarga = new CircularProgressBar_NET5.CircularProgressBar();
            TimerCarga1 = new System.Windows.Forms.Timer(components);
            TimerCarga2 = new System.Windows.Forms.Timer(components);
            lblNombreApellido = new Label();
            pCargaLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFondoCarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCarga).BeginInit();
            SuspendLayout();
            // 
            // pCargaLateral
            // 
            pCargaLateral.BackColor = Color.FromArgb(5, 23, 59);
            pCargaLateral.Controls.Add(imgFondoCarga);
            pCargaLateral.Controls.Add(imgCarga);
            pCargaLateral.Dock = DockStyle.Left;
            pCargaLateral.Location = new Point(0, 0);
            pCargaLateral.Name = "pCargaLateral";
            pCargaLateral.Size = new Size(245, 334);
            pCargaLateral.TabIndex = 0;
            // 
            // imgFondoCarga
            // 
            imgFondoCarga.Image = (Image)resources.GetObject("imgFondoCarga.Image");
            imgFondoCarga.Location = new Point(0, 83);
            imgFondoCarga.Name = "imgFondoCarga";
            imgFondoCarga.Size = new Size(256, 251);
            imgFondoCarga.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFondoCarga.TabIndex = 2;
            imgFondoCarga.TabStop = false;
            // 
            // imgCarga
            // 
            imgCarga.Image = (Image)resources.GetObject("imgCarga.Image");
            imgCarga.Location = new Point(3, 3);
            imgCarga.Name = "imgCarga";
            imgCarga.Size = new Size(242, 81);
            imgCarga.SizeMode = PictureBoxSizeMode.CenterImage;
            imgCarga.TabIndex = 0;
            imgCarga.TabStop = false;
            // 
            // pCargaSuperior
            // 
            pCargaSuperior.BackColor = Color.FromArgb(5, 23, 59);
            pCargaSuperior.Dock = DockStyle.Top;
            pCargaSuperior.Location = new Point(245, 0);
            pCargaSuperior.Name = "pCargaSuperior";
            pCargaSuperior.Size = new Size(617, 84);
            pCargaSuperior.TabIndex = 1;
            // 
            // lblBienve
            // 
            lblBienve.AutoSize = true;
            lblBienve.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lblBienve.ForeColor = Color.FromArgb(31, 35, 40);
            lblBienve.Location = new Point(271, 111);
            lblBienve.Name = "lblBienve";
            lblBienve.Size = new Size(427, 86);
            lblBienve.TabIndex = 2;
            lblBienve.Text = "BIENVENIDO";
            // 
            // cpbCarga
            // 
            cpbCarga.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            cpbCarga.AnimationSpeed = 500;
            cpbCarga.BackColor = Color.Transparent;
            cpbCarga.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            cpbCarga.ForeColor = Color.FromArgb(64, 64, 64);
            cpbCarga.InnerColor = Color.FromArgb(224, 224, 224);
            cpbCarga.InnerMargin = 2;
            cpbCarga.InnerWidth = -1;
            cpbCarga.Location = new Point(426, 200);
            cpbCarga.MarqueeAnimationSpeed = 2000;
            cpbCarga.Name = "cpbCarga";
            cpbCarga.OuterColor = Color.FromArgb(148, 184, 216);
            cpbCarga.OuterMargin = -25;
            cpbCarga.OuterWidth = 26;
            cpbCarga.ProgressColor = Color.FromArgb(89, 134, 213);
            cpbCarga.ProgressWidth = 25;
            cpbCarga.SecondaryFont = new Font("Segoe UI", 26F, FontStyle.Bold);
            cpbCarga.Size = new Size(178, 127);
            cpbCarga.StartAngle = 270;
            cpbCarga.Style = ProgressBarStyle.Marquee;
            cpbCarga.SubscriptColor = Color.FromArgb(64, 64, 64);
            cpbCarga.SubscriptMargin = new Padding(10, -35, 0, 0);
            cpbCarga.SubscriptText = "%";
            cpbCarga.SuperscriptColor = Color.FromArgb(166, 166, 166);
            cpbCarga.SuperscriptMargin = new Padding(10, 35, 0, 0);
            cpbCarga.SuperscriptText = "";
            cpbCarga.TabIndex = 3;
            cpbCarga.Text = "0";
            cpbCarga.TextMargin = new Padding(8, 8, 0, 0);
            cpbCarga.Value = 68;
            // 
            // TimerCarga1
            // 
            TimerCarga1.Interval = 30;
            TimerCarga1.Tick += TimerCarga1_Tick;
            // 
            // TimerCarga2
            // 
            TimerCarga2.Interval = 30;
            TimerCarga2.Tick += TimerCarga2_Tick;
            // 
            // lblNombreApellido
            // 
            lblNombreApellido.AutoSize = true;
            lblNombreApellido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreApellido.Location = new Point(610, 182);
            lblNombreApellido.Name = "lblNombreApellido";
            lblNombreApellido.Size = new Size(81, 21);
            lblNombreApellido.TabIndex = 4;
            lblNombreApellido.Text = "USUARIO";
            // 
            // frmCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(862, 334);
            Controls.Add(lblNombreApellido);
            Controls.Add(cpbCarga);
            Controls.Add(lblBienve);
            Controls.Add(pCargaSuperior);
            Controls.Add(pCargaLateral);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCarga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarga";
            Load += frmCarga_Load;
            pCargaLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgFondoCarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCarga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pCargaLateral;
        private PictureBox imgCarga;
        private Panel pCargaSuperior;
        private Label lblBienve;
        private CircularProgressBar_NET5.CircularProgressBar cpbCarga;
        private System.Windows.Forms.Timer TimerCarga1;
        private System.Windows.Forms.Timer TimerCarga2;
        private PictureBox imgFondoCarga;
        private Label lblNombreApellido;
    }
}