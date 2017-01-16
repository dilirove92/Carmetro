using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMETRO.Negocio.estacionamiento
{
    public class area_estacionamiento_pagos
    {
        public int id { get; set; }
        public int id_area_estacionamiento { get; set; }
        public string descripcion { get; set; }
        public decimal valor_facturado { get; set; }
    }
}
