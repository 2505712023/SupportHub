namespace Presentacion
{
    partial class frmInformacion
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
            pDerechoInformacion = new Panel();
            gbMiInformacion = new GroupBox();
            lblUsuario = new Label();
            lblNombreUsuario = new Label();
            lblApellidoUsuario = new Label();
            lblID = new Label();
            lblUser = new Label();
            lblIdInfo = new Label();
            lblNombreInfo = new Label();
            lblApellidoInfor = new Label();
            linkEditar = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            pDerechoInformacion.SuspendLayout();
            gbMiInformacion.SuspendLayout();
            SuspendLayout();
            // 
            // pDerechoInformacion
            // 
            pDerechoInformacion.Controls.Add(panel1);
            pDerechoInformacion.Dock = DockStyle.Right;
            pDerechoInformacion.Location = new Point(1062, 0);
            pDerechoInformacion.Name = "pDerechoInformacion";
            pDerechoInformacion.Size = new Size(99, 515);
            pDerechoInformacion.TabIndex = 8;
            // 
            // gbMiInformacion
            // 
            gbMiInformacion.Controls.Add(linkEditar);
            gbMiInformacion.Controls.Add(lblApellidoInfor);
            gbMiInformacion.Controls.Add(lblNombreInfo);
            gbMiInformacion.Controls.Add(lblIdInfo);
            gbMiInformacion.Controls.Add(lblUser);
            gbMiInformacion.Controls.Add(lblID);
            gbMiInformacion.Controls.Add(lblApellidoUsuario);
            gbMiInformacion.Controls.Add(lblNombreUsuario);
            gbMiInformacion.Controls.Add(lblUsuario);
            gbMiInformacion.Location = new Point(12, 12);
            gbMiInformacion.Name = "gbMiInformacion";
            gbMiInformacion.Size = new Size(632, 482);
            gbMiInformacion.TabIndex = 9;
            gbMiInformacion.TabStop = false;
            gbMiInformacion.Text = "MI INFORMACIÓN";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(8, 119);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(113, 30);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "USUARIO:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(6, 196);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(242, 30);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "NOMBRE DE USUARIO:";
            // 
            // lblApellidoUsuario
            // 
            lblApellidoUsuario.AutoSize = true;
            lblApellidoUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellidoUsuario.Location = new Point(6, 280);
            lblApellidoUsuario.Name = "lblApellidoUsuario";
            lblApellidoUsuario.Size = new Size(250, 30);
            lblApellidoUsuario.TabIndex = 2;
            lblApellidoUsuario.Text = "APELLIDO DE USUARIO:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(8, 40);
            lblID.Name = "lblID";
            lblID.Size = new Size(41, 30);
            lblID.TabIndex = 3;
            lblID.Text = "ID:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(8, 159);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(29, 15);
            lblUser.TabIndex = 4;
            lblUser.Text = "user";
            // 
            // lblIdInfo
            // 
            lblIdInfo.AutoSize = true;
            lblIdInfo.Location = new Point(8, 86);
            lblIdInfo.Name = "lblIdInfo";
            lblIdInfo.Size = new Size(17, 15);
            lblIdInfo.TabIndex = 5;
            lblIdInfo.Text = "id";
            // 
            // lblNombreInfo
            // 
            lblNombreInfo.AutoSize = true;
            lblNombreInfo.Location = new Point(8, 238);
            lblNombreInfo.Name = "lblNombreInfo";
            lblNombreInfo.Size = new Size(49, 15);
            lblNombreInfo.TabIndex = 6;
            lblNombreInfo.Text = "nombre";
            // 
            // lblApellidoInfor
            // 
            lblApellidoInfor.AutoSize = true;
            lblApellidoInfor.Location = new Point(8, 338);
            lblApellidoInfor.Name = "lblApellidoInfor";
            lblApellidoInfor.Size = new Size(49, 15);
            lblApellidoInfor.TabIndex = 7;
            lblApellidoInfor.Text = "apellido";
            // 
            // linkEditar
            // 
            linkEditar.AutoSize = true;
            linkEditar.Location = new Point(164, 379);
            linkEditar.Name = "linkEditar";
            linkEditar.Size = new Size(84, 15);
            linkEditar.TabIndex = 8;
            linkEditar.TabStop = true;
            linkEditar.Text = "Editar mi Perfil";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(99, 515);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 23, 59);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(660, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 515);
            panel2.TabIndex = 10;
            // 
            // frmInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 184, 216);
            ClientSize = new Size(1161, 515);
            Controls.Add(panel2);
            Controls.Add(gbMiInformacion);
            Controls.Add(pDerechoInformacion);
            Name = "frmInformacion";
            Text = "frmInformacion";
            pDerechoInformacion.ResumeLayout(false);
            gbMiInformacion.ResumeLayout(false);
            gbMiInformacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pDerechoInformacion;
        private GroupBox gbMiInformacion;
        private Label lblApellidoUsuario;
        private Label lblNombreUsuario;
        private Label lblUsuario;
        private Label lblApellidoInfor;
        private Label lblNombreInfo;
        private Label lblIdInfo;
        private Label lblUser;
        private Label lblID;
        private Panel panel1;
        private LinkLabel linkEditar;
        private Panel panel2;
    }
}