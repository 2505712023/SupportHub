namespace Presentacion.CustomMessageBoxes
{
    partial class ExitoMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitoMessageBox));
            pSuperiorAddEntrega = new Panel();
            iconButtonX = new FontAwesome.Sharp.IconButton();
            lblTextoTab = new Label();
            btnCerrarAddEmpleado = new FontAwesome.Sharp.IconButton();
            ibtnOK = new FontAwesome.Sharp.IconButton();
            iconPrincipal = new FontAwesome.Sharp.IconPictureBox();
            tboxDescripcionExito = new RichTextBox();
            pSuperiorAddEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPrincipal).BeginInit();
            SuspendLayout();
            // 
            // pSuperiorAddEntrega
            // 
            pSuperiorAddEntrega.BackColor = Color.FromArgb(5, 23, 59);
            pSuperiorAddEntrega.Controls.Add(iconButtonX);
            pSuperiorAddEntrega.Controls.Add(lblTextoTab);
            pSuperiorAddEntrega.Controls.Add(btnCerrarAddEmpleado);
            resources.ApplyResources(pSuperiorAddEntrega, "pSuperiorAddEntrega");
            pSuperiorAddEntrega.Name = "pSuperiorAddEntrega";
            // 
            // iconButtonX
            // 
            resources.ApplyResources(iconButtonX, "iconButtonX");
            iconButtonX.FlatAppearance.BorderSize = 0;
            iconButtonX.ForeColor = SystemColors.ControlLightLight;
            iconButtonX.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButtonX.IconColor = SystemColors.Window;
            iconButtonX.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButtonX.IconSize = 20;
            iconButtonX.Name = "iconButtonX";
            iconButtonX.UseVisualStyleBackColor = true;
            iconButtonX.Click += iconButtonX_Click;
            // 
            // lblTextoTab
            // 
            resources.ApplyResources(lblTextoTab, "lblTextoTab");
            lblTextoTab.ForeColor = Color.White;
            lblTextoTab.Name = "lblTextoTab";
            // 
            // btnCerrarAddEmpleado
            // 
            resources.ApplyResources(btnCerrarAddEmpleado, "btnCerrarAddEmpleado");
            btnCerrarAddEmpleado.FlatAppearance.BorderSize = 0;
            btnCerrarAddEmpleado.ForeColor = SystemColors.ControlLightLight;
            btnCerrarAddEmpleado.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrarAddEmpleado.IconColor = SystemColors.Window;
            btnCerrarAddEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnCerrarAddEmpleado.IconSize = 20;
            btnCerrarAddEmpleado.Name = "btnCerrarAddEmpleado";
            btnCerrarAddEmpleado.UseVisualStyleBackColor = true;
            // 
            // ibtnOK
            // 
            resources.ApplyResources(ibtnOK, "ibtnOK");
            ibtnOK.BackColor = Color.FromArgb(5, 23, 59);
            ibtnOK.FlatAppearance.BorderSize = 0;
            ibtnOK.ForeColor = Color.White;
            ibtnOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            ibtnOK.IconColor = Color.White;
            ibtnOK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnOK.IconSize = 20;
            ibtnOK.Name = "ibtnOK";
            ibtnOK.UseVisualStyleBackColor = false;
            ibtnOK.Click += ibtnOK_Click;
            // 
            // iconPrincipal
            // 
            iconPrincipal.BackColor = Color.FromArgb(98, 122, 144);
            iconPrincipal.ForeColor = Color.Green;
            iconPrincipal.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            iconPrincipal.IconColor = Color.Green;
            iconPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPrincipal.IconSize = 93;
            resources.ApplyResources(iconPrincipal, "iconPrincipal");
            iconPrincipal.Name = "iconPrincipal";
            iconPrincipal.TabStop = false;
            // 
            // tboxDescripcionExito
            // 
            tboxDescripcionExito.BackColor = Color.FromArgb(98, 122, 144);
            tboxDescripcionExito.BorderStyle = BorderStyle.None;
            resources.ApplyResources(tboxDescripcionExito, "tboxDescripcionExito");
            tboxDescripcionExito.Name = "tboxDescripcionExito";
            // 
            // ExitoMessageBox
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(98, 122, 144);
            Controls.Add(tboxDescripcionExito);
            Controls.Add(iconPrincipal);
            Controls.Add(ibtnOK);
            Controls.Add(pSuperiorAddEntrega);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExitoMessageBox";
            TopMost = true;
            Load += ExitoMessageBox_Load;
            pSuperiorAddEntrega.ResumeLayout(false);
            pSuperiorAddEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperiorAddEntrega;
        private FontAwesome.Sharp.IconButton btnCerrarAddEmpleado;
        private FontAwesome.Sharp.IconButton ibtnOK;
        private FontAwesome.Sharp.IconPictureBox iconPrincipal;
        private Label lblTextoTab;
        private FontAwesome.Sharp.IconButton iconButtonX;
        private RichTextBox tboxDescripcionExito;
        
    }
}