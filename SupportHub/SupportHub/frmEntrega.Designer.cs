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
            btnEliminarEntrega = new FontAwesome.Sharp.IconButton();
            btnModificarEntrega = new FontAwesome.Sharp.IconButton();
            btnAgregarEntrega = new FontAwesome.Sharp.IconButton();
            dgvEntregas = new DataGridView();
            gbBusarEmpleado = new GroupBox();
            txtBuscarEntrega = new TextBox();
            btnBuscarEntrega = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvEntregas).BeginInit();
            gbBusarEmpleado.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminarEntrega
            // 
            btnEliminarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminarEntrega.AutoSize = true;
            btnEliminarEntrega.BackColor = Color.FromArgb(184, 82, 82);
            btnEliminarEntrega.FlatAppearance.BorderSize = 0;
            btnEliminarEntrega.FlatStyle = FlatStyle.Flat;
            btnEliminarEntrega.ForeColor = Color.FromArgb(31, 35, 40);
            btnEliminarEntrega.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminarEntrega.IconColor = Color.FromArgb(31, 35, 40);
            btnEliminarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarEntrega.IconSize = 20;
            btnEliminarEntrega.Location = new Point(963, 235);
            btnEliminarEntrega.Name = "btnEliminarEntrega";
            btnEliminarEntrega.Size = new Size(156, 57);
            btnEliminarEntrega.TabIndex = 14;
            btnEliminarEntrega.Text = "ELIMINAR";
            btnEliminarEntrega.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarEntrega.UseVisualStyleBackColor = false;
            // 
            // btnModificarEntrega
            // 
            btnModificarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificarEntrega.AutoSize = true;
            btnModificarEntrega.BackColor = Color.FromArgb(55, 166, 104);
            btnModificarEntrega.FlatAppearance.BorderSize = 0;
            btnModificarEntrega.FlatStyle = FlatStyle.Flat;
            btnModificarEntrega.ForeColor = Color.FromArgb(31, 35, 40);
            btnModificarEntrega.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            btnModificarEntrega.IconColor = Color.FromArgb(31, 35, 40);
            btnModificarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificarEntrega.IconSize = 20;
            btnModificarEntrega.Location = new Point(963, 174);
            btnModificarEntrega.Name = "btnModificarEntrega";
            btnModificarEntrega.Size = new Size(156, 55);
            btnModificarEntrega.TabIndex = 13;
            btnModificarEntrega.Text = "MODIFICAR";
            btnModificarEntrega.TextAlign = ContentAlignment.MiddleLeft;
            btnModificarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificarEntrega.UseVisualStyleBackColor = false;
            // 
            // btnAgregarEntrega
            // 
            btnAgregarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEntrega.AutoSize = true;
            btnAgregarEntrega.BackColor = Color.FromArgb(89, 134, 213);
            btnAgregarEntrega.FlatAppearance.BorderSize = 0;
            btnAgregarEntrega.FlatStyle = FlatStyle.Flat;
            btnAgregarEntrega.ForeColor = Color.FromArgb(31, 35, 40);
            btnAgregarEntrega.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnAgregarEntrega.IconColor = Color.FromArgb(31, 35, 40);
            btnAgregarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarEntrega.IconSize = 20;
            btnAgregarEntrega.Location = new Point(963, 118);
            btnAgregarEntrega.Name = "btnAgregarEntrega";
            btnAgregarEntrega.RightToLeft = RightToLeft.No;
            btnAgregarEntrega.Size = new Size(156, 50);
            btnAgregarEntrega.TabIndex = 12;
            btnAgregarEntrega.Text = "AGREGAR";
            btnAgregarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarEntrega.UseVisualStyleBackColor = false;
            // 
            // dgvEntregas
            // 
            dgvEntregas.AllowUserToAddRows = false;
            dgvEntregas.AllowUserToDeleteRows = false;
            dgvEntregas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEntregas.BackgroundColor = Color.FromArgb(148, 184, 216);
            dgvEntregas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntregas.Location = new Point(12, 86);
            dgvEntregas.Name = "dgvEntregas";
            dgvEntregas.ReadOnly = true;
            dgvEntregas.Size = new Size(945, 417);
            dgvEntregas.TabIndex = 11;
            // 
            // gbBusarEmpleado
            // 
            gbBusarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBusarEmpleado.Controls.Add(txtBuscarEntrega);
            gbBusarEmpleado.Controls.Add(btnBuscarEntrega);
            gbBusarEmpleado.Location = new Point(12, 12);
            gbBusarEmpleado.Name = "gbBusarEmpleado";
            gbBusarEmpleado.Size = new Size(945, 68);
            gbBusarEmpleado.TabIndex = 10;
            gbBusarEmpleado.TabStop = false;
            gbBusarEmpleado.Text = "ENTREGA::...";
            // 
            // txtBuscarEntrega
            // 
            txtBuscarEntrega.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarEntrega.Location = new Point(64, 26);
            txtBuscarEntrega.Name = "txtBuscarEntrega";
            txtBuscarEntrega.Size = new Size(875, 23);
            txtBuscarEntrega.TabIndex = 5;
            txtBuscarEntrega.TextChanged += txtBuscarEntrega_TextChanged;
            // 
            // btnBuscarEntrega
            // 
            btnBuscarEntrega.BackColor = Color.FromArgb(219, 231, 242);
            btnBuscarEntrega.FlatAppearance.BorderSize = 0;
            btnBuscarEntrega.FlatStyle = FlatStyle.Flat;
            btnBuscarEntrega.ForeColor = SystemColors.ControlLightLight;
            btnBuscarEntrega.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarEntrega.IconColor = Color.FromArgb(31, 35, 40);
            btnBuscarEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarEntrega.IconSize = 30;
            btnBuscarEntrega.Location = new Point(6, 22);
            btnBuscarEntrega.Name = "btnBuscarEntrega";
            btnBuscarEntrega.Size = new Size(52, 28);
            btnBuscarEntrega.TabIndex = 4;
            btnBuscarEntrega.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarEntrega.UseVisualStyleBackColor = false;
            // 
            // frmEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1131, 515);
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
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEliminarEntrega;
        private FontAwesome.Sharp.IconButton btnModificarEntrega;
        private FontAwesome.Sharp.IconButton btnAgregarEntrega;
        private DataGridView dgvEntregas;
        private GroupBox gbBusarEmpleado;
        private TextBox txtBuscarEntrega;
        private FontAwesome.Sharp.IconButton btnBuscarEntrega;
    }
}