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
    public class D_Marcas
    {
        public DataTable Listado_ma(string cTexto)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Sp_Listado_ma", SQLCon);
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
        public string Guardar_ma(int nOpcion, E_Marcas oMa)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Guardar_ma", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@nCodigo_ma", SqlDbType.Int).Value = oMa.Codigo_ma;
                comando.Parameters.Add("@cDescripcion_ma", SqlDbType.VarChar).Value = oMa.Descripcion_ma;
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

        public string Eliminar_ma(int Codigo_ma)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_MA", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_ma", SqlDbType.Int).Value = Codigo_ma;
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
