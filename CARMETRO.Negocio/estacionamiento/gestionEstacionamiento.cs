using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CARMETRO.Datos;

namespace CARMETRO.Negocio.estacionamiento
{
    public class gestionEstacionamiento
    {
        ParqueoEntity modelo = new ParqueoEntity();
        Datos.area_estacionamiento entityCabecera = new Datos.area_estacionamiento();
        Datos.area_estacionamiento_pagos entityreporte = new Datos.area_estacionamiento_pagos();
        Datos.area_estacionamiento_pagos entityDetalle = new Datos.area_estacionamiento_pagos();
        public decimal facturadoConcepto = 0;

        public int InsertarEstacionamiento(area_estacionamiento oEstacionamiento)
        {
            entityCabecera.codigo = oEstacionamiento.codigo;
            entityCabecera.posicion = oEstacionamiento.posicion;
            entityCabecera.id_piso = oEstacionamiento.id_piso;
            entityCabecera.id_vehiculo = oEstacionamiento.id_vehiculo;
            entityCabecera.hora_entrada = oEstacionamiento.hora_entrada;
            entityCabecera.hora_salida = oEstacionamiento.hora_salida;
            entityCabecera.total_facturado = oEstacionamiento.total_facturado;
            
            foreach (var item in oEstacionamiento.listadoPagos)            
                entityCabecera.area_estacionamiento_pagos.Add(new Datos.area_estacionamiento_pagos { descripcion_pago = item.descripcion, valor_facturado = item.valor_facturado });
            

            modelo.area_estacionamiento.Add(entityCabecera);

            modelo.SaveChanges();

            return entityCabecera.id;
        }

        public List<area_estacionamiento_pagos> ValorFacturado(string Cadena)
        {
            List<area_estacionamiento_pagos> listadopagos = new List<area_estacionamiento_pagos>();
            
            foreach (var item in modelo.area_estacionamiento_pagos.Where(c=>c.descripcion_pago==Cadena).AsEnumerable())
            {
                listadopagos.Add(new area_estacionamiento_pagos { id_area_estacionamiento = item.id_area_estacionamiento, descripcion = item.descripcion_pago, valor_facturado = item.valor_facturado });

                facturadoConcepto += item.valor_facturado;
            }

            return listadopagos;


        }
    }
}
