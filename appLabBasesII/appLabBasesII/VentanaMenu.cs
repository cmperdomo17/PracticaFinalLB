using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace appLabBasesII
{
    public partial class VentanaMenu : Form
    {
        private OracleConnection conexion;
        private string user;
        public VentanaMenu(OracleConnection conexion, string user)
        {
            this.conexion = conexion;
            this.user = user;
            InitializeComponent();
        }

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            Form InsertarUsuario = new vtnInsertarUsuario(conexion, user);
            InsertarUsuario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form InsertarRutina = new vtnInsertarRutina(conexion, user);
            InsertarRutina.Show();
            this.Close();
        }

        private void btnInsertarEjercicio_Click(object sender, EventArgs e)
        {
            Form InsertarEjercicio = new vtnInsertarEjercicio(conexion, user);
            InsertarEjercicio.Show();
            this.Close();
        }

        private void btnEjercicioEnRutina_Click(object sender, EventArgs e)
        {
            Form InsertarEjercicioRutina = new vtnEjercicioRutina(conexion, user);
            InsertarEjercicioRutina.Show();
            this.Close();
        }
    }
}
