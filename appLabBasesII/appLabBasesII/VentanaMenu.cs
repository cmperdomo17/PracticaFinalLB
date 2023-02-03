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
    }
}
