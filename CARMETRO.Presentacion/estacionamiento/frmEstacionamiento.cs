using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARMETRO.Negocio.estacionamiento;

namespace CARMETRO.Presentacion.estacionamiento
{
    public partial class frmEstacionamiento : Form
    {
        decimal valortotal = 0;
        gestionEstacionamiento gestion = new gestionEstacionamiento();
        area_estacionamiento cabecera = new area_estacionamiento();
        Negocio.vehiculo.gestionVehiculo vehiculo = new Negocio.vehiculo.gestionVehiculo();

        public frmEstacionamiento()
        {
            InitializeComponent();
            vehiculocmb.DisplayMember = "placa";
            vehiculocmb.ValueMember = "id";
            vehiculocmb.DataSource = vehiculo.ListaVehiculos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valortotal += decimal.Parse(valortxt.Text);
            dataGridView1.Rows.Add(descripcioncmb.Text, valortxt.Text);
            valortotallbl.Text = valortotal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cabecera.codigo = codigotxt.Text;
            cabecera.posicion = int.Parse(posiciontxt.Text);
            cabecera.id_piso = int.Parse(pisocmb.Text);

            Negocio.vehiculo.vehiculo ovehiculoSleccionado = (Negocio.vehiculo.vehiculo)vehiculocmb.SelectedItem;
            cabecera.id_vehiculo = ovehiculoSleccionado.id;

            cabecera.hora_entrada = DateTime.Parse("11/21/2012 " + horaentradatxt.Text + ":" + minutoentrada.Text);
            cabecera.hora_salida = DateTime.Parse("11/21/2012 " + horasalidatxt.Text + ":" + horasalidatxt.Text);
            cabecera.total_facturado = valortotal;

            int limite = 1;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
              

                if (limite<dataGridView1.Rows.Count)
                {
                    decimal facturado = decimal.Parse(item.Cells[1].Value.ToString());

                    cabecera.listadoPagos.Add(new area_estacionamiento_pagos { descripcion = item.Cells[0].Value.ToString(), valor_facturado = facturado });
                }

                limite++;

            }

            gestion.InsertarEstacionamiento(cabecera);




        }

        private void gestiónDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CARMETRO.Presentacion.vehiculo.frmVehiculo  frmVehiculos = new CARMETRO.Presentacion.vehiculo.frmVehiculo();
            frmVehiculos.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CARMETRO.Presentacion.reporte.frmReporte frmReportes = new reporte.frmReporte();
            frmReportes.Show();
        }

       
    }
}
