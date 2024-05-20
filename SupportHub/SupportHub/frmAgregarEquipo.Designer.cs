namespace Presentacion
{
    partial class frmAgregarEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarEquipo));
            gbAddEequipo = new GroupBox();
            comboBproveedor = new ComboBox();
            maskprecioEquipo = new MaskedTextBox();
            tboxcantidadEquipo = new TextBox();
            tboxmodeloEquipo = new TextBox();
            tboxTipoEquipo = new TextBox();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            tboxmarcaEquipo = new TextBox();
            lblmodeloEquipo = new Label();
            lblErrorCantidad = new Label();
            lblpro = new Label();
            lblCantidadDisponible = new Label();
            lblEquipo = new Label();
            labmarcaEquipo = new Label();
            rtxtDescripcion = new RichTextBox();
            lbldescripcionEquipo = new Label();
            ibtnCancelarEntrega = new FontAwesome.Sharp.IconButton();
            ibtnGuardarEntrega = new FontAwesome.Sharp.IconButton();
            btnCancelaEmpleado = new FontAwesome.Sharp.IconButton();
            btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            lblTipoDeEquipo = new Label();
            pSuperiorAddEntrega = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pboxLogo = new PictureBox();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            gbAddEequipo.SuspendLayout();
            pSuperiorAddEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            SuspendLayout();
            // 
            // gbAddEequipo
            // 
            gbAddEequipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddEequipo.Controls.Add(comboBproveedor);
            gbAddEequipo.Controls.Add(maskprecioEquipo);
            gbAddEequipo.Controls.Add(tboxcantidadEquipo);
            gbAddEequipo.Controls.Add(tboxmodeloEquipo);
            gbAddEequipo.Controls.Add(tboxTipoEquipo);
            gbAddEequipo.Controls.Add(BtnCancelar);
            gbAddEequipo.Controls.Add(BtnGuardar);
            gbAddEequipo.Controls.Add(tboxmarcaEquipo);
            gbAddEequipo.Controls.Add(lblmodeloEquipo);
            gbAddEequipo.Controls.Add(lblErrorCantidad);
            gbAddEequipo.Controls.Add(lblpro);
            gbAddEequipo.Controls.Add(lblCantidadDisponible);
            gbAddEequipo.Controls.Add(lblEquipo);
            gbAddEequipo.Controls.Add(labmarcaEquipo);
            gbAddEequipo.Controls.Add(rtxtDescripcion);
            gbAddEequipo.Controls.Add(lbldescripcionEquipo);
            gbAddEequipo.Controls.Add(ibtnCancelarEntrega);
            gbAddEequipo.Controls.Add(ibtnGuardarEntrega);
            gbAddEequipo.Controls.Add(btnCancelaEmpleado);
            gbAddEequipo.Controls.Add(btnGuardarEmpleado);
            gbAddEequipo.Controls.Add(lblTipoDeEquipo);
            gbAddEequipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddEequipo.Location = new Point(12, 72);
            gbAddEequipo.Name = "gbAddEequipo";
            gbAddEequipo.Size = new Size(710, 388);
            gbAddEequipo.TabIndex = 4;
            gbAddEequipo.TabStop = false;
            gbAddEequipo.Text = "AGREGAR EQUIPO";
            // 
            // comboBproveedor
            // 
            comboBproveedor.FormattingEnabled = true;
            comboBproveedor.Location = new Point(226, 253);
            comboBproveedor.Name = "comboBproveedor";
            comboBproveedor.Size = new Size(209, 29);
            comboBproveedor.TabIndex = 39;
            // 
            // maskprecioEquipo
            // 
            maskprecioEquipo.Location = new Point(226, 218);
            maskprecioEquipo.Mask = "$######.##";
            maskprecioEquipo.Name = "maskprecioEquipo";
            maskprecioEquipo.Size = new Size(104, 29);
            maskprecioEquipo.TabIndex = 38;
            maskprecioEquipo.TextAlign = HorizontalAlignment.Right;
            // 
            // tboxcantidadEquipo
            // 
            tboxcantidadEquipo.Font = new Font("Segoe UI", 12F);
            tboxcantidadEquipo.ForeColor = Color.Black;
            tboxcantidadEquipo.Location = new Point(226, 178);
            tboxcantidadEquipo.Name = "tboxcantidadEquipo";
            tboxcantidadEquipo.Size = new Size(209, 29);
            tboxcantidadEquipo.TabIndex = 37;
            // 
            // tboxmodeloEquipo
            // 
            tboxmodeloEquipo.Font = new Font("Segoe UI", 12F);
            tboxmodeloEquipo.ForeColor = Color.Black;
            tboxmodeloEquipo.Location = new Point(226, 133);
            tboxmodeloEquipo.Name = "tboxmodeloEquipo";
            tboxmodeloEquipo.Size = new Size(209, 29);
            tboxmodeloEquipo.TabIndex = 36;
            // 
            // tboxTipoEquipo
            // 
            tboxTipoEquipo.Font = new Font("Segoe UI", 12F);
            tboxTipoEquipo.ForeColor = Color.Black;
            tboxTipoEquipo.Location = new Point(226, 43);
            tboxTipoEquipo.Name = "tboxTipoEquipo";
            tboxTipoEquipo.Size = new Size(209, 29);
            tboxTipoEquipo.TabIndex = 35;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCancelar.BackColor = Color.White;
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = Color.FromArgb(5, 23, 59);
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            BtnCancelar.IconColor = Color.FromArgb(5, 23, 59);
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 20;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(585, 102);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(100, 40);
            BtnCancelar.TabIndex = 34;
            BtnCancelar.Text = "CANCELAR";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnGuardar.BackColor = Color.FromArgb(5, 23, 59);
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.White;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 20;
            BtnGuardar.Location = new Point(585, 56);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(100, 40);
            BtnGuardar.TabIndex = 33;
            BtnGuardar.Text = "GUARDAR";
            BtnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // tboxmarcaEquipo
            // 
            tboxmarcaEquipo.Font = new Font("Segoe UI", 12F);
            tboxmarcaEquipo.ForeColor = Color.Black;
            tboxmarcaEquipo.Location = new Point(226, 87);
            tboxmarcaEquipo.Name = "tboxmarcaEquipo";
            tboxmarcaEquipo.Size = new Size(209, 29);
            tboxmarcaEquipo.TabIndex = 32;
            // 
            // lblmodeloEquipo
            // 
            lblmodeloEquipo.AutoSize = true;
            lblmodeloEquipo.Location = new Point(62, 136);
            lblmodeloEquipo.Name = "lblmodeloEquipo";
            lblmodeloEquipo.Size = new Size(159, 21);
            lblmodeloEquipo.TabIndex = 31;
            lblmodeloEquipo.Text = "Modelo del Equipo:";
            // 
            // lblErrorCantidad
            // 
            lblErrorCantidad.AutoSize = true;
            lblErrorCantidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblErrorCantidad.ForeColor = Color.Red;
            lblErrorCantidad.Location = new Point(330, 259);
            lblErrorCantidad.Name = "lblErrorCantidad";
            lblErrorCantidad.Size = new Size(0, 19);
            lblErrorCantidad.TabIndex = 30;
            // 
            // lblpro
            // 
            lblpro.AutoSize = true;
            lblpro.Location = new Point(122, 259);
            lblpro.Name = "lblpro";
            lblpro.Size = new Size(94, 21);
            lblpro.TabIndex = 28;
            lblpro.Text = "Proveedor:";
            // 
            // lblCantidadDisponible
            // 
            lblCantidadDisponible.AutoSize = true;
            lblCantidadDisponible.Location = new Point(154, 226);
            lblCantidadDisponible.Name = "lblCantidadDisponible";
            lblCantidadDisponible.Size = new Size(62, 21);
            lblCantidadDisponible.TabIndex = 26;
            lblCantidadDisponible.Text = "Precio:";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(45, 178);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(171, 21);
            lblEquipo.TabIndex = 24;
            lblEquipo.Text = "Cantidad de Equipos:";
            // 
            // labmarcaEquipo
            // 
            labmarcaEquipo.AutoSize = true;
            labmarcaEquipo.Location = new Point(69, 90);
            labmarcaEquipo.Name = "labmarcaEquipo";
            labmarcaEquipo.Size = new Size(147, 21);
            labmarcaEquipo.TabIndex = 22;
            labmarcaEquipo.Text = "Marca del Equipo:";
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Font = new Font("Segoe UI", 12F);
            rtxtDescripcion.Location = new Point(226, 288);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(325, 62);
            rtxtDescripcion.TabIndex = 21;
            rtxtDescripcion.Text = "";
            // 
            // lbldescripcionEquipo
            // 
            lbldescripcionEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbldescripcionEquipo.AutoSize = true;
            lbldescripcionEquipo.Location = new Point(116, 291);
            lbldescripcionEquipo.Name = "lbldescripcionEquipo";
            lbldescripcionEquipo.Size = new Size(104, 21);
            lbldescripcionEquipo.TabIndex = 19;
            lbldescripcionEquipo.Text = "Descripción:";
            // 
            // ibtnCancelarEntrega
            // 
            ibtnCancelarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ibtnCancelarEntrega.BackColor = Color.White;
            ibtnCancelarEntrega.FlatAppearance.BorderSize = 0;
            ibtnCancelarEntrega.FlatStyle = FlatStyle.Flat;
            ibtnCancelarEntrega.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnCancelarEntrega.ForeColor = Color.FromArgb(5, 23, 59);
            ibtnCancelarEntrega.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            ibtnCancelarEntrega.IconColor = Color.FromArgb(5, 23, 59);
            ibtnCancelarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCancelarEntrega.IconSize = 20;
            ibtnCancelarEntrega.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnCancelarEntrega.Location = new Point(1095, 102);
            ibtnCancelarEntrega.Name = "ibtnCancelarEntrega";
            ibtnCancelarEntrega.Size = new Size(100, 40);
            ibtnCancelarEntrega.TabIndex = 18;
            ibtnCancelarEntrega.Text = "CANCELAR";
            ibtnCancelarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnCancelarEntrega.UseVisualStyleBackColor = false;
            // 
            // ibtnGuardarEntrega
            // 
            ibtnGuardarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ibtnGuardarEntrega.BackColor = Color.FromArgb(5, 23, 59);
            ibtnGuardarEntrega.FlatAppearance.BorderSize = 0;
            ibtnGuardarEntrega.FlatStyle = FlatStyle.Flat;
            ibtnGuardarEntrega.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ibtnGuardarEntrega.ForeColor = Color.White;
            ibtnGuardarEntrega.IconChar = FontAwesome.Sharp.IconChar.Save;
            ibtnGuardarEntrega.IconColor = Color.White;
            ibtnGuardarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnGuardarEntrega.IconSize = 20;
            ibtnGuardarEntrega.Location = new Point(1095, 56);
            ibtnGuardarEntrega.Name = "ibtnGuardarEntrega";
            ibtnGuardarEntrega.Size = new Size(100, 40);
            ibtnGuardarEntrega.TabIndex = 17;
            ibtnGuardarEntrega.Text = "GUARDAR";
            ibtnGuardarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnGuardarEntrega.UseVisualStyleBackColor = false;
            // 
            // btnCancelaEmpleado
            // 
            btnCancelaEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelaEmpleado.BackColor = Color.White;
            btnCancelaEmpleado.FlatAppearance.BorderSize = 0;
            btnCancelaEmpleado.FlatStyle = FlatStyle.Flat;
            btnCancelaEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelaEmpleado.ForeColor = Color.FromArgb(5, 23, 59);
            btnCancelaEmpleado.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnCancelaEmpleado.IconColor = Color.FromArgb(5, 23, 59);
            btnCancelaEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelaEmpleado.IconSize = 20;
            btnCancelaEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelaEmpleado.Location = new Point(1732, 238);
            btnCancelaEmpleado.Name = "btnCancelaEmpleado";
            btnCancelaEmpleado.Size = new Size(115, 38);
            btnCancelaEmpleado.TabIndex = 13;
            btnCancelaEmpleado.Text = "CANCELAR";
            btnCancelaEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelaEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelaEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnGuardarEmpleado
            // 
            btnGuardarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardarEmpleado.FlatAppearance.BorderSize = 0;
            btnGuardarEmpleado.FlatStyle = FlatStyle.Flat;
            btnGuardarEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarEmpleado.ForeColor = Color.White;
            btnGuardarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarEmpleado.IconColor = Color.White;
            btnGuardarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarEmpleado.IconSize = 20;
            btnGuardarEmpleado.Location = new Point(1600, 238);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(115, 38);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
            // 
            // lblTipoDeEquipo
            // 
            lblTipoDeEquipo.AutoSize = true;
            lblTipoDeEquipo.Location = new Point(87, 46);
            lblTipoDeEquipo.Name = "lblTipoDeEquipo";
            lblTipoDeEquipo.Size = new Size(129, 21);
            lblTipoDeEquipo.TabIndex = 4;
            lblTipoDeEquipo.Text = "Tipo de Equipo:";
            // 
            // pSuperiorAddEntrega
            // 
            pSuperiorAddEntrega.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddEntrega.Controls.Add(iconButton1);
            pSuperiorAddEntrega.Controls.Add(pboxLogo);
            pSuperiorAddEntrega.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorAddEntrega.Dock = DockStyle.Top;
            pSuperiorAddEntrega.Location = new Point(0, 0);
            pSuperiorAddEntrega.Name = "pSuperiorAddEntrega";
            pSuperiorAddEntrega.Size = new Size(734, 60);
            pSuperiorAddEntrega.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ControlLightLight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = SystemColors.Window;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(694, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(28, 24);
            iconButton1.TabIndex = 18;
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // pboxLogo
            // 
            pboxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pboxLogo.Image = (Image)resources.GetObject("pboxLogo.Image");
            pboxLogo.Location = new Point(20, 0);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new Size(184, 60);
            pboxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pboxLogo.TabIndex = 17;
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
            btnCerrarAddEmpleado.Location = new Point(1228, 12);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(28, 24);
            btnCerrarAddEmpleado.TabIndex = 16;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            // 
            // frmAgregarEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(734, 466);
            Controls.Add(gbAddEequipo);
            Controls.Add(pSuperiorAddEntrega);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarEquipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarEquipo";
            Load += frmAgregarEquipo_Load;
            gbAddEequipo.ResumeLayout(false);
            gbAddEequipo.PerformLayout();
            pSuperiorAddEntrega.ResumeLayout(false);
            pSuperiorAddEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAddEequipo;
        private TextBox tboxmarcaEquipo;
        private Label lblmodeloEquipo;
        private Label lblErrorCantidad;
        private Label lblpro;
        private Label lblCantidadDisponible;
        private Label lblEquipo;
        private Label labmarcaEquipo;
        private RichTextBox rtxtDescripcion;
        private Label lbldescripcionEquipo;
        private FontAwesome.Sharp.IconButton ibtnCancelarEntrega;
        private FontAwesome.Sharp.IconButton ibtnGuardarEntrega;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private Label lblTipoDeEquipo;
        private Panel pSuperiorAddEntrega;
        private PictureBox pboxLogo;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private TextBox tboxTipoEquipo;
        private TextBox tboxmodeloEquipo;
        private TextBox tboxcantidadEquipo;
        private MaskedTextBox maskprecioEquipo;
        private ComboBox comboBproveedor;
    }
}