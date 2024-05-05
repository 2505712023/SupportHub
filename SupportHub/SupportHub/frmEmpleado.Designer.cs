namespace Presentacion
{
    partial class frmEmpleado
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
            gbBusarEmpleado = new GroupBox();
            cbxTipoBusquedaEmpleado = new ComboBox();
            txtBuscarEmpleado = new TextBox();
            dgvEmpleado = new DataGridView();
            pDerechoEmpleado = new Panel();
            btnAgregarEmpleado = new FontAwesome.Sharp.IconButton();
            btnModificaEmpleado = new FontAwesome.Sharp.IconButton();
            btnEliminarEmpleado = new FontAwesome.Sharp.IconButton();
            gbBusarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            SuspendLayout();
            // 
            // gbBusarEmpleado
            // 
            gbBusarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBusarEmpleado.Controls.Add(cbxTipoBusquedaEmpleado);
            gbBusarEmpleado.Controls.Add(txtBuscarEmpleado);
            gbBusarEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbBusarEmpleado.Location = new Point(12, 25);
            gbBusarEmpleado.Name = "gbBusarEmpleado";
            gbBusarEmpleado.Size = new Size(932, 68);
            gbBusarEmpleado.TabIndex = 0;
            gbBusarEmpleado.TabStop = false;
            gbBusarEmpleado.Text = "EMPLEADO::...";
            // 
            // cbxTipoBusquedaEmpleado
            // 
            cbxTipoBusquedaEmpleado.Font = new Font("Segoe UI", 9F);
            cbxTipoBusquedaEmpleado.FormattingEnabled = true;
            cbxTipoBusquedaEmpleado.Location = new Point(6, 26);
            cbxTipoBusquedaEmpleado.Name = "cbxTipoBusquedaEmpleado";
            cbxTipoBusquedaEmpleado.Size = new Size(121, 23);
            cbxTipoBusquedaEmpleado.TabIndex = 6;
            cbxTipoBusquedaEmpleado.SelectedIndexChanged += cbxTipoBusquedaEmpleado_SelectedIndexChanged;
            cbxTipoBusquedaEmpleado.TextChanged += cbxTipoBusquedaEmpleado_TextChanged;
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarEmpleado.Font = new Font("Segoe UI", 9F);
            txtBuscarEmpleado.Location = new Point(139, 26);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(787, 23);
            txtBuscarEmpleado.TabIndex = 5;
            txtBuscarEmpleado.TextChanged += txtBuscarEmpleado_TextChanged;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.AllowUserToAddRows = false;
            dgvEmpleado.AllowUserToDeleteRows = false;
            dgvEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleado.BackgroundColor = Color.FromArgb(148, 184, 216);
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Location = new Point(12, 119);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.ReadOnly = true;
            dgvEmpleado.Size = new Size(932, 373);
            dgvEmpleado.TabIndex = 1;
            dgvEmpleado.CellContentClick += dgvEmpleado_CellContentClick;
            // 
            // pDerechoEmpleado
            // 
            pDerechoEmpleado.Dock = DockStyle.Right;
            pDerechoEmpleado.Location = new Point(1062, 0);
            pDerechoEmpleado.Name = "pDerechoEmpleado";
            pDerechoEmpleado.Size = new Size(99, 515);
            pDerechoEmpleado.TabIndex = 6;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEmpleado.BackColor = Color.FromArgb(89, 134, 213);
            btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            btnAgregarEmpleado.FlatStyle = FlatStyle.Flat;
            btnAgregarEmpleado.ForeColor = Color.FromArgb(31, 35, 40);
            btnAgregarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregarEmpleado.IconColor = Color.FromArgb(31, 35, 40);
            btnAgregarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarEmpleado.IconSize = 20;
            btnAgregarEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarEmpleado.Location = new Point(950, 151);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(113, 50);
            btnAgregarEmpleado.TabIndex = 7;
            btnAgregarEmpleado.Text = "AGREGAR";
            btnAgregarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarEmpleado.UseVisualStyleBackColor = false;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // btnModificaEmpleado
            // 
            btnModificaEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificaEmpleado.BackColor = Color.FromArgb(55, 166, 104);
            btnModificaEmpleado.FlatAppearance.BorderSize = 0;
            btnModificaEmpleado.FlatStyle = FlatStyle.Flat;
            btnModificaEmpleado.ForeColor = Color.FromArgb(31, 35, 40);
            btnModificaEmpleado.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            btnModificaEmpleado.IconColor = Color.FromArgb(31, 35, 40);
            btnModificaEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificaEmpleado.IconSize = 20;
            btnModificaEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificaEmpleado.Location = new Point(950, 216);
            btnModificaEmpleado.Name = "btnModificaEmpleado";
            btnModificaEmpleado.Size = new Size(113, 55);
            btnModificaEmpleado.TabIndex = 8;
            btnModificaEmpleado.Text = "MODIFICAR";
            btnModificaEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnModificaEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificaEmpleado.UseVisualStyleBackColor = false;
            btnModificaEmpleado.Click += btnModificaEmpleado_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarEmpleado.BackColor = Color.FromArgb(184, 82, 82);
            btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            btnEliminarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEliminarEmpleado.ForeColor = Color.FromArgb(31, 35, 40);
            btnEliminarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarEmpleado.IconColor = Color.FromArgb(31, 35, 40);
            btnEliminarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarEmpleado.IconSize = 20;
            btnEliminarEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarEmpleado.Location = new Point(950, 299);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(113, 57);
            btnEliminarEmpleado.TabIndex = 9;
            btnEliminarEmpleado.Text = "ELIMINAR";
            btnEliminarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarEmpleado.UseVisualStyleBackColor = false;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1161, 515);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnModificaEmpleado);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(pDerechoEmpleado);
            Controls.Add(dgvEmpleado);
            Controls.Add(gbBusarEmpleado);
            Name = "frmEmpleado";
            Text = "EMPLEADO";
            Load += frmEmpleado_Load;
            Shown += frmEmpleado_Shown;
            gbBusarEmpleado.ResumeLayout(false);
            gbBusarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbBusarEmpleado;
        private TextBox txtBuscarEmpleado;
        private DataGridView dgvEmpleado;
        private Panel pDerechoEmpleado;
        private FontAwesome.Sharp.IconButton btnAgregarEmpleado;
        private FontAwesome.Sharp.IconButton btnModificaEmpleado;
        private FontAwesome.Sharp.IconButton btnEliminarEmpleado;
        private ComboBox cbxTipoBusquedaEmpleado;
    }
}