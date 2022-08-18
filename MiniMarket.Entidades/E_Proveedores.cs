using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarket.Entidades
{
    public class E_Proveedores
    {
        public int Codigo_pv { get; set; }
        public int Codigo_tdpc { get; set; }
        public string Nrodocumento_pv { get; set; }
        public string Razon_social_pv { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Codigo_sx { get; set; }
        public int Codigo_ru { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Direccion_pv { get; set; }
        public int Codigo_di { get; set; }
        public string Observacion_pv { get; set; }
    }
}
