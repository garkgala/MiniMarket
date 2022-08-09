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
    public class N_Distritos
    {
        public static DataTable Listado_di(string cTexto)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Listado_di(cTexto);
        }

        public static DataTable Listado_po_di(string cTexto)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Listado_po_di(cTexto);
        }

        public static string Guardar_di(int nOpcion, E_Distritos oDi)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Guardar_di(nOpcion, oDi);
        }
        public static string Eliminar_di(int nOpcion)
        {
            D_Distritos Datos = new D_Distritos();
            return Datos.Eliminar_di(nOpcion);
        }
    }
}
