using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMETRO.Negocio.vehiculo
{

    public class ListadoVehiculo : List<vehiculo>
    {
    }

    public class vehiculo
    {
        public int id { get; set; }
        public string placa { get; set; }
        public string color { get; set; }
        public string marca { get; set; }
        public int id_propietario { get; set; }


    }
}
