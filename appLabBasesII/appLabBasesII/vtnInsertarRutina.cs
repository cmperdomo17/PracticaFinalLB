using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baseDeDatos.conection;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace appLabBasesII
{
    public partial class vtnInsertarRutina : Form
    {
        #region Atributos
        private OracleConnection conexion;
        private string user;
        #endregion
        public vtnInsertarRutina(OracleConnection conexion, string user)
        {
            this.conexion = conexion;
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas nuevaConsulta = new Consultas(conexion, user);
            String Resutlado = nuevaConsulta.InsertarRutina(txtNombreRutina.Text, txtDescripcion.Text, int.Parse(txtNivel.Text));
            MessageBox.Show(Resutlado);
        }

        private void btnVolver5_Click(object sender, EventArgs e)
        {
            Form menu = new VentanaMenu(conexion, user);
            this.Hide();
            menu.Show();
        }
    }
}
