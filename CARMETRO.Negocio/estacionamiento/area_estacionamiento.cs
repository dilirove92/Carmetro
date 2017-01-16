using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMETRO.Negocio.estacionamiento
{
    public class area_estacionamiento
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public int posicion { get; set; }
        public int id_piso { get; set; }
        public int id_vehiculo { get; set; }
        public DateTime hora_entrada { get; set; }
        public DateTime hora_salida { get; set; }
        public decimal total_facturado { get; set; }

        public List<area_estacionamiento_pagos> listadoPagos { get; set; }

        public area_estacionamiento()
        {
            listadoPagos = new List<area_estacionamiento_pagos>();
        }
    }
}
