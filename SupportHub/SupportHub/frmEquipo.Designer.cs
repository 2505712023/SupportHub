namespace Presentacion
{
    partial class frmEquipo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnEliminarEquipo = new FontAwesome.Sharp.IconButton();
            btnModificarEquipo = new FontAwesome.Sharp.IconButton();
            btnAgregarEquipo = new FontAwesome.Sharp.IconButton();
            dgvEquipo = new DataGridView();
            gbBusarEmpleado = new GroupBox();
            cbxTipoBusquedaEquipo = new ComboBox();
            txtBuscarEquipo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipo).BeginInit();
            gbBusarEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarEquipo.BackColor = Color.FromArgb(184, 82, 82);
            btnEliminarEquipo.Cursor = Cursors.Hand;
            btnEliminarEquipo.FlatAppearance.BorderSize = 0;
            btnEliminarEquipo.FlatStyle = FlatStyle.Flat;
            btnEliminarEquipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminarEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            btnEliminarEquipo.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarEquipo.IconColor = Color.FromArgb(31, 35, 40);
            btnEliminarEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarEquipo.IconSize = 20;
            btnEliminarEquipo.Location = new Point(963, 203);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(156, 57);
            btnEliminarEquipo.TabIndex = 14;
            btnEliminarEquipo.Text = "ELIMINAR";
            btnEliminarEquipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarEquipo.UseVisualStyleBackColor = false;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // btnModificarEquipo
            // 
            btnModificarEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificarEquipo.BackColor = Color.FromArgb(55, 166, 104);
            btnModificarEquipo.Cursor = Cursors.Hand;
            btnModificarEquipo.Enabled = false;
            btnModificarEquipo.FlatAppearance.BorderSize = 0;
            btnModificarEquipo.FlatStyle = FlatStyle.Flat;
            btnModificarEquipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnModificarEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            btnModificarEquipo.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            btnModificarEquipo.IconColor = Color.FromArgb(31, 35, 40);
            btnModificarEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificarEquipo.IconSize = 20;
            btnModificarEquipo.Location = new Point(963, 142);
            btnModificarEquipo.Name = "btnModificarEquipo";
            btnModificarEquipo.Size = new Size(156, 55);
            btnModificarEquipo.TabIndex = 13;
            btnModificarEquipo.Text = "MODIFICAR";
            btnModificarEquipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificarEquipo.UseVisualStyleBackColor = false;
            btnModificarEquipo.Click += btnModificarEquipo_Click;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEquipo.BackColor = Color.FromArgb(89, 134, 213);
            btnAgregarEquipo.Cursor = Cursors.Hand;
            btnAgregarEquipo.FlatAppearance.BorderSize = 0;
            btnAgregarEquipo.FlatStyle = FlatStyle.Flat;
            btnAgregarEquipo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarEquipo.ForeColor = Color.FromArgb(31, 35, 40);
            btnAgregarEquipo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregarEquipo.IconColor = Color.FromArgb(31, 35, 40);
            btnAgregarEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarEquipo.IconSize = 20;
            btnAgregarEquipo.Location = new Point(963, 86);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(156, 50);
            btnAgregarEquipo.TabIndex = 12;
            btnAgregarEquipo.Text = "AGREGAR";
            btnAgregarEquipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarEquipo.UseVisualStyleBackColor = false;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // dgvEquipo
            // 
            dgvEquipo.AllowUserToAddRows = false;
            dgvEquipo.AllowUserToDeleteRows = false;
            dgvEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEquipo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvEquipo.BackgroundColor = Color.FromArgb(148, 184, 216);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEquipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEquipo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvEquipo.DefaultCellStyle.SelectionBackColor = Color.Silver;
            dgvEquipo.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvEquipo.Location = new Point(12, 86);
            dgvEquipo.Name = "dgvEquipo";
            dgvEquipo.ReadOnly = true;
            dgvEquipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEquipo.Size = new Size(945, 417);
            dgvEquipo.TabIndex = 11;
            dgvEquipo.SelectionChanged += dgvEquipo_SelectionChanged;
            // 
            // gbBusarEmpleado
            // 
            gbBusarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBusarEmpleado.Controls.Add(cbxTipoBusquedaEquipo);
            gbBusarEmpleado.Controls.Add(txtBuscarEquipo);
            gbBusarEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbBusarEmpleado.Location = new Point(12, 12);
            gbBusarEmpleado.Name = "gbBusarEmpleado";
            gbBusarEmpleado.Size = new Size(945, 68);
            gbBusarEmpleado.TabIndex = 10;
            gbBusarEmpleado.TabStop = false;
            gbBusarEmpleado.Text = "BUSCAR EQUIPO::...";
            // 
            // cbxTipoBusquedaEquipo
            // 
            cbxTipoBusquedaEquipo.Cursor = Cursors.Hand;
            cbxTipoBusquedaEquipo.Font = new Font("Segoe UI", 9F);
            cbxTipoBusquedaEquipo.FormattingEnabled = true;
            cbxTipoBusquedaEquipo.Location = new Point(6, 26);
            cbxTipoBusquedaEquipo.Name = "cbxTipoBusquedaEquipo";
            cbxTipoBusquedaEquipo.Size = new Size(139, 23);
            cbxTipoBusquedaEquipo.TabIndex = 6;
            cbxTipoBusquedaEquipo.TextChanged += cbxTipoBusquedaEquipo_TextChanged;
            // 
            // txtBuscarEquipo
            // 
            txtBuscarEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarEquipo.Font = new Font("Segoe UI", 9F);
            txtBuscarEquipo.Location = new Point(151, 26);
            txtBuscarEquipo.Name = "txtBuscarEquipo";
            txtBuscarEquipo.Size = new Size(788, 23);
            txtBuscarEquipo.TabIndex = 5;
            txtBuscarEquipo.TextChanged += txtBuscarEquipo_TextChanged;
            // 
            // frmEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1131, 515);
            Controls.Add(btnEliminarEquipo);
            Controls.Add(btnModificarEquipo);
            Controls.Add(btnAgregarEquipo);
            Controls.Add(dgvEquipo);
            Controls.Add(gbBusarEmpleado);
            Name = "frmEquipo";
            Text = "EQUIPO";
            Load += frmEquipo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipo).EndInit();
            gbBusarEmpleado.ResumeLayout(false);
            gbBusarEmpleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEliminarEquipo;
        private FontAwesome.Sharp.IconButton btnModificarEquipo;
        private FontAwesome.Sharp.IconButton btnAgregarEquipo;
        private DataGridView dgvEquipo;
        private GroupBox gbBusarEmpleado;
        private ComboBox cbxTipoBusquedaEquipo;
        private TextBox txtBuscarEquipo;
    }
}
