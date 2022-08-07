using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MiniMarket.Entidades;
using MiniMarket.Datos;

namespace MiniMarket.Negocio
{
    public class N_Productos
    {
        public static DataTable Listado_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_pr(cTexto);
        }

        public static string Guardar_pr(int nOpcion, E_Productos oPr)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Guardar_pr(nOpcion, oPr);
        }
        public static string Eliminar_pr(int nOpcion)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Eliminar_pr(nOpcion);
        }
        public static DataTable Listado_ma_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_ma_pr(cTexto);
        }
        public static DataTable Listado_um_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_um_pr(cTexto);
        }
        public static DataTable Listado_ca_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Listado_ca_pr(cTexto);
        }

        public static DataTable Ver_Stock_Actual_ProductoxAlmacenes(int nCodigo_pr)
        {
            D_Productos Datos = new D_Productos();
            return Datos.Ver_Stock_Actual_ProductoxAlmacenes(nCodigo_pr);
        }
    }
}
