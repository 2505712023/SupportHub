namespace Presentacion.CustomMessageBoxes
{
    partial class AdvertenciaMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvertenciaMessageBox));
            pSuperiorAddEntrega = new Panel();
            iconButtonX = new FontAwesome.Sharp.IconButton();
            lblTextoTab = new Label();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            ibtnNo = new FontAwesome.Sharp.IconButton();
            iconPrincipal = new FontAwesome.Sharp.IconPictureBox();
            tboxDescripcionError = new RichTextBox();
            ibtnSi = new FontAwesome.Sharp.IconButton();
            pSuperiorAddEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPrincipal).BeginInit();
            SuspendLayout();
            // 
            // pSuperiorAddEntrega
            // 
            pSuperiorAddEntrega.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddEntrega.Controls.Add(iconButtonX);
            pSuperiorAddEntrega.Controls.Add(lblTextoTab);
            pSuperiorAddEntrega.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorAddEntrega.Dock = DockStyle.Top;
            pSuperiorAddEntrega.Location = new Point(0, 0);
            pSuperiorAddEntrega.Name = "pSuperiorAddEntrega";
            pSuperiorAddEntrega.Size = new Size(734, 50);
            pSuperiorAddEntrega.TabIndex = 3;
            // 
            // iconButtonX
            // 
            iconButtonX.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButtonX.FlatAppearance.BorderSize = 0;
            iconButtonX.FlatStyle = FlatStyle.Flat;
            iconButtonX.ForeColor = SystemColors.ControlLightLight;
            iconButtonX.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButtonX.IconColor = SystemColors.Window;
            iconButtonX.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButtonX.IconSize = 20;
            iconButtonX.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonX.Location = new Point(694, 11);
            iconButtonX.Name = "iconButtonX";
            iconButtonX.Size = new Size(28, 24);
            iconButtonX.TabIndex = 19;
            iconButtonX.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonX.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonX.UseVisualStyleBackColor = true;
            iconButtonX.Click += iconButtonX_Click;
            // 
            // lblTextoTab
            // 
            lblTextoTab.AutoSize = true;
            lblTextoTab.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTextoTab.ForeColor = Color.White;
            lblTextoTab.Location = new Point(15, 11);
            lblTextoTab.Name = "lblTextoTab";
            lblTextoTab.Size = new Size(245, 28);
            lblTextoTab.TabIndex = 18;
            lblTextoTab.Text = "Encabezado Advertencia";
            // 
            // btnCerrarAddEmpleado
            // 
            btnCerrarAddEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarAddEmpleado.FlatAppearance.BorderSize = 0;
            btnCerrarAddEmpleado.FlatStyle = FlatStyle.Flat;
            btnCerrarAddEmpleado.ForeColor = SystemColors.ControlLightLight;
            btnCerrarAddEmpleado.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarAddEmpleado.IconColor = SystemColors.Window;
            btnCerrarAddEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarAddEmpleado.IconSize = 20;
            btnCerrarAddEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.Location = new Point(936, 12);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(28, 24);
            btnCerrarAddEmpleado.TabIndex = 17;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            // 
            // ibtnNo
            // 
            ibtnNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ibtnNo.BackColor = Color.FromArgb(5, 23, 59);
            ibtnNo.FlatAppearance.BorderSize = 0;
            ibtnNo.FlatStyle = FlatStyle.Flat;
            ibtnNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnNo.ForeColor = Color.White;
            ibtnNo.IconChar = FontAwesome.Sharp.IconChar.Redo;
            ibtnNo.IconColor = Color.White;
            ibtnNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnNo.IconSize = 20;
            ibtnNo.Location = new Point(665, 156);
            ibtnNo.Name = "ibtnNo";
            ibtnNo.Size = new Size(57, 32);
            ibtnNo.TabIndex = 1;
            ibtnNo.Text = "No";
            ibtnNo.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnNo.UseVisualStyleBackColor = false;
            ibtnNo.Click += ibtnNo_Click;
            // 
            // iconPrincipal
            // 
            iconPrincipal.BackColor = Color.FromArgb(98, 122, 144);
            iconPrincipal.ForeColor = Color.Yellow;
            iconPrincipal.IconChar = FontAwesome.Sharp.IconChar.TriangleExclamation;
            iconPrincipal.IconColor = Color.Yellow;
            iconPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPrincipal.IconSize = 93;
            iconPrincipal.InitialImage = (Image)resources.GetObject("iconPrincipal.InitialImage");
            iconPrincipal.Location = new Point(24, 77);
            iconPrincipal.Name = "iconPrincipal";
            iconPrincipal.Size = new Size(93, 93);
            iconPrincipal.TabIndex = 18;
            iconPrincipal.TabStop = false;
            // 
            // tboxDescripcionError
            // 
            tboxDescripcionError.BackColor = Color.FromArgb(98, 122, 144);
            tboxDescripcionError.BorderStyle = BorderStyle.None;
            tboxDescripcionError.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            tboxDescripcionError.Location = new Point(128, 89);
            tboxDescripcionError.Name = "tboxDescripcionError";
            tboxDescripcionError.Size = new Size(537, 60);
            tboxDescripcionError.TabIndex = 19;
            tboxDescripcionError.Text = "Descripción de la advertencia";
            // 
            // ibtnSi
            // 
            ibtnSi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ibtnSi.BackColor = Color.FromArgb(5, 23, 59);
            ibtnSi.FlatAppearance.BorderSize = 0;
            ibtnSi.FlatStyle = FlatStyle.Flat;
            ibtnSi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnSi.ForeColor = Color.White;
            ibtnSi.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            ibtnSi.IconColor = Color.White;
            ibtnSi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSi.IconSize = 20;
            ibtnSi.Location = new Point(602, 156);
            ibtnSi.Name = "ibtnSi";
            ibtnSi.Size = new Size(57, 32);
            ibtnSi.TabIndex = 0;
            ibtnSi.Text = "Si";
            ibtnSi.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnSi.UseVisualStyleBackColor = false;
            ibtnSi.Click += ibtnSi_Click;
            // 
            // AdvertenciaMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(734, 200);
            Controls.Add(ibtnSi);
            Controls.Add(tboxDescripcionError);
            Controls.Add(iconPrincipal);
            Controls.Add(ibtnNo);
            Controls.Add(pSuperiorAddEntrega);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdvertenciaMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            Load += AdvertenciaMessageBox_Load;
            pSuperiorAddEntrega.ResumeLayout(false);
            pSuperiorAddEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperiorAddEntrega;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private FontAwesome.Sharp.IconButton ibtnNo;
        private FontAwesome.Sharp.IconPictureBox iconPrincipal;
        private Label lblTextoTab;
        private FontAwesome.Sharp.IconButton iconButtonX;
        private RichTextBox tboxDescripcionError;
        private FontAwesome.Sharp.IconButton ibtnSi;
    }
}