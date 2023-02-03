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
    public partial class vtnEjercicioRutina : Form
    {
        #region Atributos
        private OracleConnection conexion;
        private string user;
        #endregion
        public vtnEjercicioRutina(OracleConnection conexion, string user)
        {
            this.conexion = conexion;
            this.user = user;
            InitializeComponent();
        }

        private void btnAgregarRutinaEjercicio_Click(object sender, EventArgs e)
        {
            Consultas nuevaConsulta = new Consultas(conexion, user);
            String resultado = nuevaConsulta.InsertarRutinaEjercicio(txtNombreRutina.Text, txtNombreEjercicio.Text, double.Parse(txtSeries.Text),double.Parse(txtRepeticiones.Text));
            MessageBox.Show(resultado);
        }
    }
}
