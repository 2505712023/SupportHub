namespace Presentacion
{
    partial class frmIndex
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            pIzquierdoIndex = new Panel();
            btnCerrarSeccion = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnDetalleEntrega = new FontAwesome.Sharp.IconButton();
            btnEquipo = new FontAwesome.Sharp.IconButton();
            btnProveedor = new FontAwesome.Sharp.IconButton();
            btnEntrega = new FontAwesome.Sharp.IconButton();
            btnEmpleado = new FontAwesome.Sharp.IconButton();
            pLogoIndex = new Panel();
            btnHome = new PictureBox();
            pBarraTitulo = new Panel();
            subMenu = new FontAwesome.Sharp.IconButton();
            btnMiximizar = new FontAwesome.Sharp.IconButton();
            btnMaximizar = new FontAwesome.Sharp.IconButton();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            lblIconoFrmActual = new Label();
            btnIconoFrmActual = new FontAwesome.Sharp.IconPictureBox();
            pSombra = new Panel();
            pDesktop = new Panel();
            pDerechoIndex = new Panel();
            pSubMenu = new Panel();
            btnInfo = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnAcerca = new FontAwesome.Sharp.IconButton();
            lblFecha = new Label();
            lblHora = new Label();
            timerIndex = new System.Windows.Forms.Timer(components);
            pIzquierdoIndex.SuspendLayout();
            pLogoIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            pBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnIconoFrmActual).BeginInit();
            pDesktop.SuspendLayout();
            pDerechoIndex.SuspendLayout();
            pSubMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pIzquierdoIndex
            // 
            pIzquierdoIndex.BackColor = Color.FromArgb(5, 23, 59);
            pIzquierdoIndex.Controls.Add(btnCerrarSeccion);
            pIzquierdoIndex.Controls.Add(btnUsuarios);
            pIzquierdoIndex.Controls.Add(btnDetalleEntrega);
            pIzquierdoIndex.Controls.Add(btnEquipo);
            pIzquierdoIndex.Controls.Add(btnProveedor);
            pIzquierdoIndex.Controls.Add(btnEntrega);
            pIzquierdoIndex.Controls.Add(btnEmpleado);
            pIzquierdoIndex.Controls.Add(pLogoIndex);
            pIzquierdoIndex.Dock = DockStyle.Left;
            pIzquierdoIndex.Location = new Point(0, 0);
            pIzquierdoIndex.Margin = new Padding(3, 4, 3, 4);
            pIzquierdoIndex.Name = "pIzquierdoIndex";
            pIzquierdoIndex.Size = new Size(266, 913);
            pIzquierdoIndex.TabIndex = 0;
            // 
            // btnCerrarSeccion
            // 
            btnCerrarSeccion.Dock = DockStyle.Bottom;
            btnCerrarSeccion.FlatAppearance.BorderSize = 0;
            btnCerrarSeccion.FlatStyle = FlatStyle.Flat;
            btnCerrarSeccion.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSeccion.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            btnCerrarSeccion.IconColor = SystemColors.Window;
            btnCerrarSeccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarSeccion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSeccion.Location = new Point(0, 833);
            btnCerrarSeccion.Margin = new Padding(3, 4, 3, 4);
            btnCerrarSeccion.Name = "btnCerrarSeccion";
            btnCerrarSeccion.Size = new Size(266, 80);
            btnCerrarSeccion.TabIndex = 7;
            btnCerrarSeccion.Text = "CERRAR SESIÓN ";
            btnCerrarSeccion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSeccion.UseVisualStyleBackColor = true;
            btnCerrarSeccion.Click += btnCerrarSeccion_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.ForeColor = SystemColors.ControlLightLight;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            btnUsuarios.IconColor = SystemColors.Window;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 587);
            btnUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(266, 80);
            btnUsuarios.TabIndex = 6;
            btnUsuarios.Text = "USUARIO";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnDetalleEntrega
            // 
            btnDetalleEntrega.Dock = DockStyle.Top;
            btnDetalleEntrega.FlatAppearance.BorderSize = 0;
            btnDetalleEntrega.FlatStyle = FlatStyle.Flat;
            btnDetalleEntrega.ForeColor = SystemColors.ControlLightLight;
            btnDetalleEntrega.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            btnDetalleEntrega.IconColor = SystemColors.Window;
            btnDetalleEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDetalleEntrega.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetalleEntrega.Location = new Point(0, 507);
            btnDetalleEntrega.Margin = new Padding(3, 4, 3, 4);
            btnDetalleEntrega.Name = "btnDetalleEntrega";
            btnDetalleEntrega.Size = new Size(266, 80);
            btnDetalleEntrega.TabIndex = 5;
            btnDetalleEntrega.Text = "DETALLE ENTREGA";
            btnDetalleEntrega.TextAlign = ContentAlignment.MiddleLeft;
            btnDetalleEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDetalleEntrega.UseVisualStyleBackColor = true;
            btnDetalleEntrega.Click += btnDetalleEntrega_Click;
            // 
            // btnEquipo
            // 
            btnEquipo.Dock = DockStyle.Top;
            btnEquipo.FlatAppearance.BorderSize = 0;
            btnEquipo.FlatStyle = FlatStyle.Flat;
            btnEquipo.ForeColor = SystemColors.ControlLightLight;
            btnEquipo.IconChar = FontAwesome.Sharp.IconChar.Computer;
            btnEquipo.IconColor = SystemColors.Window;
            btnEquipo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEquipo.ImageAlign = ContentAlignment.MiddleLeft;
            btnEquipo.Location = new Point(0, 427);
            btnEquipo.Margin = new Padding(3, 4, 3, 4);
            btnEquipo.Name = "btnEquipo";
            btnEquipo.Size = new Size(266, 80);
            btnEquipo.TabIndex = 4;
            btnEquipo.Text = "EQUIPO";
            btnEquipo.TextAlign = ContentAlignment.MiddleLeft;
            btnEquipo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEquipo.UseVisualStyleBackColor = true;
            btnEquipo.Click += btnEquipo_Click;
            // 
            // btnProveedor
            // 
            btnProveedor.Dock = DockStyle.Top;
            btnProveedor.FlatAppearance.BorderSize = 0;
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.ForeColor = SystemColors.ControlLightLight;
            btnProveedor.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnProveedor.IconColor = SystemColors.Window;
            btnProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedor.Location = new Point(0, 347);
            btnProveedor.Margin = new Padding(3, 4, 3, 4);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(266, 80);
            btnProveedor.TabIndex = 3;
            btnProveedor.Text = "PROVEEDOR";
            btnProveedor.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProveedor.UseVisualStyleBackColor = true;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnEntrega
            // 
            btnEntrega.Dock = DockStyle.Top;
            btnEntrega.FlatAppearance.BorderSize = 0;
            btnEntrega.FlatStyle = FlatStyle.Flat;
            btnEntrega.ForeColor = SystemColors.ControlLightLight;
            btnEntrega.IconChar = FontAwesome.Sharp.IconChar.Cube;
            btnEntrega.IconColor = SystemColors.Window;
            btnEntrega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEntrega.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrega.Location = new Point(0, 267);
            btnEntrega.Margin = new Padding(3, 4, 3, 4);
            btnEntrega.Name = "btnEntrega";
            btnEntrega.Size = new Size(266, 80);
            btnEntrega.TabIndex = 2;
            btnEntrega.Text = "ENTREGA";
            btnEntrega.TextAlign = ContentAlignment.MiddleLeft;
            btnEntrega.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEntrega.UseVisualStyleBackColor = true;
            btnEntrega.Click += btnEntrega_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Dock = DockStyle.Top;
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.ForeColor = SystemColors.ControlLightLight;
            btnEmpleado.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            btnEmpleado.IconColor = SystemColors.Window;
            btnEmpleado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.Location = new Point(0, 187);
            btnEmpleado.Margin = new Padding(3, 4, 3, 4);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(266, 80);
            btnEmpleado.TabIndex = 1;
            btnEmpleado.Text = "EMPLEADO";
            btnEmpleado.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // pLogoIndex
            // 
            pLogoIndex.Controls.Add(btnHome);
            pLogoIndex.Dock = DockStyle.Top;
            pLogoIndex.Location = new Point(0, 0);
            pLogoIndex.Margin = new Padding(3, 4, 3, 4);
            pLogoIndex.Name = "pLogoIndex";
            pLogoIndex.Padding = new Padding(11, 0, 23, 0);
            pLogoIndex.Size = new Size(266, 187);
            pLogoIndex.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(3, 0);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(291, 179);
            btnHome.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // pBarraTitulo
            // 
            pBarraTitulo.BackColor = Color.FromArgb(5, 23, 59);
            pBarraTitulo.Controls.Add(subMenu);
            pBarraTitulo.Controls.Add(btnMiximizar);
            pBarraTitulo.Controls.Add(btnMaximizar);
            pBarraTitulo.Controls.Add(btnCerrar);
            pBarraTitulo.Controls.Add(lblIconoFrmActual);
            pBarraTitulo.Controls.Add(btnIconoFrmActual);
            pBarraTitulo.Dock = DockStyle.Top;
            pBarraTitulo.Location = new Point(266, 0);
            pBarraTitulo.Margin = new Padding(3, 4, 3, 4);
            pBarraTitulo.Name = "pBarraTitulo";
            pBarraTitulo.Size = new Size(1093, 100);
            pBarraTitulo.TabIndex = 1;
            pBarraTitulo.MouseDown += pBarraTitulo_MouseDown;
            // 
            // subMenu
            // 
            subMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            subMenu.FlatAppearance.BorderSize = 0;
            subMenu.FlatStyle = FlatStyle.Flat;
            subMenu.ForeColor = SystemColors.ControlLightLight;
            subMenu.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            subMenu.IconColor = SystemColors.Window;
            subMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            subMenu.IconSize = 20;
            subMenu.ImageAlign = ContentAlignment.MiddleLeft;
            subMenu.Location = new Point(1047, 60);
            subMenu.Margin = new Padding(3, 4, 3, 4);
            subMenu.Name = "subMenu";
            subMenu.Size = new Size(32, 32);
            subMenu.TabIndex = 5;
            subMenu.TextAlign = ContentAlignment.MiddleLeft;
            subMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            subMenu.UseVisualStyleBackColor = true;
            subMenu.Click += subMenu_Click;
            // 
            // btnMiximizar
            // 
            btnMiximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMiximizar.FlatAppearance.BorderSize = 0;
            btnMiximizar.FlatStyle = FlatStyle.Flat;
            btnMiximizar.ForeColor = SystemColors.ControlLightLight;
            btnMiximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMiximizar.IconColor = SystemColors.Window;
            btnMiximizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMiximizar.IconSize = 20;
            btnMiximizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMiximizar.Location = new Point(982, 0);
            btnMiximizar.Margin = new Padding(3, 4, 3, 4);
            btnMiximizar.Name = "btnMiximizar";
            btnMiximizar.Size = new Size(30, 36);
            btnMiximizar.TabIndex = 4;
            btnMiximizar.TextAlign = ContentAlignment.MiddleLeft;
            btnMiximizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMiximizar.UseVisualStyleBackColor = true;
            btnMiximizar.Click += btnMiximizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.ForeColor = SystemColors.ControlLightLight;
            btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximizar.IconColor = SystemColors.Window;
            btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximizar.IconSize = 20;
            btnMaximizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMaximizar.Location = new Point(1018, 4);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(32, 32);
            btnMaximizar.TabIndex = 3;
            btnMaximizar.TextAlign = ContentAlignment.MiddleLeft;
            btnMaximizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrar.IconColor = SystemColors.Window;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrar.IconSize = 20;
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(1057, 4);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(32, 32);
            btnCerrar.TabIndex = 2;
            btnCerrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblIconoFrmActual
            // 
            lblIconoFrmActual.AutoSize = true;
            lblIconoFrmActual.ForeColor = SystemColors.Window;
            lblIconoFrmActual.Location = new Point(73, 37);
            lblIconoFrmActual.Name = "lblIconoFrmActual";
            lblIconoFrmActual.Size = new Size(52, 20);
            lblIconoFrmActual.TabIndex = 1;
            lblIconoFrmActual.Text = "HOME";
            // 
            // btnIconoFrmActual
            // 
            btnIconoFrmActual.BackColor = Color.FromArgb(5, 23, 59);
            btnIconoFrmActual.ForeColor = Color.Purple;
            btnIconoFrmActual.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            btnIconoFrmActual.IconColor = Color.Purple;
            btnIconoFrmActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIconoFrmActual.IconSize = 59;
            btnIconoFrmActual.Location = new Point(7, 16);
            btnIconoFrmActual.Margin = new Padding(3, 4, 3, 4);
            btnIconoFrmActual.Name = "btnIconoFrmActual";
            btnIconoFrmActual.Size = new Size(59, 65);
            btnIconoFrmActual.TabIndex = 0;
            btnIconoFrmActual.TabStop = false;
            // 
            // pSombra
            // 
            pSombra.BackColor = Color.FromArgb(5, 23, 59);
            pSombra.Dock = DockStyle.Top;
            pSombra.Location = new Point(266, 100);
            pSombra.Margin = new Padding(3, 4, 3, 4);
            pSombra.Name = "pSombra";
            pSombra.Size = new Size(1093, 13);
            pSombra.TabIndex = 2;
            // 
            // pDesktop
            // 
            pDesktop.BackColor = Color.FromArgb(148, 184, 216);
            pDesktop.Controls.Add(pDerechoIndex);
            pDesktop.Controls.Add(lblFecha);
            pDesktop.Controls.Add(lblHora);
            pDesktop.Dock = DockStyle.Fill;
            pDesktop.Location = new Point(266, 113);
            pDesktop.Margin = new Padding(3, 4, 3, 4);
            pDesktop.Name = "pDesktop";
            pDesktop.Size = new Size(1093, 800);
            pDesktop.TabIndex = 3;
            pDesktop.Paint += pDesktop_Paint;
            // 
            // pDerechoIndex
            // 
            pDerechoIndex.Controls.Add(pSubMenu);
            pDerechoIndex.Dock = DockStyle.Right;
            pDerechoIndex.Location = new Point(1093, 0);
            pDerechoIndex.Margin = new Padding(3, 4, 3, 4);
            pDerechoIndex.Name = "pDerechoIndex";
            pDerechoIndex.Size = new Size(0, 800);
            pDerechoIndex.TabIndex = 5;
            // 
            // pSubMenu
            // 
            pSubMenu.BackColor = Color.FromArgb(148, 184, 216);
            pSubMenu.Controls.Add(btnInfo);
            pSubMenu.Controls.Add(btnSalir);
            pSubMenu.Controls.Add(btnAcerca);
            pSubMenu.Dock = DockStyle.Top;
            pSubMenu.Location = new Point(0, 0);
            pSubMenu.Margin = new Padding(3, 4, 3, 4);
            pSubMenu.Name = "pSubMenu";
            pSubMenu.Size = new Size(0, 233);
            pSubMenu.TabIndex = 0;
            // 
            // btnInfo
            // 
            btnInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.ForeColor = Color.FromArgb(31, 35, 40);
            btnInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            btnInfo.IconColor = Color.FromArgb(31, 35, 40);
            btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInfo.IconSize = 20;
            btnInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfo.Location = new Point(-155, 8);
            btnInfo.Margin = new Padding(3, 4, 3, 4);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(146, 65);
            btnInfo.TabIndex = 2;
            btnInfo.Text = "INFORMACIÓN";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.FromArgb(31, 35, 40);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            btnSalir.IconColor = Color.FromArgb(31, 35, 40);
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnSalir.IconSize = 20;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(-155, 147);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(146, 65);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAcerca
            // 
            btnAcerca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAcerca.FlatAppearance.BorderSize = 0;
            btnAcerca.FlatStyle = FlatStyle.Flat;
            btnAcerca.ForeColor = Color.FromArgb(31, 35, 40);
            btnAcerca.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            btnAcerca.IconColor = Color.FromArgb(31, 35, 40);
            btnAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAcerca.IconSize = 20;
            btnAcerca.ImageAlign = ContentAlignment.MiddleLeft;
            btnAcerca.Location = new Point(-150, 73);
            btnAcerca.Margin = new Padding(3, 4, 3, 4);
            btnAcerca.Name = "btnAcerca";
            btnAcerca.Size = new Size(146, 65);
            btnAcerca.TabIndex = 3;
            btnAcerca.Text = "ACERCA DE";
            btnAcerca.TextAlign = ContentAlignment.MiddleLeft;
            btnAcerca.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAcerca.UseVisualStyleBackColor = true;
            btnAcerca.Click += btnAcerca_Click;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century Gothic", 25F);
            lblFecha.ForeColor = Color.FromArgb(31, 35, 40);
            lblFecha.Location = new Point(283, 395);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(157, 51);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "FECHA";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.None;
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century Gothic", 100F);
            lblHora.ForeColor = Color.FromArgb(31, 35, 40);
            lblHora.Location = new Point(245, 153);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(568, 201);
            lblHora.TabIndex = 1;
            lblHora.Text = "HORA";
            // 
            // timerIndex
            // 
            timerIndex.Tick += timerIndex_Tick;
            // 
            // frmIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 913);
            Controls.Add(pDesktop);
            Controls.Add(pSombra);
            Controls.Add(pBarraTitulo);
            Controls.Add(pIzquierdoIndex);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuppportHub";
            Load += frmIndex_Load;
            pIzquierdoIndex.ResumeLayout(false);
            pLogoIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            pBarraTitulo.ResumeLayout(false);
            pBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnIconoFrmActual).EndInit();
            pDesktop.ResumeLayout(false);
            pDesktop.PerformLayout();
            pDerechoIndex.ResumeLayout(false);
            pSubMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pIzquierdoIndex;
        private FontAwesome.Sharp.IconButton btnEmpleado;
        private Panel pLogoIndex;
        private FontAwesome.Sharp.IconButton btnDetalleEntrega;
        private FontAwesome.Sharp.IconButton btnEquipo;
        private FontAwesome.Sharp.IconButton btnProveedor;
        private FontAwesome.Sharp.IconButton btnEntrega;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private PictureBox btnHome;
        private Panel pBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox btnIconoFrmActual;
        private Label lblIconoFrmActual;
        private Panel pSombra;
        private Panel pDesktop;
        private FontAwesome.Sharp.IconButton btnMiximizar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton subMenu;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnAcerca;
        private FontAwesome.Sharp.IconButton btnInfo;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timerIndex;
        private Panel pDerechoIndex;
        private Panel pSubMenu;
        private FontAwesome.Sharp.IconButton btnCerrarSeccion;
    }
}