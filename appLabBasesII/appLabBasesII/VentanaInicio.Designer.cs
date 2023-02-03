
namespace appLabBasesII
{
    partial class VentanaInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lbPrueba = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.txtNumeroPuerto = new System.Windows.Forms.TextBox();
            this.lblNumeroPuerto = new System.Windows.Forms.Label();
            this.txtNombreHost = new System.Windows.Forms.TextBox();
            this.lnNombreH = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lbNombreDeU = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.lbPrueba);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.lblcontraseña);
            this.panel1.Controls.Add(this.txtNumeroPuerto);
            this.panel1.Controls.Add(this.lblNumeroPuerto);
            this.panel1.Controls.Add(this.txtNombreHost);
            this.panel1.Controls.Add(this.lnNombreH);
            this.panel1.Controls.Add(this.txtNombreUsuario);
            this.panel1.Controls.Add(this.lbNombreDeU);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 555);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(462, 394);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(100, 28);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lbPrueba
            // 
            this.lbPrueba.AutoSize = true;
            this.lbPrueba.Location = new System.Drawing.Point(532, 129);
            this.lbPrueba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrueba.Name = "lbPrueba";
            this.lbPrueba.Size = new System.Drawing.Size(0, 16);
            this.lbPrueba.TabIndex = 8;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(452, 335);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(124, 22);
            this.txtContraseña.TabIndex = 7;
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(470, 288);
            this.lblcontraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(77, 16);
            this.lblcontraseña.TabIndex = 6;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // txtNumeroPuerto
            // 
            this.txtNumeroPuerto.Location = new System.Drawing.Point(448, 240);
            this.txtNumeroPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroPuerto.Name = "txtNumeroPuerto";
            this.txtNumeroPuerto.Size = new System.Drawing.Size(128, 22);
            this.txtNumeroPuerto.TabIndex = 5;
            // 
            // lblNumeroPuerto
            // 
            this.lblNumeroPuerto.AutoSize = true;
            this.lblNumeroPuerto.Location = new System.Drawing.Point(459, 206);
            this.lblNumeroPuerto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroPuerto.Name = "lblNumeroPuerto";
            this.lblNumeroPuerto.Size = new System.Drawing.Size(98, 16);
            this.lblNumeroPuerto.TabIndex = 4;
            this.lblNumeroPuerto.Text = "Numero Puerto";
            // 
            // txtNombreHost
            // 
            this.txtNombreHost.Location = new System.Drawing.Point(444, 149);
            this.txtNombreHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreHost.Name = "txtNombreHost";
            this.txtNombreHost.Size = new System.Drawing.Size(132, 22);
            this.txtNombreHost.TabIndex = 3;
            // 
            // lnNombreH
            // 
            this.lnNombreH.AutoSize = true;
            this.lnNombreH.Location = new System.Drawing.Point(459, 102);
            this.lnNombreH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnNombreH.Name = "lnNombreH";
            this.lnNombreH.Size = new System.Drawing.Size(88, 16);
            this.lnNombreH.TabIndex = 2;
            this.lnNombreH.Text = "Nombre Host";
            this.lnNombreH.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(444, 51);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // lbNombreDeU
            // 
            this.lbNombreDeU.AutoSize = true;
            this.lbNombreDeU.Location = new System.Drawing.Point(448, 8);
            this.lbNombreDeU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombreDeU.Name = "lbNombreDeU";
            this.lbNombreDeU.Size = new System.Drawing.Size(128, 16);
            this.lbNombreDeU.TabIndex = 0;
            this.lbNombreDeU.Text = "Nombre De Usuario";
            // 
            // VentanaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaInicio";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lnNombreH;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lbNombreDeU;
        private System.Windows.Forms.TextBox txtNumeroPuerto;
        private System.Windows.Forms.Label lblNumeroPuerto;
        private System.Windows.Forms.TextBox txtNombreHost;
        private System.Windows.Forms.Label lbPrueba;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Button btnEntrar;
    }
}

