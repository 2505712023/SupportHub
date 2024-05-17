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
<<<<<<< Updated upstream
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnEliminarUsuario = new FontAwesome.Sharp.IconButton();
            btnModificaUsuario = new FontAwesome.Sharp.IconButton();
            btnAgregarUsuario = new FontAwesome.Sharp.IconButton();
            dgvUsuario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
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
            btnEliminarUsuario.Location = new Point(1103, 233);
            btnEliminarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(178, 76);
            btnEliminarUsuario.TabIndex = 12;
            btnEliminarUsuario.Text = "ELIMINAR";
            btnEliminarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarUsuario.UseVisualStyleBackColor = false;
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
            btnModificaUsuario.Location = new Point(1103, 152);
            btnModificaUsuario.Margin = new Padding(3, 4, 3, 4);
            btnModificaUsuario.Name = "btnModificaUsuario";
            btnModificaUsuario.Size = new Size(178, 73);
            btnModificaUsuario.TabIndex = 11;
            btnModificaUsuario.Text = "MODIFICAR";
            btnModificaUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificaUsuario.UseVisualStyleBackColor = false;
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
            btnAgregarUsuario.Location = new Point(1103, 77);
            btnAgregarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(178, 67);
            btnAgregarUsuario.TabIndex = 10;
            btnAgregarUsuario.Text = "AGREGAR";
            btnAgregarUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToAddRows = false;
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvUsuario.BackgroundColor = Color.FromArgb(148, 184, 216);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvUsuario.DefaultCellStyle = dataGridViewCellStyle5;
            dgvUsuario.Location = new Point(14, 115);
            dgvUsuario.Margin = new Padding(3, 4, 3, 4);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.Size = new Size(1080, 556);
            dgvUsuario.TabIndex = 13;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1293, 687);
            Controls.Add(dgvUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnModificaUsuario);
            Controls.Add(btnAgregarUsuario);
            Name = "frmUsuario";
            Text = "frmUsuario";
            Load += frmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
=======
            btnagregarusuario = new Button();
            btnmodificarusuario = new Button();
            btnEliminarusuario = new Button();
            SuspendLayout();
            // 
            // btnagregarusuario
            // 
            btnagregarusuario.Location = new Point(727, 52);
            btnagregarusuario.Name = "btnagregarusuario";
            btnagregarusuario.Size = new Size(112, 34);
            btnagregarusuario.TabIndex = 0;
            btnagregarusuario.Text = "Agregar";
            btnagregarusuario.UseVisualStyleBackColor = true;
            btnagregarusuario.Click += btnagregarusuario_Click;
            // 
            // btnmodificarusuario
            // 
            btnmodificarusuario.Location = new Point(727, 138);
            btnmodificarusuario.Name = "btnmodificarusuario";
            btnmodificarusuario.Size = new Size(112, 34);
            btnmodificarusuario.TabIndex = 1;
            btnmodificarusuario.Text = "Editar";
            btnmodificarusuario.UseVisualStyleBackColor = true;
            btnmodificarusuario.Click += btnmodificarusuario_Click;
            // 
            // btnEliminarusuario
            // 
            btnEliminarusuario.Location = new Point(727, 247);
            btnEliminarusuario.Name = "btnEliminarusuario";
            btnEliminarusuario.Size = new Size(112, 34);
            btnEliminarusuario.TabIndex = 2;
            btnEliminarusuario.Text = "Eliminar";
            btnEliminarusuario.UseVisualStyleBackColor = true;
            btnEliminarusuario.Click += btnEliminarusuario_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 667);
            Controls.Add(btnEliminarusuario);
            Controls.Add(btnmodificarusuario);
            Controls.Add(btnagregarusuario);
            Name = "frmUsuario";
            Text = "frmUsuario";
>>>>>>> Stashed changes
            ResumeLayout(false);
        }

        #endregion

<<<<<<< Updated upstream
        private FontAwesome.Sharp.IconButton btnEliminarUsuario;
        private FontAwesome.Sharp.IconButton btnModificaUsuario;
        private FontAwesome.Sharp.IconButton btnAgregarUsuario;
        private DataGridView dgvUsuario;
=======
        private Button btnagregarusuario;
        private Button btnmodificarusuario;
        private Button btnEliminarusuario;
>>>>>>> Stashed changes
    }
}