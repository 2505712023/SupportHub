namespace Presentacion
{
    partial class frmAgregarEntrega
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
            pSuperiorAddEntrega = new Panel();
            gbAddEntrega = new GroupBox();
            tboxCantidadEntrega = new MaskedTextBox();
            lblCantidadAEntregar = new Label();
            tboxCantidadDisponible = new TextBox();
            lblCantidadDisponible = new Label();
            cboxEquipo = new ComboBox();
            lblEquipo = new Label();
            cboxEmpleado = new ComboBox();
            labEmpleado = new Label();
            rtxtObservacionEntrega = new RichTextBox();
            lblObservacionEntrega = new Label();
            ibtnCancelarEntrega = new FontAwesome.Sharp.IconButton();
            ibtnGuardarEntrega = new FontAwesome.Sharp.IconButton();
            lblFechaEntrega = new Label();
            dtpickerFechaEntrega = new DateTimePicker();
            cboxTipoEntrega = new ComboBox();
            btnCancelaEmpleado = new FontAwesome.Sharp.IconButton();
            btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            lblTipoDeEntrega = new Label();
            gbAddEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // pSuperiorAddEntrega
            // 
            pSuperiorAddEntrega.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddEntrega.Dock = DockStyle.Top;
            pSuperiorAddEntrega.Location = new Point(0, 0);
            pSuperiorAddEntrega.Name = "pSuperiorAddEntrega";
            pSuperiorAddEntrega.Size = new Size(706, 60);
            pSuperiorAddEntrega.TabIndex = 1;
            // 
            // gbAddEntrega
            // 
            gbAddEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddEntrega.Controls.Add(tboxCantidadEntrega);
            gbAddEntrega.Controls.Add(lblCantidadAEntregar);
            gbAddEntrega.Controls.Add(tboxCantidadDisponible);
            gbAddEntrega.Controls.Add(lblCantidadDisponible);
            gbAddEntrega.Controls.Add(cboxEquipo);
            gbAddEntrega.Controls.Add(lblEquipo);
            gbAddEntrega.Controls.Add(cboxEmpleado);
            gbAddEntrega.Controls.Add(labEmpleado);
            gbAddEntrega.Controls.Add(rtxtObservacionEntrega);
            gbAddEntrega.Controls.Add(lblObservacionEntrega);
            gbAddEntrega.Controls.Add(ibtnCancelarEntrega);
            gbAddEntrega.Controls.Add(ibtnGuardarEntrega);
            gbAddEntrega.Controls.Add(lblFechaEntrega);
            gbAddEntrega.Controls.Add(dtpickerFechaEntrega);
            gbAddEntrega.Controls.Add(cboxTipoEntrega);
            gbAddEntrega.Controls.Add(btnCancelaEmpleado);
            gbAddEntrega.Controls.Add(btnGuardarEmpleado);
            gbAddEntrega.Controls.Add(lblTipoDeEntrega);
            gbAddEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddEntrega.Location = new Point(12, 66);
            gbAddEntrega.Name = "gbAddEntrega";
            gbAddEntrega.Size = new Size(682, 338);
            gbAddEntrega.TabIndex = 2;
            gbAddEntrega.TabStop = false;
            gbAddEntrega.Text = "AGREGAR ENTREGA";
            // 
            // tboxCantidadEntrega
            // 
            tboxCantidadEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tboxCantidadEntrega.Location = new Point(198, 216);
            tboxCantidadEntrega.Mask = "999999";
            tboxCantidadEntrega.Name = "tboxCantidadEntrega";
            tboxCantidadEntrega.RightToLeft = RightToLeft.Yes;
            tboxCantidadEntrega.Size = new Size(98, 29);
            tboxCantidadEntrega.TabIndex = 29;
            tboxCantidadEntrega.TextAlign = HorizontalAlignment.Center;
            tboxCantidadEntrega.ValidatingType = typeof(int);
            tboxCantidadEntrega.Leave += tboxCantidadEntrega_Leave;
            // 
            // lblCantidadAEntregar
            // 
            lblCantidadAEntregar.AutoSize = true;
            lblCantidadAEntregar.Location = new Point(22, 219);
            lblCantidadAEntregar.Name = "lblCantidadAEntregar";
            lblCantidadAEntregar.Size = new Size(166, 21);
            lblCantidadAEntregar.TabIndex = 28;
            lblCantidadAEntregar.Text = "Cantidad a Entregar:";
            // 
            // tboxCantidadDisponible
            // 
            tboxCantidadDisponible.Enabled = false;
            tboxCantidadDisponible.ForeColor = Color.Green;
            tboxCantidadDisponible.Location = new Point(198, 181);
            tboxCantidadDisponible.Name = "tboxCantidadDisponible";
            tboxCantidadDisponible.ReadOnly = true;
            tboxCantidadDisponible.Size = new Size(98, 29);
            tboxCantidadDisponible.TabIndex = 27;
            tboxCantidadDisponible.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCantidadDisponible
            // 
            lblCantidadDisponible.AutoSize = true;
            lblCantidadDisponible.Location = new Point(22, 184);
            lblCantidadDisponible.Name = "lblCantidadDisponible";
            lblCantidadDisponible.Size = new Size(170, 21);
            lblCantidadDisponible.TabIndex = 26;
            lblCantidadDisponible.Text = "Cantidad Disponible:";
            // 
            // cboxEquipo
            // 
            cboxEquipo.Font = new Font("Segoe UI", 12F);
            cboxEquipo.FormattingEnabled = true;
            cboxEquipo.Location = new Point(198, 146);
            cboxEquipo.Name = "cboxEquipo";
            cboxEquipo.Size = new Size(325, 29);
            cboxEquipo.TabIndex = 25;
            cboxEquipo.Leave += cboxEquipo_Leave;
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(124, 149);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(68, 21);
            lblEquipo.TabIndex = 24;
            lblEquipo.Text = "Equipo:";
            // 
            // cboxEmpleado
            // 
            cboxEmpleado.Font = new Font("Segoe UI", 12F);
            cboxEmpleado.FormattingEnabled = true;
            cboxEmpleado.Location = new Point(198, 111);
            cboxEmpleado.Name = "cboxEmpleado";
            cboxEmpleado.Size = new Size(325, 29);
            cboxEmpleado.TabIndex = 23;
            // 
            // labEmpleado
            // 
            labEmpleado.AutoSize = true;
            labEmpleado.Location = new Point(101, 114);
            labEmpleado.Name = "labEmpleado";
            labEmpleado.Size = new Size(91, 21);
            labEmpleado.TabIndex = 22;
            labEmpleado.Text = "Empleado:";
            // 
            // rtxtObservacionEntrega
            // 
            rtxtObservacionEntrega.Font = new Font("Segoe UI", 12F);
            rtxtObservacionEntrega.Location = new Point(198, 251);
            rtxtObservacionEntrega.Name = "rtxtObservacionEntrega";
            rtxtObservacionEntrega.Size = new Size(325, 62);
            rtxtObservacionEntrega.TabIndex = 21;
            rtxtObservacionEntrega.Text = "";
            // 
            // lblObservacionEntrega
            // 
            lblObservacionEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblObservacionEntrega.AutoSize = true;
            lblObservacionEntrega.Location = new Point(78, 251);
            lblObservacionEntrega.Name = "lblObservacionEntrega";
            lblObservacionEntrega.Size = new Size(110, 21);
            lblObservacionEntrega.TabIndex = 19;
            lblObservacionEntrega.Text = "Observación:";
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
            ibtnCancelarEntrega.Location = new Point(557, 102);
            ibtnCancelarEntrega.Name = "ibtnCancelarEntrega";
            ibtnCancelarEntrega.Size = new Size(100, 40);
            ibtnCancelarEntrega.TabIndex = 18;
            ibtnCancelarEntrega.Text = "CANCELAR";
            ibtnCancelarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnCancelarEntrega.UseVisualStyleBackColor = false;
            ibtnCancelarEntrega.Click += ibtnCancelarEntrega_Click;
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
            ibtnGuardarEntrega.Location = new Point(557, 56);
            ibtnGuardarEntrega.Name = "ibtnGuardarEntrega";
            ibtnGuardarEntrega.Size = new Size(100, 40);
            ibtnGuardarEntrega.TabIndex = 17;
            ibtnGuardarEntrega.Text = "GUARDAR";
            ibtnGuardarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnGuardarEntrega.UseVisualStyleBackColor = false;
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.AutoSize = true;
            lblFechaEntrega.Location = new Point(48, 76);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(144, 21);
            lblFechaEntrega.TabIndex = 16;
            lblFechaEntrega.Text = "Fecha de Entrega:";
            // 
            // dtpickerFechaEntrega
            // 
            dtpickerFechaEntrega.Cursor = Cursors.Hand;
            dtpickerFechaEntrega.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaEntrega.Font = new Font("Segoe UI", 12F);
            dtpickerFechaEntrega.Location = new Point(198, 76);
            dtpickerFechaEntrega.Name = "dtpickerFechaEntrega";
            dtpickerFechaEntrega.Size = new Size(188, 29);
            dtpickerFechaEntrega.TabIndex = 15;
            // 
            // cboxTipoEntrega
            // 
            cboxTipoEntrega.Font = new Font("Segoe UI", 12F);
            cboxTipoEntrega.FormattingEnabled = true;
            cboxTipoEntrega.Location = new Point(198, 41);
            cboxTipoEntrega.Name = "cboxTipoEntrega";
            cboxTipoEntrega.Size = new Size(188, 29);
            cboxTipoEntrega.TabIndex = 14;
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
            btnCancelaEmpleado.Location = new Point(1194, 238);
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
            btnGuardarEmpleado.Location = new Point(1062, 238);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(115, 38);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
            // 
            // lblTipoDeEntrega
            // 
            lblTipoDeEntrega.AutoSize = true;
            lblTipoDeEntrega.Location = new Point(58, 41);
            lblTipoDeEntrega.Name = "lblTipoDeEntrega";
            lblTipoDeEntrega.Size = new Size(134, 21);
            lblTipoDeEntrega.TabIndex = 4;
            lblTipoDeEntrega.Text = "Tipo de Entrega:";
            // 
            // frmAgregarEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(706, 416);
            Controls.Add(gbAddEntrega);
            Controls.Add(pSuperiorAddEntrega);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarEntrega";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarEntrega";
            Load += frmAgregarEntrega_Load;
            gbAddEntrega.ResumeLayout(false);
            gbAddEntrega.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperiorAddEntrega;
        private GroupBox gbAddEntrega;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private ComboBox cbxAreaEmpleado;
        private ComboBox cbxCargoEmpleado;
        private TextBox txtEmailEmpleado;
        private TextBox txtTelefonoEmpleado;
        private TextBox txtApellidoEmpleado;
        private TextBox txtNombreEmpleado;
        private Label lblAreaEmpleado;
        private Label lblTipoDeEntrega;
        private Label lblEmailEmpleado;
        private Label lblTelefonoEmpleado;
        private Label lblApellidoEmpleado;
        private Label lblNombreEmpleado;
        private ComboBox cboxTipoEntrega;
        private Label lblFechaEntrega;
        private DateTimePicker dtpickerFechaEntrega;
        private FontAwesome.Sharp.IconButton ibtnCancelarEntrega;
        private FontAwesome.Sharp.IconButton ibtnGuardarEntrega;
        private Label lblObservacionEntrega;
        private RichTextBox rtxtObservacionEntrega;
        private ComboBox cboxEquipo;
        private Label lblEquipo;
        private ComboBox cboxEmpleado;
        private Label labEmpleado;
        private TextBox tboxCantidadDisponible;
        private Label lblCantidadDisponible;
        private Label lblCantidadAEntregar;
        private MaskedTextBox tboxCantidadEntrega;
    }
}