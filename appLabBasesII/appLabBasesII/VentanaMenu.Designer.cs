
namespace appLabBasesII
{
    partial class VentanaMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertarUsuario = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnInsertarRutina = new System.Windows.Forms.Button();
            this.btnInsertarEjercicio = new System.Windows.Forms.Button();
            this.btnEjercicioEnRutina = new System.Windows.Forms.Button();
            this.btnRutinaCliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRutinaCliente);
            this.panel1.Controls.Add(this.btnEjercicioEnRutina);
            this.panel1.Controls.Add(this.btnInsertarEjercicio);
            this.panel1.Controls.Add(this.btnInsertarRutina);
            this.panel1.Controls.Add(this.btnInsertarUsuario);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.Location = new System.Drawing.Point(283, 61);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(215, 23);
            this.btnInsertarUsuario.TabIndex = 1;
            this.btnInsertarUsuario.Text = "Insertar Usuario";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            this.btnInsertarUsuario.Click += new System.EventHandler(this.btnInsertarUsuario_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(367, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(41, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menu";
            // 
            // btnInsertarRutina
            // 
            this.btnInsertarRutina.Location = new System.Drawing.Point(283, 120);
            this.btnInsertarRutina.Name = "btnInsertarRutina";
            this.btnInsertarRutina.Size = new System.Drawing.Size(215, 23);
            this.btnInsertarRutina.TabIndex = 1;
            this.btnInsertarRutina.Text = "Insertar Rutina";
            this.btnInsertarRutina.UseVisualStyleBackColor = true;
            this.btnInsertarRutina.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInsertarEjercicio
            // 
            this.btnInsertarEjercicio.Location = new System.Drawing.Point(283, 172);
            this.btnInsertarEjercicio.Name = "btnInsertarEjercicio";
            this.btnInsertarEjercicio.Size = new System.Drawing.Size(215, 23);
            this.btnInsertarEjercicio.TabIndex = 2;
            this.btnInsertarEjercicio.Text = "Insertar Ejercicio";
            this.btnInsertarEjercicio.UseVisualStyleBackColor = true;
            this.btnInsertarEjercicio.Click += new System.EventHandler(this.btnInsertarEjercicio_Click);
            // 
            // btnEjercicioEnRutina
            // 
            this.btnEjercicioEnRutina.Location = new System.Drawing.Point(275, 222);
            this.btnEjercicioEnRutina.Name = "btnEjercicioEnRutina";
            this.btnEjercicioEnRutina.Size = new System.Drawing.Size(233, 23);
            this.btnEjercicioEnRutina.TabIndex = 3;
            this.btnEjercicioEnRutina.Text = "Insertar Ejercicio en Rutina";
            this.btnEjercicioEnRutina.UseVisualStyleBackColor = true;
            this.btnEjercicioEnRutina.Click += new System.EventHandler(this.btnEjercicioEnRutina_Click);
            // 
            // btnRutinaCliente
            // 
            this.btnRutinaCliente.Location = new System.Drawing.Point(275, 275);
            this.btnRutinaCliente.Name = "btnRutinaCliente";
            this.btnRutinaCliente.Size = new System.Drawing.Size(223, 23);
            this.btnRutinaCliente.TabIndex = 4;
            this.btnRutinaCliente.Text = "Insertar Rutina Cliente";
            this.btnRutinaCliente.UseVisualStyleBackColor = true;
            this.btnRutinaCliente.Click += new System.EventHandler(this.btnRutinaCliente_Click);
            // 
            // VentanaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnInsertarRutina;
        private System.Windows.Forms.Button btnInsertarEjercicio;
        private System.Windows.Forms.Button btnEjercicioEnRutina;
        private System.Windows.Forms.Button btnRutinaCliente;
    }
}