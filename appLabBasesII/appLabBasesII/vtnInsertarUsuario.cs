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
    public partial class vtnInsertarUsuario : Form
    {
        #region Atributos
        private OracleConnection conexion;
        private string user;
        #endregion

        public vtnInsertarUsuario(OracleConnection conexion, string user)
        {
            this.conexion = conexion;
            this.user = user;
            InitializeComponent();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Consultas nuevaConsulta = new Consultas(conexion, user);
            String Resultado = nuevaConsulta.insertarUsuario(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), double.Parse(txtPeso.Text), double.Parse(txtAltura.Text), txtObjetivo.Text, txtEstado.Text);
            MessageBox.Show(Resultado);
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            Form menu = new VentanaMenu(conexion, user);
            this.Hide();
            menu.Show();    
        }
    }
}
