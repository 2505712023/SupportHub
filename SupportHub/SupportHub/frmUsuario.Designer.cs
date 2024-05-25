namespace Presentacion
{
    partial class frmUsuario
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
            btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            btnModificaUsuario = new FontAwesome.Sharp.IconButton();
            btnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            dgvUsuario = new DataGridView();
            gbBuscarUsuario = new GroupBox();
            cbxTipoBusquedaUsuario = new ComboBox();
            txtBuscarUsuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            gbBuscarUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarUsuario.BackColor = Color.FromArgb(184, 82, 82);
            btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            btnEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminarUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            btnEliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarUsuario.IconColor = Color.FromArgb(31, 35, 40);
            btnEliminarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarUsuario.IconSize = 20;
            btnEliminarUsuario.Location = new Point(769, 295);
            btnEliminarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(178, 76);
            btnEliminarUsuario.TabIndex = 12;
            btnEliminarUsuario.Text = "ELIMINAR";
            btnEliminarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click_1;
            // 
            // btnModificaUsuario
            // 
            btnModificaUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificaUsuario.BackColor = Color.FromArgb(55, 166, 104);
            btnModificaUsuario.FlatAppearance.BorderSize = 0;
            btnModificaUsuario.FlatStyle = FlatStyle.Flat;
            btnModificaUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnModificaUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            btnModificaUsuario.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            btnModificaUsuario.IconColor = Color.FromArgb(31, 35, 40);
            btnModificaUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificaUsuario.IconSize = 20;
            btnModificaUsuario.Location = new Point(769, 214);
            btnModificaUsuario.Margin = new Padding(3, 4, 3, 4);
            btnModificaUsuario.Name = "btnModificaUsuario";
            btnModificaUsuario.Size = new Size(178, 74);
            btnModificaUsuario.TabIndex = 11;
            btnModificaUsuario.Text = "MODIFICAR";
            btnModificaUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificaUsuario.UseVisualStyleBackColor = false;
            btnModificaUsuario.Click += btnModificaUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarUsuario.BackColor = Color.FromArgb(89, 134, 213);
            btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregarUsuario.ForeColor = Color.FromArgb(31, 35, 40);
            btnAgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregarUsuario.IconColor = Color.FromArgb(31, 35, 40);
            btnAgregarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarUsuario.IconSize = 20;
            btnAgregarUsuario.Location = new Point(769, 139);
            btnAgregarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(178, 68);
            btnAgregarUsuario.TabIndex = 10;
            btnAgregarUsuario.Text = "AGREGAR";
            btnAgregarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvUsuario.BackgroundColor = Color.FromArgb(148, 184, 216);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuario.Location = new Point(2, 112);
            dgvUsuario.Margin = new Padding(3, 4, 3, 4);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(876, 296);
            dgvUsuario.TabIndex = 15;
            dgvUsuario.CellContentClick += dgvUsuario_CellContentClick;
            // 
            // gbBuscarUsuario
            // 
            gbBuscarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBuscarUsuario.Controls.Add(cbxTipoBusquedaUsuario);
            gbBuscarUsuario.Controls.Add(txtBuscarUsuario);
            gbBuscarUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbBuscarUsuario.Location = new Point(13, 13);
            gbBuscarUsuario.Margin = new Padding(3, 4, 3, 4);
            gbBuscarUsuario.Name = "gbBuscarUsuario";
            gbBuscarUsuario.Padding = new Padding(3, 4, 3, 4);
            gbBuscarUsuario.Size = new Size(924, 91);
            gbBuscarUsuario.TabIndex = 14;
            gbBuscarUsuario.TabStop = false;
            gbBuscarUsuario.Text = "BUSCAR USUARIO::...";
            gbBuscarUsuario.UseCompatibleTextRendering = true;
            // 
            // cbxTipoBusquedaUsuario
            // 
            cbxTipoBusquedaUsuario.Font = new Font("Segoe UI", 9F);
            cbxTipoBusquedaUsuario.FormattingEnabled = true;
            cbxTipoBusquedaUsuario.Location = new Point(7, 35);
            cbxTipoBusquedaUsuario.Margin = new Padding(3, 4, 3, 4);
            cbxTipoBusquedaUsuario.Name = "cbxTipoBusquedaUsuario";
            cbxTipoBusquedaUsuario.Size = new Size(158, 23);
            cbxTipoBusquedaUsuario.TabIndex = 6;
            cbxTipoBusquedaUsuario.SelectedIndexChanged += cbxTipoBusquedaUsuario_SelectedIndexChanged;
            cbxTipoBusquedaUsuario.TextChanged += cbxTipoBusquedaUsuario_TextChanged;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarUsuario.Font = new Font("Segoe UI", 9F);
            txtBuscarUsuario.Location = new Point(174, 36);
            txtBuscarUsuario.Margin = new Padding(3, 4, 3, 4);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(746, 23);
            txtBuscarUsuario.TabIndex = 5;
            txtBuscarUsuario.TextChanged += txtBuscarUsuario_TextChanged;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(959, 449);
            Controls.Add(dgvUsuario);
            Controls.Add(gbBuscarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnModificaUsuario);
            Controls.Add(btnAgregarUsuario);
            Name = "frmUsuario";
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            gbBuscarUsuario.ResumeLayout(false);
            gbBuscarUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private FontAwesome.Sharp.IconButton btnModificaUsuario;
        private FontAwesome.Sharp.IconButton btnAgregarUsuario;
        private DataGridView dgvUsuario;
        private GroupBox gbBuscarUsuario;
        private ComboBox cbxTipoBusquedaUsuario;
        private TextBox txtBuscarUsuario;
    }
}