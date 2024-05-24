namespace Presentacion
{
    partial class frmEntrega
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            btnEliminarEntrega = new FontAwesome.Sharp.IconButton();
            btnModificarEntrega = new FontAwesome.Sharp.IconButton();
            btnAgregarEntrega = new FontAwesome.Sharp.IconButton();
            dgvEntregas = new DataGridView();
            gbBusarEmpleado = new GroupBox();
            cBoxTipoBusqueda = new ComboBox();
            txtBuscarEntrega = new TextBox();
            btnGenerarDevolucion = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).BeginInit();
            gbBusarEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminarEntrega
            // 
            btnEliminarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarEntrega.BackColor = Color.FromArgb(184, 82, 82);
            btnEliminarEntrega.FlatAppearance.BorderSize = 0;
            btnEliminarEntrega.FlatStyle = FlatStyle.Flat;
            btnEliminarEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminarEntrega.ForeColor = Color.FromArgb(31, 35, 40);
            btnEliminarEntrega.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarEntrega.IconColor = Color.FromArgb(31, 35, 40);
            btnEliminarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarEntrega.IconSize = 20;
            btnEliminarEntrega.Location = new Point(711, 266);
            btnEliminarEntrega.Name = "btnEliminarEntrega";
            btnEliminarEntrega.Size = new Size(156, 57);
            btnEliminarEntrega.TabIndex = 5;
            btnEliminarEntrega.Text = "ELIMINAR";
            btnEliminarEntrega.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarEntrega.UseVisualStyleBackColor = false;
            btnEliminarEntrega.Click += btnEliminarEntrega_Click;
            // 
            // btnModificarEntrega
            // 
            btnModificarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificarEntrega.BackColor = Color.FromArgb(55, 166, 104);
            btnModificarEntrega.FlatAppearance.BorderSize = 0;
            btnModificarEntrega.FlatStyle = FlatStyle.Flat;
            btnModificarEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnModificarEntrega.ForeColor = Color.FromArgb(31, 35, 40);
            btnModificarEntrega.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            btnModificarEntrega.IconColor = Color.FromArgb(31, 35, 40);
            btnModificarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificarEntrega.IconSize = 20;
            btnModificarEntrega.Location = new Point(711, 142);
            btnModificarEntrega.Name = "btnModificarEntrega";
            btnModificarEntrega.Size = new Size(156, 55);
            btnModificarEntrega.TabIndex = 3;
            btnModificarEntrega.Text = "MODIFICAR";
            btnModificarEntrega.TextAlign = ContentAlignment.MiddleLeft;
            btnModificarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificarEntrega.UseVisualStyleBackColor = false;
            btnModificarEntrega.Click += btnModificarEntrega_Click;
            // 
            // btnAgregarEntrega
            // 
            btnAgregarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEntrega.BackColor = Color.FromArgb(89, 134, 213);
            btnAgregarEntrega.FlatAppearance.BorderSize = 0;
            btnAgregarEntrega.FlatStyle = FlatStyle.Flat;
            btnAgregarEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarEntrega.ForeColor = Color.FromArgb(31, 35, 40);
            btnAgregarEntrega.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregarEntrega.IconColor = Color.FromArgb(31, 35, 40);
            btnAgregarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarEntrega.IconSize = 20;
            btnAgregarEntrega.Location = new Point(711, 86);
            btnAgregarEntrega.Name = "btnAgregarEntrega";
            btnAgregarEntrega.RightToLeft = RightToLeft.No;
            btnAgregarEntrega.Size = new Size(156, 50);
            btnAgregarEntrega.TabIndex = 2;
            btnAgregarEntrega.Text = "AGREGAR";
            btnAgregarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarEntrega.UseVisualStyleBackColor = false;
            btnAgregarEntrega.Click += btnAgregarEntrega_Click;
            // 
            // dgvEntregas
            // 
            dgvEntregas.AllowUserToAddRows = false;
            dgvEntregas.AllowUserToDeleteRows = false;
            dgvEntregas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEntregas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvEntregas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvEntregas.BackgroundColor = Color.FromArgb(148, 184, 216);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEntregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEntregas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEntregas.Location = new Point(6, 67);
            dgvEntregas.Name = "dgvEntregas";
            dgvEntregas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEntregas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEntregas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEntregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvEntregas.DefaultCellStyle = dataGridViewCellStyle6;
            dgvEntregas.Location = new Point(12, 86);
            dgvEntregas.Name = "dgvEntregas";
            dgvEntregas.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvEntregas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvEntregas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvEntregas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntregas.Size = new Size(693, 417);
            dgvEntregas.TabIndex = 11;
            dgvEntregas.SelectionChanged += dgvEntregas_SelectionChanged;
            // 
            // gbBusarEmpleado
            // 
            gbBusarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBusarEmpleado.Controls.Add(cBoxTipoBusqueda);
            gbBusarEmpleado.Controls.Add(txtBuscarEntrega);
            gbBusarEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbBusarEmpleado.Location = new Point(12, 12);
            gbBusarEmpleado.Name = "gbBusarEmpleado";
            gbBusarEmpleado.Size = new Size(693, 68);
            gbBusarEmpleado.TabIndex = 10;
            gbBusarEmpleado.TabStop = false;
            gbBusarEmpleado.Text = "BUSCAR ENTREGA::...";
            // 
            // cBoxTipoBusqueda
            // 
            cBoxTipoBusqueda.AutoCompleteMode = AutoCompleteMode.Append;
            cBoxTipoBusqueda.AutoCompleteSource = AutoCompleteSource.ListItems;
            cBoxTipoBusqueda.Font = new Font("Segoe UI", 9F);
            cBoxTipoBusqueda.FormattingEnabled = true;
            cBoxTipoBusqueda.Location = new Point(6, 26);
            cBoxTipoBusqueda.Name = "cBoxTipoBusqueda";
            cBoxTipoBusqueda.Size = new Size(122, 23);
            cBoxTipoBusqueda.TabIndex = 0;
            cBoxTipoBusqueda.TextChanged += cBoxTipoBusqueda_TextChanged;
            // 
            // txtBuscarEntrega
            // 
            txtBuscarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarEntrega.Font = new Font("Segoe UI", 9F);
            txtBuscarEntrega.Location = new Point(134, 26);
            txtBuscarEntrega.Name = "txtBuscarEntrega";
            txtBuscarEntrega.Size = new Size(553, 23);
            txtBuscarEntrega.TabIndex = 1;
            txtBuscarEntrega.TextChanged += txtBuscarEntrega_TextChanged;
            // 
            // btnGenerarDevolucion
            // 
            btnGenerarDevolucion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerarDevolucion.BackColor = Color.FromArgb(77, 77, 77);
            btnGenerarDevolucion.FlatAppearance.BorderSize = 0;
            btnGenerarDevolucion.FlatStyle = FlatStyle.Flat;
            btnGenerarDevolucion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerarDevolucion.ForeColor = Color.White;
            btnGenerarDevolucion.IconChar = FontAwesome.Sharp.IconChar.RotateBack;
            btnGenerarDevolucion.IconColor = Color.White;
            btnGenerarDevolucion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarDevolucion.IconSize = 20;
            btnGenerarDevolucion.Location = new Point(711, 203);
            btnGenerarDevolucion.Name = "btnGenerarDevolucion";
            btnGenerarDevolucion.Size = new Size(156, 57);
            btnGenerarDevolucion.TabIndex = 4;
            btnGenerarDevolucion.Text = "DEVOLUCIÓN";
            btnGenerarDevolucion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerarDevolucion.UseVisualStyleBackColor = false;
            btnGenerarDevolucion.Click += btnGenerarDevolucion_Click;
            // 
            // frmEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(879, 515);
            Controls.Add(btnGenerarDevolucion);
            Controls.Add(btnEliminarEntrega);
            Controls.Add(btnModificarEntrega);
            Controls.Add(btnAgregarEntrega);
            Controls.Add(dgvEntregas);
            Controls.Add(gbBusarEmpleado);
            Name = "frmEntrega";
            Text = "ENTREGAS";
            Load += frmEntrega_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).EndInit();
            gbBusarEmpleado.ResumeLayout(false);
            gbBusarEmpleado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEliminarEntrega;
        private FontAwesome.Sharp.IconButton btnModificarEntrega;
        private FontAwesome.Sharp.IconButton btnAgregarEntrega;
        private DataGridView dgvEntregas;
        private GroupBox gbBusarEmpleado;
        private TextBox txtBuscarEntrega;
        private ComboBox cBoxTipoBusqueda;
        private FontAwesome.Sharp.IconButton btnGenerarDevolucion;
    }
}