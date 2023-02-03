using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace baseDeDatos.conection
{
    class conection
    {
        #region atributos
        private string user;
        private string password;
        private string host;
        private string idHost;
        #endregion

        

        #region Metodos
        public conection() { }
        public conection(string User, string Password, string Host, string Idhost)
        {
            this.user = User;
            this.password = Password;
            this.host = Host;
            this.idHost = Idhost;
        }

        public string User { get => user; set => user = value; }

        public OracleConnection OraclecrearConexion() {
            string constr = "user id ="+user+"; password ="+password+";Data Source= "+host+":"+idHost+";";
            OracleConnection con = new OracleConnection(constr);
            return con;
        }
        #endregion

    }
}
