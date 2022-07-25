using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MiniMarket.Entidades;

namespace MiniMarket.Datos
{
    public class D_Categorias
    {
        public DataTable Listado_ca(string cTexto)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Sp_Listado_ca", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                resultado = Comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }
    }
}
