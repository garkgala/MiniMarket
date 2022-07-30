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
    public class D_Almacenes
    {
        public DataTable Listado_al(string cTexto)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Sp_Listado_al", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                resultado = Comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }
        public string Guardar_al(int nOpcion, E_Almacenes oAl)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Guardar_al", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@nCodigo_AL", SqlDbType.Int).Value = oAl.Codigo_al;
                comando.Parameters.Add("@cDescripcion_AL", SqlDbType.VarChar).Value = oAl.Descripcion_al;
                SqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "ok" : "No se pudo registrar los datos";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Eliminar_al(int Codigo_al)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_AL", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_al", SqlDbType.Int).Value = Codigo_al;
                SqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "ok" : "No se pudo registrar los datos";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
