namespace Presentacion
{
    partial class frmDevolucionEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucionEntrega));
            pSuperiorAddEntrega = new Panel();
            pboxLogo = new PictureBox();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            gbAddEntrega = new GroupBox();
            btnCancelarDevolucion = new FontAwesome.Sharp.IconButton();
            btnGuardarDevolucion = new FontAwesome.Sharp.IconButton();
            tboxCodigoEntrega = new TextBox();
            ibtnCancelarEntrega = new FontAwesome.Sharp.IconButton();
            ibtnGuardarEntrega = new FontAwesome.Sharp.IconButton();
            lblFechaDevolucion = new Label();
            dtpickerFechaDevolucion = new DateTimePicker();
            btnCancelaEmpleado = new FontAwesome.Sharp.IconButton();
            btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            lblCodigoEntrega = new Label();
            pSuperiorAddEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            gbAddEntrega.SuspendLayout();
            SuspendLayout();
            // 
            // pSuperiorAddEntrega
            // 
            pSuperiorAddEntrega.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddEntrega.Controls.Add(pboxLogo);
            pSuperiorAddEntrega.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorAddEntrega.Dock = DockStyle.Top;
            pSuperiorAddEntrega.Location = new Point(0, 0);
            pSuperiorAddEntrega.Name = "pSuperiorAddEntrega";
            pSuperiorAddEntrega.Size = new Size(442, 60);
            pSuperiorAddEntrega.TabIndex = 2;
            // 
            // pboxLogo
            // 
            pboxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pboxLogo.Image = (Image)resources.GetObject("pboxLogo.Image");
            pboxLogo.Location = new Point(20, 0);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new Size(184, 60);
            pboxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pboxLogo.TabIndex = 18;
            pboxLogo.TabStop = false;
            // 
            // btnCerrarAddEmpleado
            // 
            btnCerrarAddEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarAddEmpleado.Cursor = Cursors.Hand;
            btnCerrarAddEmpleado.FlatAppearance.BorderSize = 0;
            btnCerrarAddEmpleado.FlatStyle = FlatStyle.Flat;
            btnCerrarAddEmpleado.ForeColor = SystemColors.ControlLightLight;
            btnCerrarAddEmpleado.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarAddEmpleado.IconColor = SystemColors.Window;
            btnCerrarAddEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarAddEmpleado.IconSize = 20;
            btnCerrarAddEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.Location = new Point(402, 12);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(28, 24);
            btnCerrarAddEmpleado.TabIndex = 17;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            btnCerrarAddEmpleado.Click += btnCerrarAddEmpleado_Click;
            // 
            // gbAddEntrega
            // 
            gbAddEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddEntrega.Controls.Add(btnCancelarDevolucion);
            gbAddEntrega.Controls.Add(btnGuardarDevolucion);
            gbAddEntrega.Controls.Add(tboxCodigoEntrega);
            gbAddEntrega.Controls.Add(ibtnCancelarEntrega);
            gbAddEntrega.Controls.Add(ibtnGuardarEntrega);
            gbAddEntrega.Controls.Add(lblFechaDevolucion);
            gbAddEntrega.Controls.Add(dtpickerFechaDevolucion);
            gbAddEntrega.Controls.Add(btnCancelaEmpleado);
            gbAddEntrega.Controls.Add(btnGuardarEmpleado);
            gbAddEntrega.Controls.Add(lblCodigoEntrega);
            gbAddEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddEntrega.Location = new Point(12, 66);
            gbAddEntrega.Name = "gbAddEntrega";
            gbAddEntrega.Size = new Size(418, 184);
            gbAddEntrega.TabIndex = 3;
            gbAddEntrega.TabStop = false;
            gbAddEntrega.Text = "ASIGNAR DEVOLUCIÓN";
            // 
            // btnCancelarDevolucion
            // 
            btnCancelarDevolucion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarDevolucion.BackColor = Color.White;
            btnCancelarDevolucion.Cursor = Cursors.Hand;
            btnCancelarDevolucion.FlatAppearance.BorderSize = 0;
            btnCancelarDevolucion.FlatStyle = FlatStyle.Flat;
            btnCancelarDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarDevolucion.ForeColor = Color.FromArgb(5, 23, 59);
            btnCancelarDevolucion.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnCancelarDevolucion.IconColor = Color.FromArgb(5, 23, 59);
            btnCancelarDevolucion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarDevolucion.IconSize = 20;
            btnCancelarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarDevolucion.Location = new Point(290, 121);
            btnCancelarDevolucion.Name = "btnCancelarDevolucion";
            btnCancelarDevolucion.Size = new Size(100, 40);
            btnCancelarDevolucion.TabIndex = 34;
            btnCancelarDevolucion.Text = "CANCELAR";
            btnCancelarDevolucion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarDevolucion.UseVisualStyleBackColor = false;
            btnCancelarDevolucion.Click += btnCancelarDevolucion_Click;
            // 
            // btnGuardarDevolucion
            // 
            btnGuardarDevolucion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarDevolucion.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardarDevolucion.Cursor = Cursors.Hand;
            btnGuardarDevolucion.FlatAppearance.BorderSize = 0;
            btnGuardarDevolucion.FlatStyle = FlatStyle.Flat;
            btnGuardarDevolucion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarDevolucion.ForeColor = Color.White;
            btnGuardarDevolucion.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarDevolucion.IconColor = Color.White;
            btnGuardarDevolucion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarDevolucion.IconSize = 20;
            btnGuardarDevolucion.Location = new Point(184, 121);
            btnGuardarDevolucion.Name = "btnGuardarDevolucion";
            btnGuardarDevolucion.Size = new Size(100, 40);
            btnGuardarDevolucion.TabIndex = 33;
            btnGuardarDevolucion.Text = "GUARDAR";
            btnGuardarDevolucion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarDevolucion.UseVisualStyleBackColor = false;
            btnGuardarDevolucion.Click += btnGuardarDevolucion_Click;
            // 
            // tboxCodigoEntrega
            // 
            tboxCodigoEntrega.Enabled = false;
            tboxCodigoEntrega.Font = new Font("Segoe UI", 12F);
            tboxCodigoEntrega.ForeColor = Color.Black;
            tboxCodigoEntrega.Location = new Point(202, 31);
            tboxCodigoEntrega.Name = "tboxCodigoEntrega";
            tboxCodigoEntrega.ReadOnly = true;
            tboxCodigoEntrega.Size = new Size(188, 29);
            tboxCodigoEntrega.TabIndex = 32;
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
            ibtnCancelarEntrega.Location = new Point(803, 102);
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
            ibtnGuardarEntrega.Location = new Point(803, 56);
            ibtnGuardarEntrega.Name = "ibtnGuardarEntrega";
            ibtnGuardarEntrega.Size = new Size(100, 40);
            ibtnGuardarEntrega.TabIndex = 17;
            ibtnGuardarEntrega.Text = "GUARDAR";
            ibtnGuardarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnGuardarEntrega.UseVisualStyleBackColor = false;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Location = new Point(20, 75);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(173, 21);
            lblFechaDevolucion.TabIndex = 16;
            lblFechaDevolucion.Text = "Fecha de Devolución:";
            // 
            // dtpickerFechaDevolucion
            // 
            dtpickerFechaDevolucion.Cursor = Cursors.Hand;
            dtpickerFechaDevolucion.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpickerFechaDevolucion.Font = new Font("Segoe UI", 12F);
            dtpickerFechaDevolucion.Location = new Point(202, 69);
            dtpickerFechaDevolucion.Name = "dtpickerFechaDevolucion";
            dtpickerFechaDevolucion.Size = new Size(188, 29);
            dtpickerFechaDevolucion.TabIndex = 15;
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
            btnCancelaEmpleado.Location = new Point(1440, 238);
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
            btnGuardarEmpleado.Location = new Point(1308, 238);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(115, 38);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
            // 
            // lblCodigoEntrega
            // 
            lblCodigoEntrega.AutoSize = true;
            lblCodigoEntrega.Location = new Point(61, 34);
            lblCodigoEntrega.Name = "lblCodigoEntrega";
            lblCodigoEntrega.Size = new Size(132, 21);
            lblCodigoEntrega.TabIndex = 4;
            lblCodigoEntrega.Text = "Código Entrega:";
            // 
            // frmDevolucionEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(442, 262);
            Controls.Add(gbAddEntrega);
            Controls.Add(pSuperiorAddEntrega);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDevolucionEntrega";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDevolucionEntrega";
            Load += frmDevolucionEntrega_Load;
            pSuperiorAddEntrega.ResumeLayout(false);
            pSuperiorAddEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            gbAddEntrega.ResumeLayout(false);
            gbAddEntrega.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperiorAddEntrega;
        private GroupBox gbAddEntrega;
        private TextBox tboxCodigoEntrega;
        private FontAwesome.Sharp.IconButton ibtnCancelarEntrega;
        private FontAwesome.Sharp.IconButton ibtnGuardarEntrega;
        private Label lblFechaDevolucion;
        private DateTimePicker dtpickerFechaDevolucion;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private Label lblCodigoEntrega;
        private FontAwesome.Sharp.IconButton btnCancelarDevolucion;
        private FontAwesome.Sharp.IconButton btnGuardarDevolucion;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private PictureBox pboxLogo;
    }
}