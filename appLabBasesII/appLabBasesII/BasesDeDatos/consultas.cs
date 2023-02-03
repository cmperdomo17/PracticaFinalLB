﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace baseDeDatos.conection
{
    class Consultas
    {
        #region atributos
        private OracleConnection conexion;
        private string user;
        #endregion

        #region Constructores
        public Consultas() { }
        public Consultas(OracleConnection conexion,string user) {
            this.conexion = conexion;
            this.user = user;
        }
        #endregion

        #region consultas
        public String insertarUsuario(String nombre,String Apellido, int edad, double peso, double altura, String objetivo, String estado) {
            OracleCommand ora_cmd = new OracleCommand(user+".gym_package.insert_usuario", conexion);
            ora_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            ora_cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, nombre, System.Data.ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_apellido", OracleDbType.Varchar2, Apellido, System.Data.ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_edad", OracleDbType.Int64, edad, System.Data.ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_peso", OracleDbType.Double, peso, System.Data.ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_altura", OracleDbType.Double, altura, System.Data.ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_objetivo", OracleDbType.Varchar2, objetivo, System.Data.ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_estado", OracleDbType.Varchar2, estado, System.Data.ParameterDirection.Input);
            try {

                conexion.Open();
                ora_cmd.ExecuteNonQuery();
                return "Insercción exitosa";

            
            }catch(Exception e)
            {
                return e.ToString();
            }
            finally
            {
                conexion.Close();
            }



        }

        public String InsertarRutina(String nombre, String descripcion, int nivel) {
            OracleCommand ora_cmd = new OracleCommand(user + ".gym_package.insert_rutina", conexion);
            ora_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            ora_cmd.Parameters.Add("p_nombre", OracleDbType.Varchar2, nombre, System.Data.ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_descripcion", OracleDbType.Varchar2, descripcion, System.Data.ParameterDirection.Input);
            ora_cmd.Parameters.Add("p_nivel", OracleDbType.Int64, nivel, System.Data.ParameterDirection.Input);

            try
            {
                conexion.Open();
                ora_cmd.ExecuteNonQuery();
                return "Insercción exitosa";

            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally {

                conexion.Close();
            }

        }
        #endregion;


    }
}
