using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregamos la referencia a SQL
using System.Data.SqlClient;

namespace MiniMarket.Datos
{
    public class conexion
    {
        //Definimos las variables a utilizar
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static conexion con = null;

        //Instanciamos la clase y le asignamos los valores a las variables.
        private conexion()
        {
            this.Base = "BD_MINIMARKET";
            this.Servidor = "LAPTOP-ICSLPP1J";
            this.Usuario = "lbandherd";
            this.Clave = "l700305*";
            this.Seguridad = false;
        }
        //Creamos el metodo de conexion
        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                //Mediante el booleano seguridad definimos si usaremos la autenticacion de windows o SQL
                if (Seguridad)
                {
                    //Para la autenticacion de windows
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }else
                {
                    //Para la autenticacion de sql
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + "; Password=" + this.Clave;
                }
            }
            catch(Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }
        public static conexion getInstancia()
        {
            if (con == null)
            {
                con = new conexion();
            }
            return con;
        }
    }
}
