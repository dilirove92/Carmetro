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

namespace CARMETRO.Presentacion.reporte
{
    public partial class frmReporte : Form
    {
        gestionEstacionamiento estacionamiento = new gestionEstacionamiento();

        public frmReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = estacionamiento.ValorFacturado("IVA");
            label2.Text = estacionamiento.facturadoConcepto.ToString();
        }
    }
}
