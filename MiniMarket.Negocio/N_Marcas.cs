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
    public class N_Marcas
    {
        public static DataTable Listado_ma(string cTexto)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Listado_ma(cTexto);
        }

        public static string Guardar_ma(int nOpcion, E_Marcas oMa)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Guardar_ma(nOpcion, oMa);
        }
        public static string Eliminar_ma(int nOpcion)
        {
            D_Marcas Datos = new D_Marcas();
            return Datos.Eliminar_ma(nOpcion);
        }
    }
}
