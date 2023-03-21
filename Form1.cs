using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_Lab2_repaso___Empresa_de_autos
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Reporte> reportes = new List<Reporte>();//puede ir en el boton esta lista

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            bool localizado = false;
            for (int i = 0; i < vehiculos.Count; i++)
            {
                if(vehiculos[i].Placa == textBoxPlaca.Text)
                { 
                    localizado = true;
                }
            }
            Vehiculo pRepetida = vehiculos.Find(p => p.Placa == textBoxPlaca.Text);//lo buscara por la placa (find sirve para buscar a la persona)
            
            if (pRepetida == null)
            {
                Vehiculo vehiculo = new Vehiculo();//esto no se deja en global  para no tener problema al ingresar una segunda persona
                vehiculo.Placa = textBoxPlaca.Text;
                vehiculo.Marca = textBoxMarca.Text;
                vehiculo.Modelo = Convert.ToInt32(textBoxModelo.Text);
                vehiculo.Color = textBoxColor.Text;
                vehiculo.PrecioKilometro = Convert.ToInt32(textBoxPrecioxKilometro.Text);
                vehiculos.Add(vehiculo);
            }

            else
                MessageBox.Show(pRepetida.Placa + " placa ya existente");
        }
    }
}
