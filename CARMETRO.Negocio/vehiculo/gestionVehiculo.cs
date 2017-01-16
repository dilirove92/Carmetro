using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CARMETRO.Datos;

namespace CARMETRO.Negocio.vehiculo
{
    public class gestionVehiculo
    {
        ParqueoEntity modelo = new ParqueoEntity();
        Datos.vehiculo entityVehiculo = new Datos.vehiculo();
        

        public int Insertar(vehiculo oVehiculo)
        {
            entityVehiculo.placa = oVehiculo.placa;
            entityVehiculo.color = oVehiculo.color;
            entityVehiculo.marca = oVehiculo.marca;
            entityVehiculo.id_propietario = oVehiculo.id_propietario;
            
            modelo.vehiculoes.Add(entityVehiculo);
            modelo.SaveChanges();
            
            return entityVehiculo.id;
        }

        public ListadoVehiculo ListaVehiculos()
        {
            ListadoVehiculo listado = new ListadoVehiculo();

            foreach (var item in modelo.vehiculoes.AsEnumerable())
            {
                listado.Add(new vehiculo { id = item.id, placa = item.placa, color = item.color, marca = item.marca, id_propietario = item.id_propietario });            
            }

            return listado;
        }


    }
}
