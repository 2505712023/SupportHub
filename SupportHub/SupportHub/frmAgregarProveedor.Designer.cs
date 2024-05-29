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
            gbAddProveedor = new GroupBox();
            label2 = new Label();
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pboxLogo = new PictureBox();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            gbAddProveedor.SuspendLayout();
            pSuperiorAddProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            SuspendLayout();
            // 
            // gbAddProveedor
            // 
            gbAddProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddProveedor.Controls.Add(label2);
            gbAddProveedor.Controls.Add(label1);
            gbAddProveedor.Controls.Add(lblCod);
            gbAddProveedor.Controls.Add(txtDireccion);
            gbAddProveedor.Controls.Add(txtTelefono);
            gbAddProveedor.Controls.Add(btnCancela);
            gbAddProveedor.Controls.Add(btnGuardarProveedor);
            gbAddProveedor.Controls.Add(txtCodProveedor);
            gbAddProveedor.Controls.Add(txtNombre);
            gbAddProveedor.Controls.Add(lblNombre);
            gbAddProveedor.Controls.Add(txtId);
            gbAddProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddProveedor.Location = new Point(12, 66);
            gbAddProveedor.Name = "gbAddProveedor";
            gbAddProveedor.Size = new Size(561, 276);
            gbAddProveedor.TabIndex = 2;
            gbAddProveedor.TabStop = false;
            gbAddProveedor.Text = "AGREGAR  PROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 29);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 18;
            label2.Text = "Teléfono:";
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
            lblCod.Location = new Point(26, 29);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(153, 21);
            lblCod.TabIndex = 16;
            lblCod.Text = "Código Proveedor:";
            // 
            // txtDireccion
            // 
            txtDireccion.Cursor = Cursors.IBeam;
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccion.Location = new Point(26, 172);
            txtDireccion.MaxLength = 100;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(266, 29);
            txtDireccion.TabIndex = 8;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Cursor = Cursors.IBeam;
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(337, 53);
            txtTelefono.Mask = "0000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(197, 29);
            txtTelefono.TabIndex = 12;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // btnCancela
            // 
            btnCancela.BackColor = Color.White;
            btnCancela.Cursor = Cursors.Hand;
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
            btnCancela.TabIndex = 16;
            btnCancela.Text = "CANCELAR";
            btnCancela.TextAlign = ContentAlignment.MiddleLeft;
            btnCancela.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancela.UseVisualStyleBackColor = false;
            btnCancela.Click += btnCancela_Click;
            // 
            // btnGuardarProveedor
            // 
            btnGuardarProveedor.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardarProveedor.Cursor = Cursors.Hand;
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
            btnGuardarProveedor.TabIndex = 15;
            btnGuardarProveedor.Text = "GUARDAR";
            btnGuardarProveedor.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarProveedor.UseVisualStyleBackColor = false;
            btnGuardarProveedor.Click += btnGuardarProveedor_Click;
            btnGuardarProveedor.Enter += btnGuardarProveedor_Click;
            // 
            // txtCodProveedor
            // 
            txtCodProveedor.Cursor = Cursors.IBeam;
            txtCodProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodProveedor.Location = new Point(26, 53);
            txtCodProveedor.MaxLength = 8;
            txtCodProveedor.Name = "txtCodProveedor";
            txtCodProveedor.Size = new Size(266, 29);
            txtCodProveedor.TabIndex = 6;
            txtCodProveedor.KeyPress += txtCodProveedor_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(26, 112);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(266, 29);
            txtNombre.TabIndex = 7;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Cursor = Cursors.IBeam;
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(337, 112);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(197, 29);
            txtId.TabIndex = 14;
            txtId.Visible = false;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // pSuperiorAddProveedor
            // 
            pSuperiorAddProveedor.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddProveedor.Controls.Add(iconButton1);
            pSuperiorAddProveedor.Controls.Add(pboxLogo);
            pSuperiorAddProveedor.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorAddProveedor.Dock = DockStyle.Top;
            pSuperiorAddProveedor.Location = new Point(0, 0);
            pSuperiorAddProveedor.Name = "pSuperiorAddProveedor";
            pSuperiorAddProveedor.Size = new Size(585, 60);
            pSuperiorAddProveedor.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = SystemColors.Window;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(545, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(28, 24);
            iconButton1.TabIndex = 19;
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += btnCancela_Click;
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
            Controls.Add(gbAddProveedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarProveedor";
            gbAddProveedor.ResumeLayout(false);
            gbAddProveedor.PerformLayout();
            pSuperiorAddProveedor.ResumeLayout(false);
            pSuperiorAddProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        public GroupBox gbAddProveedor;
    }
}