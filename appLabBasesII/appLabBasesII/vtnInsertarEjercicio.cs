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
    public partial class vtnInsertarEjercicio : Form
    {
        private OracleConnection conexion;
        private string user;
        public vtnInsertarEjercicio(OracleConnection conexion, string user)
        {
            this.conexion = conexion;
            this.user = user;
            InitializeComponent();
        }

        private void btbCrearEjercicio_Click(object sender, EventArgs e)
        {
            Consultas nuevaConsulta = new Consultas(conexion, user);
            String resultado = nuevaConsulta.InsertarEjercicio(txtNombreEjercicio.Text, txtEjercicio.Text, txtDescripcion.Text);
            MessageBox.Show(resultado);
        }

        private void btnVolver4_Click(object sender, EventArgs e)
        {
            Form menu = new VentanaMenu(conexion, user);
            this.Hide();
            menu.Show();
        }
    }
}
