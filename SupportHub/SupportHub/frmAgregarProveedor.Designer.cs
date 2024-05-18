namespace Presentacion
{
    partial class frmAgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProveedor));
            gbAddEmpleado = new GroupBox();
            label1 = new Label();
            lblCod = new Label();
            txtDireccion = new TextBox();
            txtTelefono = new MaskedTextBox();
            btnCancela = new FontAwesome.Sharp.IconButton();
            btnGuardarProveedor = new FontAwesome.Sharp.IconButton();
            txtCodProveedor = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtId = new TextBox();
            pSuperiorAddProveedor = new Panel();
            pboxLogo = new PictureBox();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            gbAddEmpleado.SuspendLayout();
            pSuperiorAddProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            SuspendLayout();
            // 
            // gbAddEmpleado
            // 
            gbAddEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddEmpleado.Controls.Add(label1);
            gbAddEmpleado.Controls.Add(lblCod);
            gbAddEmpleado.Controls.Add(txtDireccion);
            gbAddEmpleado.Controls.Add(txtTelefono);
            gbAddEmpleado.Controls.Add(btnCancela);
            gbAddEmpleado.Controls.Add(btnGuardarProveedor);
            gbAddEmpleado.Controls.Add(txtCodProveedor);
            gbAddEmpleado.Controls.Add(txtNombre);
            gbAddEmpleado.Controls.Add(lblNombre);
            gbAddEmpleado.Controls.Add(txtId);
            gbAddEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddEmpleado.Location = new Point(12, 66);
            gbAddEmpleado.Name = "gbAddEmpleado";
            gbAddEmpleado.Size = new Size(561, 276);
            gbAddEmpleado.TabIndex = 2;
            gbAddEmpleado.TabStop = false;
            gbAddEmpleado.Text = "AGREGAR EMPLEADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 148);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 17;
            label1.Text = "Dirección:";
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Location = new Point(26, 88);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(153, 21);
            lblCod.TabIndex = 16;
            lblCod.Text = "Codigo Proveedor:";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(26, 172);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(266, 29);
            txtDireccion.TabIndex = 15;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(337, 53);
            txtTelefono.Mask = "0000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(197, 29);
            txtTelefono.TabIndex = 8;
            // 
            // btnCancela
            // 
            btnCancela.BackColor = Color.White;
            btnCancela.FlatAppearance.BorderSize = 0;
            btnCancela.FlatStyle = FlatStyle.Flat;
            btnCancela.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancela.ForeColor = Color.FromArgb(5, 23, 59);
            btnCancela.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnCancela.IconColor = Color.FromArgb(5, 23, 59);
            btnCancela.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancela.IconSize = 20;
            btnCancela.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancela.Location = new Point(419, 216);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(115, 35);
            btnCancela.TabIndex = 13;
            btnCancela.Text = "CANCELAR";
            btnCancela.TextAlign = ContentAlignment.MiddleLeft;
            btnCancela.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancela.UseVisualStyleBackColor = false;
            btnCancela.Click += btnCancela_Click;
            // 
            // btnGuardarProveedor
            // 
            btnGuardarProveedor.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardarProveedor.FlatAppearance.BorderSize = 0;
            btnGuardarProveedor.FlatStyle = FlatStyle.Flat;
            btnGuardarProveedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarProveedor.ForeColor = Color.White;
            btnGuardarProveedor.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarProveedor.IconColor = Color.White;
            btnGuardarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarProveedor.IconSize = 20;
            btnGuardarProveedor.Location = new Point(419, 163);
            btnGuardarProveedor.Name = "btnGuardarProveedor";
            btnGuardarProveedor.Size = new Size(115, 38);
            btnGuardarProveedor.TabIndex = 12;
            btnGuardarProveedor.Text = "GUARDAR";
            btnGuardarProveedor.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarProveedor.UseVisualStyleBackColor = false;
            btnGuardarProveedor.Click += btnGuardarProveedor_Click;
            // 
            // txtCodProveedor
            // 
            txtCodProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodProveedor.Location = new Point(26, 112);
            txtCodProveedor.Name = "txtCodProveedor";
            txtCodProveedor.Size = new Size(266, 29);
            txtCodProveedor.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(26, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 29);
            txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(337, 112);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(197, 29);
            txtId.TabIndex = 14;
            txtId.Visible = false;
            // 
            // pSuperiorAddProveedor
            // 
            pSuperiorAddProveedor.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddProveedor.Controls.Add(pboxLogo);
            pSuperiorAddProveedor.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorAddProveedor.Dock = DockStyle.Top;
            pSuperiorAddProveedor.Location = new Point(0, 0);
            pSuperiorAddProveedor.Name = "pSuperiorAddProveedor";
            pSuperiorAddProveedor.Size = new Size(585, 60);
            pSuperiorAddProveedor.TabIndex = 3;
            // 
            // pboxLogo
            // 
            pboxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pboxLogo.Image = (Image)resources.GetObject("pboxLogo.Image");
            pboxLogo.Location = new Point(20, 0);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new Size(184, 60);
            pboxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pboxLogo.TabIndex = 16;
            pboxLogo.TabStop = false;
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
            btnCerrarAddEmpleado.Location = new Point(939, 3);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(28, 24);
            btnCerrarAddEmpleado.TabIndex = 15;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            // 
            // frmAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(585, 354);
            Controls.Add(pSuperiorAddProveedor);
            Controls.Add(gbAddEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarProveedor";
            gbAddEmpleado.ResumeLayout(false);
            gbAddEmpleado.PerformLayout();
            pSuperiorAddProveedor.ResumeLayout(false);
            pSuperiorAddProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAddEmpleado;
        public MaskedTextBox txtTelefono;
        private FontAwesome.Sharp.IconButton btnCancela;
        private FontAwesome.Sharp.IconButton btnGuardarProveedor;
        public TextBox txtCodProveedor;
        public TextBox txtNombre;
        private Label lblNombre;
        public TextBox txtId;
        private Label label1;
        private Label lblCod;
        public TextBox txtDireccion;
        private Panel pSuperiorAddProveedor;
        private PictureBox pboxLogo;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
    }
}