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
    public partial class vtnInsertarClienteRutina : Form
    {
        #region Atributos
        private OracleConnection conexion;
        private string user;
        #endregion
        public vtnInsertarClienteRutina(OracleConnection conexion, string user)
        {
            this.conexion = conexion;
            this.user = user;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Consultas nuevaConsulta = new Consultas(conexion, user);
            String Resultado = nuevaConsulta.InsertarClienteRutina(txtNombreUsuario.Text,txtApellidoUsuario.Text,txtRutina.Text);
            MessageBox.Show(Resultado);
        }

        private void btnVolver3_Click(object sender, EventArgs e)
        {
            Form menu = new VentanaMenu(conexion, user);
            this.Hide();
            menu.Show();
        }
    }
}
