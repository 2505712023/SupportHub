namespace Presentacion.CustomMessageBoxes
{
    partial class ErrorMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitoMessageBox));
            pSuperiorAddEntrega = new Panel();
            iconButtonX = new FontAwesome.Sharp.IconButton();
            lblTextoTab = new Label();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            ibtnOK = new FontAwesome.Sharp.IconButton();
            iconPrincipal = new FontAwesome.Sharp.IconPictureBox();
            tboxDescripcionError = new RichTextBox();
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
            lblTextoTab.Size = new Size(177, 28);
            lblTextoTab.TabIndex = 18;
            lblTextoTab.Text = "Encabezado Error";
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
            // ibtnOK
            // 
            ibtnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ibtnOK.BackColor = Color.FromArgb(5, 23, 59);
            ibtnOK.FlatAppearance.BorderSize = 0;
            ibtnOK.FlatStyle = FlatStyle.Flat;
            ibtnOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnOK.ForeColor = Color.White;
            ibtnOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            ibtnOK.IconColor = Color.White;
            ibtnOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnOK.IconSize = 20;
            ibtnOK.Location = new Point(665, 156);
            ibtnOK.Name = "ibtnOK";
            ibtnOK.Size = new Size(57, 32);
            ibtnOK.TabIndex = 18;
            ibtnOK.Text = "OK";
            ibtnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnOK.UseVisualStyleBackColor = false;
            ibtnOK.Click += ibtnOK_Click;
            // 
            // iconPrincipal
            // 
            iconPrincipal.BackColor = Color.FromArgb(98, 122, 144);
            iconPrincipal.ForeColor = Color.Red;
            iconPrincipal.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconPrincipal.IconColor = Color.Red;
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
            tboxDescripcionError.Text = "Descripción del error";
            // 
            // ErrorMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(734, 200);
            Controls.Add(tboxDescripcionError);
            Controls.Add(iconPrincipal);
            Controls.Add(ibtnOK);
            Controls.Add(pSuperiorAddEntrega);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ErrorMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            pSuperiorAddEntrega.ResumeLayout(false);
            pSuperiorAddEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperiorAddEntrega;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private FontAwesome.Sharp.IconButton ibtnOK;
        private FontAwesome.Sharp.IconPictureBox iconPrincipal;
        private Label lblTextoTab;
        private FontAwesome.Sharp.IconButton iconButtonX;
        private RichTextBox tboxDescripcionError;
    }
}