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
            LeerClientes();
            MostrarClientes();

            LeerAlquileres();
            MostrarAlquileres();

            LeerVehiculos("Vehiculos.txt");



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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GuardarVehiculos("Vehiculos.txt");
            MessageBox.Show("Archivo guardado correctamente");
        }
        private void GuardarVehiculos(string fileName)//para guardar los datos ingresados en un archivo de texto
        {
            FileStream stream = new FileStream("DatosVehiculo.txt", FileMode.Open, FileAccess.Read); //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);

            foreach (var vehiculo in vehiculos)
            {
                writer.WriteLine(vehiculo.Placa);
                writer.WriteLine(vehiculo.Marca);
                writer.WriteLine(vehiculo.Modelo);
                writer.WriteLine(vehiculo.Color);
                writer.WriteLine(vehiculo.PrecioKilometro);
            }
            writer.Close();//Cerrar el archivo
        }
        private void LeerVehiculos(string filename)//lee el archivo vehiculo.text
        {
            FileStream stream = new FileStream("DatosVehiculo.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = reader.ReadLine(); 
                vehiculo.Marca = reader.ReadLine();
                vehiculo.Modelo = Convert.ToInt32(reader.ReadLine());
                vehiculo.Color = reader.ReadLine();
                vehiculo.PrecioKilometro = Convert.ToInt32(reader.ReadLine());
                vehiculos.Add(vehiculo);
            }
            reader.Close();
        }

        private void buttonMostrarDatosVehiculo_Click(object sender, EventArgs e)
        {
            dataGridViewDatosVehiculo.DataSource = null;
            dataGridViewDatosVehiculo.DataSource = vehiculos;// su fuente de datos es vehiculos
            dataGridViewDatosVehiculo.Refresh();
        }

        private void LeerClientes()
        {
            FileStream stream = new FileStream("Cliente.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Cliente cliente = new Cliente();
                cliente.Nit = reader.ReadLine();
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();
                clientes.Add(cliente);
            }
            reader.Close();
        }

        private void MostrarClientes()
        {
            dataGridViewCliente.DataSource = null;
            dataGridViewCliente.DataSource = clientes;
            dataGridViewCliente.Refresh();
        }

        private void LeerAlquileres()
        {
            FileStream stream = new FileStream("Alquiler.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Alquiler alquiler = new Alquiler();
                alquiler.Nit = reader.ReadLine();
                alquiler.Placa = reader.ReadLine();
                alquiler.FechaAlquiler = Convert.ToDateTime(reader.ReadLine());
                alquiler.FechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                alquiler.Kilometros = Convert.ToInt32(reader.ReadLine());
                alquileres.Add(alquiler);
            }
            reader.Close();
        }

        private void MostrarAlquileres()
        {
            dataGridViewAlquiler.DataSource = null;
            dataGridViewAlquiler.DataSource = alquileres;
            dataGridViewAlquiler.Refresh();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buttonMostrarAlquilerTop_Click(object sender, EventArgs e)
        {

            MessageBox.Show("");
        }

        private void buttonMostrarDatosReporte_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alquileres.Count; i++)
            {
                //Buscar el NIT del alquiler en el NIT de Clientes
                for (int j = 0; j < clientes.Count; j++)
                {
                    if (alquileres[i].Nit == clientes[j].Nit)
                    {
                        //guardar los datos en el reporte
                        FileStream stream = new FileStream("Reporte.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter writer = new StreamWriter(stream);

                        foreach (var reporte in reportes)
                        {
                            //writer.WriteLine(reporte.Nombre;
                            writer.WriteLine(reporte.Placa);
                            writer.WriteLine(reporte.Marca);
                            writer.WriteLine(reporte.FechaDevolucion);
                            writer.WriteLine(reporte.Total);
                        }
                        writer.Close();//Cerrar el archivo
                    }
                }
                //Buscar la Placa del alquiler en la Placa de Vehículo
                for (int k = 0; k < vehiculos.Count; k++)
                {
                    if (alquileres[i].Placa == vehiculos[k].Placa)
                    {
                        //guardar los datos en el reporte
                        FileStream stream = new FileStream("Reporte.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter writer = new StreamWriter(stream);

                        foreach (var reporte in reportes)
                        {
                            //writer.WriteLine(reporte.Nombre;
                            writer.WriteLine(reporte.Placa);
                            writer.WriteLine(reporte.Marca);
                            writer.WriteLine(reporte.FechaDevolucion);
                            writer.WriteLine(reporte.Total);
                        }
                        writer.Close();//Cerrar el archivo
                    }
                }
            }


        }
 
    }
    
}
