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

namespace Laboratorio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        private void buttonGuardarV_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            bool repetido = false;
            for(int i=0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].Placa == textBoxPlaca.Text)
                {
                    repetido = true;
                }
            }
           
            if(!repetido){
                vehiculo.Placa = textBoxPlaca.Text;
                vehiculo.Marca = textBoxMarca.Text;
                vehiculo.Modelo = textBoxModelo.Text;
                vehiculo.Color = textBoxColor.Text;
                vehiculo.PrecioKm = Convert.ToDouble(textBoxKms.Text);
                vehiculos.Add(vehiculo);
                Guardar("vehiculos.txt");
            }
            else
            {
                MessageBox.Show("Ese vehículo ya existe");
            }
            textBoxPlaca.Text = "";
            textBoxMarca.Text = "";
            textBoxColor.Text = "";
            textBoxKms.Text = "";
            textBoxModelo.Text = "";
            mostrarVehículos();
            unir();
        }
        private void Guardar(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var vehiculo in vehiculos)//Se usa para las listas, (va recorriendo la lista, agarra cada elemento y lo copia en la variable )
            {
                writer.WriteLine(vehiculo.Placa);
                writer.WriteLine(vehiculo.Marca);
                writer.WriteLine(vehiculo.Modelo);
                writer.WriteLine(vehiculo.Color);
                writer.WriteLine(vehiculo.PrecioKm);
    
            }
            writer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abrirVehiculo("vehiculos.txt");
            abrirCliente("clientes.txt");
            abrirAlquiler("alquieres.txt");
            mostrarVehículos();
            mostrarClientes();
            unir();
            mostrarAlquiler();

        }
        List<Cliente> clientes = new List<Cliente>();

        private void abrirVehiculo(string fileName)
        {
            //if(File.Exists())
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
               Vehiculo vehiculo= new Vehiculo();
                vehiculo.Placa = reader.ReadLine();
                vehiculo.Marca = reader.ReadLine();
                vehiculo.Modelo = reader.ReadLine();
                vehiculo.Color= reader.ReadLine();
                vehiculo.PrecioKm=  Convert.ToDouble(reader.ReadLine());


                vehiculos.Add(vehiculo);
            }

            reader.Close();
        }
        private void abrirCliente(string fileName)
        {
            //if(File.Exists())
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                Cliente cliente = new Cliente();
                cliente.Nit = Convert.ToInt32(reader.ReadLine());
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();
                
                clientes.Add(cliente);
            }

            reader.Close();
        }
        List<Alquiler> alquileres = new List<Alquiler>();
        private void abrirAlquiler(string fileName)
        {
            //if(File.Exists())
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            //gegsgsgsg

            while (reader.Peek() > -1)
            {
                Alquiler alquiler = new Alquiler();
                alquiler.Nit = Convert.ToInt32(reader.ReadLine());
                alquiler.Placa= reader.ReadLine();
                alquiler.FechaAlq = reader.ReadLine();
                alquiler.FechaDev = reader.ReadLine();
                alquiler.Kms = Convert.ToDouble(reader.ReadLine());
                alquileres.Add(alquiler);
                //jsj
            }

            reader.Close();
        }
        private void mostrarVehículos()
        {
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = vehiculos;
            dataGridViewVehiculos.Refresh();
        }
        private void mostrarClientes()
        {
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientes;
            dataGridViewClientes.Refresh();
        }
        private void mostrarAlquiler()
        {
            dataGridViewAlquiler.DataSource = null;
            dataGridViewAlquiler.DataSource = rentas;
            dataGridViewAlquiler.Refresh();
        }
        List<Rentado> rentas = new List<Rentado>();
        private void unir()
        {
            double a = 0;
            for(int i=0; i < alquileres.Count; i++)
            {
                Rentado renta = new Rentado();
                renta.FechaAlq = alquileres[i].FechaAlq;
                renta.FechaDev = alquileres[i].FechaDev;
                renta.Kms = alquileres[i].Kms;
                if (renta.Kms > a) a = renta.Kms;
                for (int j=0; j<vehiculos.Count; j++)
                {
                    if (alquileres[i].Placa == vehiculos[j].Placa)
                    {
                        renta.Placa = alquileres[i].Placa;
                        renta.Marca = vehiculos[j].Marca;
                        renta.Modelo = vehiculos[j].Modelo;
                        renta.Color = vehiculos[j].Color;
                        renta.PrecioKm = vehiculos[j].PrecioKm;
                        renta.TotalAPagar = renta.PrecioKm * renta.Kms;
                    }
                }
                for (int j = 0; j < clientes.Count; j++)
                {
                    if (alquileres[i].Nit == clientes[j].Nit)
                    {
                        renta.Nit = alquileres[i].Nit;
                        renta.Nombre = clientes[j].Nombre;
                    }
                }
                rentas.Add(renta);
            }
           
            labelMasKm.Text ="Mas km recorridos:"+ a.ToString();
           // Rentado mayor = rentas.OrderByDescending(a => a.Kms).First();
           // labelMasKm.Text = mayor.ToString() ;

        }

        private void masKm()
        {
            List<Alquiler> mayorKm = new List<Alquiler>();
            mayorKm = alquileres;
            //mayorKm.Sort
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            unir();
            mostrarAlquiler();
        }
    }
}
