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
            txtBuscarEmpleado = new TextBox();
            btnBuscarEmpleado = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            pDerechoEmpleado = new Panel();
            btnAgregarEmpleado = new FontAwesome.Sharp.IconButton();
            btnModificaEmpleado = new FontAwesome.Sharp.IconButton();
            btnEliminarEmpleado = new FontAwesome.Sharp.IconButton();
            gbBusarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbBusarEmpleado
            // 
            gbBusarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBusarEmpleado.Controls.Add(txtBuscarEmpleado);
            gbBusarEmpleado.Controls.Add(btnBuscarEmpleado);
            gbBusarEmpleado.Location = new Point(12, 25);
            gbBusarEmpleado.Name = "gbBusarEmpleado";
            gbBusarEmpleado.Size = new Size(810, 56);
            gbBusarEmpleado.TabIndex = 0;
            gbBusarEmpleado.TabStop = false;
            gbBusarEmpleado.Text = "EMPLEADO::...";
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarEmpleado.Location = new Point(64, 26);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(740, 23);
            txtBuscarEmpleado.TabIndex = 5;
            // 
            // btnBuscarEmpleado
            // 
            btnBuscarEmpleado.BackColor = Color.FromArgb(219, 231, 242);
            btnBuscarEmpleado.FlatAppearance.BorderSize = 0;
            btnBuscarEmpleado.FlatStyle = FlatStyle.Flat;
            btnBuscarEmpleado.ForeColor = SystemColors.ControlLightLight;
            btnBuscarEmpleado.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarEmpleado.IconColor = Color.FromArgb(31, 35, 40);
            btnBuscarEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarEmpleado.IconSize = 30;
            btnBuscarEmpleado.Location = new Point(6, 22);
            btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            btnBuscarEmpleado.Size = new Size(52, 28);
            btnBuscarEmpleado.TabIndex = 4;
            btnBuscarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarEmpleado.UseVisualStyleBackColor = false;
            btnBuscarEmpleado.Click += btnMaximizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(148, 184, 216);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(932, 373);
            dataGridView1.TabIndex = 1;
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
            Controls.Add(dataGridView1);
            Controls.Add(gbBusarEmpleado);
            Name = "frmEmpleado";
            Text = "EMPLEADO";
            Load += frmEmpleado_Load;
            gbBusarEmpleado.ResumeLayout(false);
            gbBusarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbBusarEmpleado;
        private FontAwesome.Sharp.IconButton btnBuscarEmpleado;
        private TextBox txtBuscarEmpleado;
        private DataGridView dataGridView1;
        private Panel pDerechoEmpleado;
        private FontAwesome.Sharp.IconButton btnAgregarEmpleado;
        private FontAwesome.Sharp.IconButton btnModificaEmpleado;
        private FontAwesome.Sharp.IconButton btnEliminarEmpleado;
    }
}