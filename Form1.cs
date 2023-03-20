using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_Lab2_repaso___Empresa_de_autos
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos= new List<Vehiculo>();
        List<Alquiler> alquileres= new List<Alquiler>();
        List<Reporte> reportes= new List<Reporte>();//puede ir en el boton esta lista

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregarDatosVehiculo_Click(object sender, EventArgs e)
        {

        }
    }
}
