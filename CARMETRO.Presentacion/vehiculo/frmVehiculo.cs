using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CARMETRO.Negocio.vehiculo;

namespace CARMETRO.Presentacion.vehiculo
{
    public partial class frmVehiculo : Form
    {
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestionVehiculo gestion = new gestionVehiculo();
            Negocio.vehiculo.vehiculo vehiculo = new Negocio.vehiculo.vehiculo();

            vehiculo.placa = placatxt.Text;
            vehiculo.color = colortxt.Text;
            vehiculo.marca = marcatxt.Text;

            vehiculo.id_propietario = int.Parse(propietariocmb.Text);

            gestion.Insertar(vehiculo);
            

        }

        
    }
}
