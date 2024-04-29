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
            pSuperiorAddEmpleado = new Panel();
            gbAddEmpleado = new GroupBox();
            lblNombreEmpleado = new Label();
            lblApellidoEmpleado = new Label();
            lblTelefonoEmpleado = new Label();
            lblEmailEmpleado = new Label();
            lblCargoEmpleado = new Label();
            lblAreaEmpleado = new Label();
            txtNombreEmpleado = new TextBox();
            txtApellidoEmpleado = new TextBox();
            txtTelefonoEmpleado = new TextBox();
            txtEmailEmpleado = new TextBox();
            cbxCargoEmpleado = new ComboBox();
            cbxAreaEmpleado = new ComboBox();
            btnGuardarEmpleado = new FontAwesome.Sharp.IconButton();
            btnCancelaEmpleado = new FontAwesome.Sharp.IconButton();
            gbAddEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // pSuperiorAddEmpleado
            // 
            pSuperiorAddEmpleado.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddEmpleado.Dock = DockStyle.Top;
            pSuperiorAddEmpleado.Location = new Point(0, 0);
            pSuperiorAddEmpleado.Name = "pSuperiorAddEmpleado";
            pSuperiorAddEmpleado.Size = new Size(966, 60);
            pSuperiorAddEmpleado.TabIndex = 0;
            // 
            // gbAddEmpleado
            // 
            gbAddEmpleado.Controls.Add(btnCancelaEmpleado);
            gbAddEmpleado.Controls.Add(btnGuardarEmpleado);
            gbAddEmpleado.Controls.Add(cbxAreaEmpleado);
            gbAddEmpleado.Controls.Add(cbxCargoEmpleado);
            gbAddEmpleado.Controls.Add(txtEmailEmpleado);
            gbAddEmpleado.Controls.Add(txtTelefonoEmpleado);
            gbAddEmpleado.Controls.Add(txtApellidoEmpleado);
            gbAddEmpleado.Controls.Add(txtNombreEmpleado);
            gbAddEmpleado.Controls.Add(lblAreaEmpleado);
            gbAddEmpleado.Controls.Add(lblCargoEmpleado);
            gbAddEmpleado.Controls.Add(lblEmailEmpleado);
            gbAddEmpleado.Controls.Add(lblTelefonoEmpleado);
            gbAddEmpleado.Controls.Add(lblApellidoEmpleado);
            gbAddEmpleado.Controls.Add(lblNombreEmpleado);
            gbAddEmpleado.Location = new Point(27, 76);
            gbAddEmpleado.Name = "gbAddEmpleado";
            gbAddEmpleado.Size = new Size(898, 308);
            gbAddEmpleado.TabIndex = 1;
            gbAddEmpleado.TabStop = false;
            gbAddEmpleado.Text = "AGREGAR EMPLEADO";
            // 
            // lblNombreEmpleado
            // 
            lblNombreEmpleado.AutoSize = true;
            lblNombreEmpleado.Location = new Point(55, 29);
            lblNombreEmpleado.Name = "lblNombreEmpleado";
            lblNombreEmpleado.Size = new Size(54, 15);
            lblNombreEmpleado.TabIndex = 0;
            lblNombreEmpleado.Text = "Nombre:";
            // 
            // lblApellidoEmpleado
            // 
            lblApellidoEmpleado.AutoSize = true;
            lblApellidoEmpleado.Location = new Point(55, 88);
            lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            lblApellidoEmpleado.Size = new Size(54, 15);
            lblApellidoEmpleado.TabIndex = 1;
            lblApellidoEmpleado.Text = "Apellido:";
            // 
            // lblTelefonoEmpleado
            // 
            lblTelefonoEmpleado.AutoSize = true;
            lblTelefonoEmpleado.Location = new Point(55, 156);
            lblTelefonoEmpleado.Name = "lblTelefonoEmpleado";
            lblTelefonoEmpleado.Size = new Size(55, 15);
            lblTelefonoEmpleado.TabIndex = 2;
            lblTelefonoEmpleado.Text = "Telefono:";
            // 
            // lblEmailEmpleado
            // 
            lblEmailEmpleado.AutoSize = true;
            lblEmailEmpleado.Location = new Point(55, 220);
            lblEmailEmpleado.Name = "lblEmailEmpleado";
            lblEmailEmpleado.Size = new Size(39, 15);
            lblEmailEmpleado.TabIndex = 3;
            lblEmailEmpleado.Text = "Email:";
            // 
            // lblCargoEmpleado
            // 
            lblCargoEmpleado.AutoSize = true;
            lblCargoEmpleado.Location = new Point(456, 29);
            lblCargoEmpleado.Name = "lblCargoEmpleado";
            lblCargoEmpleado.Size = new Size(42, 15);
            lblCargoEmpleado.TabIndex = 4;
            lblCargoEmpleado.Text = "Cargo:";
            // 
            // lblAreaEmpleado
            // 
            lblAreaEmpleado.AutoSize = true;
            lblAreaEmpleado.Location = new Point(686, 29);
            lblAreaEmpleado.Name = "lblAreaEmpleado";
            lblAreaEmpleado.Size = new Size(34, 15);
            lblAreaEmpleado.TabIndex = 5;
            lblAreaEmpleado.Text = "Area:";
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(55, 47);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(266, 23);
            txtNombreEmpleado.TabIndex = 6;
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.Location = new Point(55, 106);
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(266, 23);
            txtApellidoEmpleado.TabIndex = 7;
            // 
            // txtTelefonoEmpleado
            // 
            txtTelefonoEmpleado.Location = new Point(55, 174);
            txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            txtTelefonoEmpleado.Size = new Size(266, 23);
            txtTelefonoEmpleado.TabIndex = 8;
            // 
            // txtEmailEmpleado
            // 
            txtEmailEmpleado.Location = new Point(55, 238);
            txtEmailEmpleado.Name = "txtEmailEmpleado";
            txtEmailEmpleado.Size = new Size(266, 23);
            txtEmailEmpleado.TabIndex = 9;
            // 
            // cbxCargoEmpleado
            // 
            cbxCargoEmpleado.FormattingEnabled = true;
            cbxCargoEmpleado.Location = new Point(456, 47);
            cbxCargoEmpleado.Name = "cbxCargoEmpleado";
            cbxCargoEmpleado.Size = new Size(155, 23);
            cbxCargoEmpleado.TabIndex = 10;
            // 
            // cbxAreaEmpleado
            // 
            cbxAreaEmpleado.FormattingEnabled = true;
            cbxAreaEmpleado.Location = new Point(686, 47);
            cbxAreaEmpleado.Name = "cbxAreaEmpleado";
            cbxAreaEmpleado.Size = new Size(155, 23);
            cbxAreaEmpleado.TabIndex = 11;
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
            btnGuardarEmpleado.Location = new Point(580, 238);
            btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            btnGuardarEmpleado.Size = new Size(115, 38);
            btnGuardarEmpleado.TabIndex = 12;
            btnGuardarEmpleado.Text = "GUARDAR";
            btnGuardarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEmpleado.UseVisualStyleBackColor = false;
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
            btnCancelaEmpleado.Location = new Point(712, 238);
            btnCancelaEmpleado.Name = "btnCancelaEmpleado";
            btnCancelaEmpleado.Size = new Size(115, 38);
            btnCancelaEmpleado.TabIndex = 13;
            btnCancelaEmpleado.Text = "CACENLAR";
            btnCancelaEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelaEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelaEmpleado.UseVisualStyleBackColor = false;
            btnCancelaEmpleado.Click += btnCancelaEmpleado_Click;
            // 
            // frmAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            ClientSize = new Size(966, 408);
            Controls.Add(gbAddEmpleado);
            Controls.Add(pSuperiorAddEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMPLEADO ";
            gbAddEmpleado.ResumeLayout(false);
            gbAddEmpleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperiorAddEmpleado;
        private GroupBox gbAddEmpleado;
        private Label lblAreaEmpleado;
        private Label lblCargoEmpleado;
        private Label lblEmailEmpleado;
        private Label lblTelefonoEmpleado;
        private Label lblApellidoEmpleado;
        private Label lblNombreEmpleado;
        private ComboBox cbxAreaEmpleado;
        private ComboBox cbxCargoEmpleado;
        private TextBox txtEmailEmpleado;
        private TextBox txtTelefonoEmpleado;
        private TextBox txtApellidoEmpleado;
        private TextBox txtNombreEmpleado;
        private FontAwesome.Sharp.IconButton btnCancelaEmpleado;
        private FontAwesome.Sharp.IconButton btnGuardarEmpleado;
    }
}