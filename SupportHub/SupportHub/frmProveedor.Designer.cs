namespace Presentacion
{
    partial class frmProveedor
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
            dgvProveedor = new DataGridView();
            gbBuscarProveedor = new GroupBox();
            cbxTipoBusquedaProveedor = new ComboBox();
            txtBuscarProveedor = new TextBox();
            btnAgregarProveedor = new FontAwesome.Sharp.IconButton();
            btnModificaProveedor = new FontAwesome.Sharp.IconButton();
            btnEliminarProveedor = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            gbBuscarProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProveedor
            // 
            dgvProveedor.AllowUserToAddRows = false;
            dgvProveedor.AllowUserToDeleteRows = false;
            dgvProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvProveedor.BackgroundColor = Color.FromArgb(148, 184, 216);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedor.Location = new Point(12, 86);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedor.Size = new Size(721, 417);
            dgvProveedor.TabIndex = 2;
            // 
            // gbBuscarProveedor
            // 
            gbBuscarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBuscarProveedor.Controls.Add(cbxTipoBusquedaProveedor);
            gbBuscarProveedor.Controls.Add(txtBuscarProveedor);
            gbBuscarProveedor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbBuscarProveedor.Location = new Point(12, 12);
            gbBuscarProveedor.Name = "gbBuscarProveedor";
            gbBuscarProveedor.Size = new Size(721, 68);
            gbBuscarProveedor.TabIndex = 3;
            gbBuscarProveedor.TabStop = false;
            gbBuscarProveedor.Text = "BUSCAR PROVEEDOR::...";
            // 
            // cbxTipoBusquedaProveedor
            // 
            cbxTipoBusquedaProveedor.Cursor = Cursors.Hand;
            cbxTipoBusquedaProveedor.Font = new Font("Segoe UI", 9F);
            cbxTipoBusquedaProveedor.FormattingEnabled = true;
            cbxTipoBusquedaProveedor.Location = new Point(6, 26);
            cbxTipoBusquedaProveedor.Name = "cbxTipoBusquedaProveedor";
            cbxTipoBusquedaProveedor.Size = new Size(125, 23);
            cbxTipoBusquedaProveedor.TabIndex = 6;
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarProveedor.Cursor = Cursors.IBeam;
            txtBuscarProveedor.Font = new Font("Segoe UI", 9F);
            txtBuscarProveedor.Location = new Point(137, 26);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(578, 23);
            txtBuscarProveedor.TabIndex = 5;
            txtBuscarProveedor.TextChanged += txtBuscarProveedor_TextChanged;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarProveedor.BackColor = Color.FromArgb(89, 134, 213);
            btnAgregarProveedor.Cursor = Cursors.Hand;
            btnAgregarProveedor.FlatAppearance.BorderSize = 0;
            btnAgregarProveedor.FlatStyle = FlatStyle.Flat;
            btnAgregarProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarProveedor.ForeColor = Color.FromArgb(31, 35, 40);
            btnAgregarProveedor.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregarProveedor.IconColor = Color.FromArgb(31, 35, 40);
            btnAgregarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProveedor.IconSize = 20;
            btnAgregarProveedor.Location = new Point(739, 86);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(156, 50);
            btnAgregarProveedor.TabIndex = 8;
            btnAgregarProveedor.Text = "AGREGAR";
            btnAgregarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // btnModificaProveedor
            // 
            btnModificaProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificaProveedor.BackColor = Color.FromArgb(55, 166, 104);
            btnModificaProveedor.Cursor = Cursors.Hand;
            btnModificaProveedor.FlatAppearance.BorderSize = 0;
            btnModificaProveedor.FlatStyle = FlatStyle.Flat;
            btnModificaProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnModificaProveedor.ForeColor = Color.FromArgb(31, 35, 40);
            btnModificaProveedor.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            btnModificaProveedor.IconColor = Color.FromArgb(31, 35, 40);
            btnModificaProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificaProveedor.IconSize = 20;
            btnModificaProveedor.Location = new Point(739, 142);
            btnModificaProveedor.Name = "btnModificaProveedor";
            btnModificaProveedor.Size = new Size(156, 55);
            btnModificaProveedor.TabIndex = 10;
            btnModificaProveedor.Text = "MODIFICAR";
            btnModificaProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificaProveedor.UseVisualStyleBackColor = false;
            btnModificaProveedor.Click += btnModificaProveedor_Click;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarProveedor.BackColor = Color.FromArgb(184, 82, 82);
            btnEliminarProveedor.Cursor = Cursors.Hand;
            btnEliminarProveedor.FlatAppearance.BorderSize = 0;
            btnEliminarProveedor.FlatStyle = FlatStyle.Flat;
            btnEliminarProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminarProveedor.ForeColor = Color.FromArgb(31, 35, 40);
            btnEliminarProveedor.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarProveedor.IconColor = Color.FromArgb(31, 35, 40);
            btnEliminarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarProveedor.IconSize = 20;
            btnEliminarProveedor.Location = new Point(739, 203);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(156, 57);
            btnEliminarProveedor.TabIndex = 11;
            btnEliminarProveedor.Text = "ELIMINAR";
            btnEliminarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarProveedor.UseVisualStyleBackColor = false;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // frmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(907, 515);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(btnModificaProveedor);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(gbBuscarProveedor);
            Controls.Add(dgvProveedor);
            Name = "frmProveedor";
            Text = "PROVEEDOR";
            Load += frmProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            gbBuscarProveedor.ResumeLayout(false);
            gbBuscarProveedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProveedor;
        private GroupBox gbBuscarProveedor;
        private ComboBox cbxTipoBusquedaProveedor;
        private TextBox txtBuscarProveedor;
        private FontAwesome.Sharp.IconButton btnAgregarProveedor;
        private FontAwesome.Sharp.IconButton btnModificaProveedor;
        private FontAwesome.Sharp.IconButton btnEliminarProveedor;
    }
}