﻿namespace Presentacion
{
    partial class frmAgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarEmpleado));
            gbAddEmpleado = new GroupBox();
            txtTelefonoEmpleado = new MaskedTextBox();
            btnCancelaEmpleado = new FontAwesome.Sharp.IconButton();
            btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            cbxAreaEmpleado = new ComboBox();
            cbxCargoEmpleado = new ComboBox();
            txtEmailEmpleado = new TextBox();
            txtApellidoEmpleado = new TextBox();
            txtNombreEmpleado = new TextBox();
            lblAreaEmpleado = new Label();
            lblCargoEmpleado = new Label();
            lblEmailEmpleado = new Label();
            lblTelefonoEmpleado = new Label();
            lblApellidoEmpleado = new Label();
            lblNombreEmpleado = new Label();
            pSuperiorAddEmpleado = new Panel();
            pboxLogo = new PictureBox();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            gbAddEmpleado.SuspendLayout();
            pSuperiorAddEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).BeginInit();
            SuspendLayout();
            // 
            // gbAddEmpleado
            // 
            gbAddEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbAddEmpleado.Controls.Add(txtTelefonoEmpleado);
            gbAddEmpleado.Controls.Add(btnCancelaEmpleado);
            gbAddEmpleado.Controls.Add(btnGuardarEmpleado);
            gbAddEmpleado.Controls.Add(cbxAreaEmpleado);
            gbAddEmpleado.Controls.Add(cbxCargoEmpleado);
            gbAddEmpleado.Controls.Add(txtEmailEmpleado);
            gbAddEmpleado.Controls.Add(txtApellidoEmpleado);
            gbAddEmpleado.Controls.Add(txtNombreEmpleado);
            gbAddEmpleado.Controls.Add(lblAreaEmpleado);
            gbAddEmpleado.Controls.Add(lblCargoEmpleado);
            gbAddEmpleado.Controls.Add(lblEmailEmpleado);
            gbAddEmpleado.Controls.Add(lblTelefonoEmpleado);
            gbAddEmpleado.Controls.Add(lblApellidoEmpleado);
            gbAddEmpleado.Controls.Add(lblNombreEmpleado);
            gbAddEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAddEmpleado.Location = new Point(12, 66);
            gbAddEmpleado.Name = "gbAddEmpleado";
            gbAddEmpleado.Size = new Size(561, 276);
            gbAddEmpleado.TabIndex = 1;
            gbAddEmpleado.TabStop = false;
            gbAddEmpleado.Text = "AGREGAR EMPLEADO";
            // 
            // txtTelefonoEmpleado
            // 
            txtTelefonoEmpleado.Cursor = Cursors.IBeam;
            txtTelefonoEmpleado.Font = new Font("Segoe UI", 12F);
            txtTelefonoEmpleado.Location = new Point(26, 168);
            txtTelefonoEmpleado.Mask = "0000-0000";
            txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            txtTelefonoEmpleado.Size = new Size(266, 29);
            txtTelefonoEmpleado.TabIndex = 8;
            txtTelefonoEmpleado.KeyPress += frmAgregarEmpleado_KeyPress;
            // 
            // btnCancelaEmpleado
            // 
            btnCancelaEmpleado.BackColor = Color.White;
            btnCancelaEmpleado.Cursor = Cursors.Hand;
            btnCancelaEmpleado.FlatAppearance.BorderSize = 0;
            btnCancelaEmpleado.FlatStyle = FlatStyle.Flat;
            btnCancelaEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelaEmpleado.ForeColor = Color.FromArgb(5, 23, 59);
            btnCancelaEmpleado.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            btnCancelaEmpleado.IconColor = Color.FromArgb(5, 23, 59);
            btnCancelaEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelaEmpleado.IconSize = 20;
            btnCancelaEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelaEmpleado.Location = new Point(419, 216);
            btnCancelaEmpleado.Name = "btnCancelaEmpleado";
            btnCancelaEmpleado.Size = new Size(115, 35);
            btnCancelaEmpleado.TabIndex = 13;
            btnCancelaEmpleado.Text = "CANCELAR";
            btnCancelaEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelaEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelaEmpleado.UseVisualStyleBackColor = false;
            btnCancelaEmpleado.Click += btnCancelaEmpleado_Click;
            // 
            // btnGuardarEmpleado
            // 
            btnGuardarEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            btnGuardarEmpleado.Cursor = Cursors.Hand;
            btnGuardarEmpleado.FlatAppearance.BorderSize = 0;
            btnGuardarEmpleado.FlatStyle = FlatStyle.Flat;
            btnGuardarEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarEmpleado.ForeColor = Color.White;
            btnGuardarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarEmpleado.IconColor = Color.White;
            btnGuardarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarEmpleado.IconSize = 20;
            btnGuardarEmpleado.Location = new Point(419, 163);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(115, 38);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
            btnGuardarEmpleado.Click += btnGuardarEmpleado_Click;
            // 
            // cbxAreaEmpleado
            // 
            cbxAreaEmpleado.Cursor = Cursors.Hand;
            cbxAreaEmpleado.Font = new Font("Segoe UI", 12F);
            cbxAreaEmpleado.FormattingEnabled = true;
            cbxAreaEmpleado.Location = new Point(328, 112);
            cbxAreaEmpleado.Name = "cbxAreaEmpleado";
            cbxAreaEmpleado.Size = new Size(206, 29);
            cbxAreaEmpleado.TabIndex = 11;
            cbxAreaEmpleado.KeyPress += frmAgregarEmpleado_KeyPress;
            // 
            // cbxCargoEmpleado
            // 
            cbxCargoEmpleado.Cursor = Cursors.Hand;
            cbxCargoEmpleado.Font = new Font("Segoe UI", 12F);
            cbxCargoEmpleado.FormattingEnabled = true;
            cbxCargoEmpleado.Location = new Point(328, 53);
            cbxCargoEmpleado.Name = "cbxCargoEmpleado";
            cbxCargoEmpleado.Size = new Size(206, 29);
            cbxCargoEmpleado.TabIndex = 10;
            cbxCargoEmpleado.KeyPress += frmAgregarEmpleado_KeyPress;
            // 
            // txtEmailEmpleado
            // 
            txtEmailEmpleado.Cursor = Cursors.IBeam;
            txtEmailEmpleado.Font = new Font("Segoe UI", 12F);
            txtEmailEmpleado.Location = new Point(26, 222);
            txtEmailEmpleado.MaxLength = 100;
            txtEmailEmpleado.Name = "txtEmailEmpleado";
            txtEmailEmpleado.Size = new Size(266, 29);
            txtEmailEmpleado.TabIndex = 9;
            txtEmailEmpleado.KeyPress += frmAgregarEmpleado_KeyPress;
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.Cursor = Cursors.IBeam;
            txtApellidoEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoEmpleado.Location = new Point(26, 112);
            txtApellidoEmpleado.MaxLength = 50;
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(266, 29);
            txtApellidoEmpleado.TabIndex = 7;
            txtApellidoEmpleado.KeyPress += frmAgregarEmpleado_KeyPress;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Cursor = Cursors.IBeam;
            txtNombreEmpleado.Font = new Font("Segoe UI", 12F);
            txtNombreEmpleado.Location = new Point(26, 53);
            txtNombreEmpleado.MaxLength = 50;
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(266, 29);
            txtNombreEmpleado.TabIndex = 6;
            txtNombreEmpleado.KeyPress += frmAgregarEmpleado_KeyPress;
            // 
            // lblAreaEmpleado
            // 
            lblAreaEmpleado.AutoSize = true;
            lblAreaEmpleado.Location = new Point(328, 88);
            lblAreaEmpleado.Name = "lblAreaEmpleado";
            lblAreaEmpleado.Size = new Size(49, 21);
            lblAreaEmpleado.TabIndex = 5;
            lblAreaEmpleado.Text = "Área:";
            // 
            // lblCargoEmpleado
            // 
            lblCargoEmpleado.AutoSize = true;
            lblCargoEmpleado.Location = new Point(328, 29);
            lblCargoEmpleado.Name = "lblCargoEmpleado";
            lblCargoEmpleado.Size = new Size(59, 21);
            lblCargoEmpleado.TabIndex = 4;
            lblCargoEmpleado.Text = "Cargo:";
            // 
            // lblEmailEmpleado
            // 
            lblEmailEmpleado.AutoSize = true;
            lblEmailEmpleado.Location = new Point(26, 200);
            lblEmailEmpleado.Name = "lblEmailEmpleado";
            lblEmailEmpleado.Size = new Size(57, 21);
            lblEmailEmpleado.TabIndex = 3;
            lblEmailEmpleado.Text = "Email:";
            // 
            // lblTelefonoEmpleado
            // 
            lblTelefonoEmpleado.AutoSize = true;
            lblTelefonoEmpleado.Location = new Point(26, 144);
            lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            lblTelefonoEmpleado.Size = new Size(81, 21);
            lblTelefonoEmpleado.TabIndex = 2;
            lblTelefonoEmpleado.Text = "Teléfono:";
            // 
            // lblApellidoEmpleado
            // 
            lblApellidoEmpleado.AutoSize = true;
            lblApellidoEmpleado.Location = new Point(26, 88);
            lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            lblApellidoEmpleado.Size = new Size(79, 21);
            lblApellidoEmpleado.TabIndex = 1;
            lblApellidoEmpleado.Text = "Apellido:";
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.AutoSize = true;
            lblNombreEmpleado.Location = new Point(26, 29);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(77, 21);
            lblNombreEmpleado.TabIndex = 0;
            lblNombreEmpleado.Text = "Nombre:";
            // 
            // pSuperiorAddEmpleado
            // 
            pSuperiorAddEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddEmpleado.Controls.Add(pboxLogo);
            pSuperiorAddEmpleado.Controls.Add(btnCerrarAddEmpleado);
            pSuperiorAddEmpleado.Dock = DockStyle.Top;
            pSuperiorAddEmpleado.Location = new Point(0, 0);
            pSuperiorAddEmpleado.Margin = new Padding(3, 2, 3, 2);
            pSuperiorAddEmpleado.Name = "pSuperiorAddEmpleado";
            pSuperiorAddEmpleado.Size = new Size(585, 60);
            pSuperiorAddEmpleado.TabIndex = 0;
            // 
            // pboxLogo
            // 
            pboxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pboxLogo.Image = (Image)resources.GetObject("pboxLogo.Image");
            pboxLogo.Location = new Point(18, 0);
            pboxLogo.Margin = new Padding(3, 2, 3, 2);
            pboxLogo.Name = "pboxLogo";
            pboxLogo.Size = new Size(184, 60);
            pboxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pboxLogo.TabIndex = 16;
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
            btnCerrarAddEmpleado.Location = new Point(550, 9);
            btnCerrarAddEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.Size = new Size(24, 18);
            btnCerrarAddEmpleado.TabIndex = 15;
            btnCerrarAddEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarAddEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            btnCerrarAddEmpleado.Click += btnCerrarAddEmpleado_Click;
            // 
            // frmAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(585, 354);
            Controls.Add(gbAddEmpleado);
            Controls.Add(pSuperiorAddEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMPLEADO ";
            Load += frmAgregarEmpleado_Load;
            KeyPress += frmAgregarEmpleado_KeyPress;
            gbAddEmpleado.ResumeLayout(false);
            gbAddEmpleado.PerformLayout();
            pSuperiorAddEmpleado.ResumeLayout(false);
            pSuperiorAddEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gbAddEmpleado;
        private Label lblAreaEmpleado;
        private Label lblCargoEmpleado;
        private Label lblTelefonoEmpleado;
        private Label lblApellidoEmpleado;
        private Label lblNombreEmpleado;
        private ComboBox cbxAreaEmpleado;
        private ComboBox cbxCargoEmpleado;
        private TextBox txtEmailEmpleado;
        private TextBox txtApellidoEmpleado;
        private TextBox txtNombreEmpleado;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
        private MaskedTextBox txtTelefonoEmpleado;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private PictureBox pboxLogo;
        private Label lblEmailEmpleado;
        private Panel pSuperiorAddEmpleado;
    }
}