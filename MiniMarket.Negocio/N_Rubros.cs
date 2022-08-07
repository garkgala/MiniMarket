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
    public class N_Rubros
    {
        public static DataTable Listado_ru(string cTexto)
        {
            D_Rubros Datos = new D_Rubros();
            return Datos.Listado_ru(cTexto);
        }

        public static string Guardar_ru(int nOpcion, E_Rubros oRu)
        {
            D_Rubros Datos = new D_Rubros();
            return Datos.Guardar_ru(nOpcion, oRu);
        }
        public static string Eliminar_ru(int nOpcion)
        {
            D_Rubros Datos = new D_Rubros();
            return Datos.Eliminar_ru(nOpcion);
        }
    }
}
