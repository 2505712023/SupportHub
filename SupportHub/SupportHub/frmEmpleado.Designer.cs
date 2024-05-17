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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            gbBusarEmpleado = new GroupBox();
            cbxTipoBusquedaEmpleado = new ComboBox();
            txtBuscarEmpleado = new TextBox();
            dgvEmpleado = new DataGridView();
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
            gbBusarEmpleado.Location = new Point(14, 16);
            gbBusarEmpleado.Margin = new Padding(3, 4, 3, 4);
            gbBusarEmpleado.Name = "gbBusarEmpleado";
            gbBusarEmpleado.Padding = new Padding(3, 4, 3, 4);
            gbBusarEmpleado.Size = new Size(1080, 91);
            gbBusarEmpleado.TabIndex = 0;
            gbBusarEmpleado.TabStop = false;
            gbBusarEmpleado.Text = "BUSCAR EMPLEADO::...";
            // 
            // cbxTipoBusquedaEmpleado
            // 
            cbxTipoBusquedaEmpleado.Font = new Font("Segoe UI", 9F);
            cbxTipoBusquedaEmpleado.FormattingEnabled = true;
            cbxTipoBusquedaEmpleado.Location = new Point(7, 35);
            cbxTipoBusquedaEmpleado.Margin = new Padding(3, 4, 3, 4);
            cbxTipoBusquedaEmpleado.Name = "cbxTipoBusquedaEmpleado";
            cbxTipoBusquedaEmpleado.Size = new Size(158, 28);
            cbxTipoBusquedaEmpleado.TabIndex = 6;
            cbxTipoBusquedaEmpleado.SelectedIndexChanged += cbxTipoBusquedaEmpleado_SelectedIndexChanged;
            cbxTipoBusquedaEmpleado.TextChanged += cbxTipoBusquedaEmpleado_TextChanged;
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarEmpleado.Font = new Font("Segoe UI", 9F);
            txtBuscarEmpleado.Location = new Point(173, 35);
            txtBuscarEmpleado.Margin = new Padding(3, 4, 3, 4);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(900, 27);
            txtBuscarEmpleado.TabIndex = 5;
            txtBuscarEmpleado.TextChanged += txtBuscarEmpleado_TextChanged;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.AllowUserToAddRows = false;
            dgvEmpleado.AllowUserToDeleteRows = false;
            dgvEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvEmpleado.BackgroundColor = Color.FromArgb(148, 184, 216);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleado.Location = new Point(14, 115);
            dgvEmpleado.Margin = new Padding(3, 4, 3, 4);
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.ReadOnly = true;
            dgvEmpleado.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleado.Size = new Size(1080, 556);
            dgvEmpleado.TabIndex = 1;
            dgvEmpleado.CellContentClick += dgvEmpleado_CellContentClick;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEmpleado.BackColor = Color.FromArgb(89, 134, 213);
            btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            btnAgregarEmpleado.FlatStyle = FlatStyle.Flat;
            btnAgregarEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarEmpleado.ForeColor = Color.FromArgb(31, 35, 40);
            btnAgregarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregarEmpleado.IconColor = Color.FromArgb(31, 35, 40);
            btnAgregarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarEmpleado.IconSize = 20;
            btnAgregarEmpleado.Location = new Point(1101, 157);
            btnAgregarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(178, 67);
            btnAgregarEmpleado.TabIndex = 7;
            btnAgregarEmpleado.Text = "AGREGAR";
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
            btnModificaEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnModificaEmpleado.ForeColor = Color.FromArgb(31, 35, 40);
            btnModificaEmpleado.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            btnModificaEmpleado.IconColor = Color.FromArgb(31, 35, 40);
            btnModificaEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificaEmpleado.IconSize = 20;
            btnModificaEmpleado.Location = new Point(1101, 232);
            btnModificaEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnModificaEmpleado.Name = "btnModificaEmpleado";
            btnModificaEmpleado.Size = new Size(178, 73);
            btnModificaEmpleado.TabIndex = 8;
            btnModificaEmpleado.Text = "MODIFICAR";
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
            btnEliminarEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminarEmpleado.ForeColor = Color.FromArgb(31, 35, 40);
            btnEliminarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarEmpleado.IconColor = Color.FromArgb(31, 35, 40);
            btnEliminarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarEmpleado.IconSize = 20;
            btnEliminarEmpleado.Location = new Point(1101, 313);
            btnEliminarEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(178, 76);
            btnEliminarEmpleado.TabIndex = 9;
            btnEliminarEmpleado.Text = "ELIMINAR";
            btnEliminarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarEmpleado.UseVisualStyleBackColor = false;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1293, 687);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(btnModificaEmpleado);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(dgvEmpleado);
            Controls.Add(gbBusarEmpleado);
            Margin = new Padding(3, 4, 3, 4);
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
        private FontAwesome.Sharp.IconButton btnAgregarEmpleado;
        private FontAwesome.Sharp.IconButton btnModificaEmpleado;
        private FontAwesome.Sharp.IconButton btnEliminarEmpleado;
        private ComboBox cbxTipoBusquedaEmpleado;
    }
}