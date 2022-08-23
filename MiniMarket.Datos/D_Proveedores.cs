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
    public class D_Proveedores
    {
        public DataTable Listado_pv(string cTexto)
        {   
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Sp_Listado_pv", SQLCon);
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
        public string Guardar_pv(int nOpcion, E_Proveedores oPv)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Sp_Guardar_pv", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@nCodigo_pv", SqlDbType.Int).Value = oPv.Codigo_pv;
                comando.Parameters.Add("@nCodigo_tdpc", SqlDbType.Int).Value = oPv.Codigo_pv;
                comando.Parameters.Add("@cNrodocumento_pv", SqlDbType.VarChar).Value = oPv.Nrodocumento_pv;
                comando.Parameters.Add("@cRazon_social_pv", SqlDbType.VarChar).Value = oPv.Razon_social_pv;
                comando.Parameters.Add("@cNombres", SqlDbType.VarChar).Value = oPv.Nombres;
                comando.Parameters.Add("@capellidos", SqlDbType.VarChar).Value = oPv.Apellidos;
                comando.Parameters.Add("@nCodigo_sx", SqlDbType.Int).Value = oPv.Codigo_sx;
                comando.Parameters.Add("@nCodigo_ru", SqlDbType.Int).Value = oPv.Codigo_ru;
                comando.Parameters.Add("@cEmail_pv", SqlDbType.VarChar).Value = oPv.Email;
                comando.Parameters.Add("@cTelefono_pv", SqlDbType.VarChar).Value = oPv.Telefono;
                comando.Parameters.Add("@cMovil_pv", SqlDbType.VarChar).Value = oPv.Movil;
                comando.Parameters.Add("@cDireccion_pv", SqlDbType.Text).Value = oPv.Direccion_pv;
                comando.Parameters.Add("@nCodigo_di", SqlDbType.Int).Value = oPv.Codigo_di;
                comando.Parameters.Add("@cObservacion_pv", SqlDbType.Text).Value = oPv.Observacion_pv;
                SqlCon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo registrar los datos";
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

        public string Eliminar_pv(int Codigo_pv)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("SP_ELIMINAR_PV", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nCodigo_pv", SqlDbType.Int).Value = Codigo_pv;
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
        public DataTable Listado_tdpc()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Sp_Listado_tdpc", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
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

        public DataTable Listado_sx()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Sp_Listado_sx", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
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
        public DataTable Listado_ru_pv(string cTexto)
        {
            SqlDataReader resultado;    
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Sp_Listado_ru_pv", SQLCon);
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

        public DataTable Listado_di_pv(string cTexto)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();
            try
            {
                SQLCon = conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Sp_Listado_di_pv", SQLCon);
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

    }
}
