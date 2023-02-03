using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baseDeDatos.conection;
using Oracle.ManagedDataAccess.Client;

namespace appLabBasesII
{
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();
        }



       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            conection nuevaConexion = new conection(txtNombreUsuario.Text,txtContraseña.Text,txtNombreHost.Text, txtNumeroPuerto.Text);
            OracleConnection conexion = nuevaConexion.OraclecrearConexion();
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion Abierta Exitosamente");
                Form ventanaMenu = new VentanaMenu(conexion,txtNombreUsuario.Text);
                this.Hide();
                ventanaMenu.Show();
                conexion.Close();
              
            }
            catch {
                conexion.Close();
                MessageBox.Show("Erro!,Alguno de los datos de usuario Esta mal Ingresado");
            
            }
            
        }
    }
}
