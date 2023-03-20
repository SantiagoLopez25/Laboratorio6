using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    class Rentado 

    {
        int nit;
        string nombre;
        string placa;
        string marca;
        string modelo;
        string color;
        double precioKm;
        string fechaAlq;
        string fechaDev;
        double kms;
        double totalAPagar;

        public int Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioKm { get => precioKm; set => precioKm = value; }
        public string FechaAlq { get => fechaAlq; set => fechaAlq = value; }
        public string FechaDev { get => fechaDev; set => fechaDev = value; }
        public double Kms { get => kms; set => kms = value; }
        public double TotalAPagar { get => totalAPagar; set => totalAPagar = value; }
    }
}
