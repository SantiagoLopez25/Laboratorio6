using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    class Alquiler:Vehiculo
    {
        int nit;
        string nombre;
        string fechaAlq;
        string fechaDev;
        double kms;
        double totalAPagar;

        public int Nit { get => nit; set => nit = value; }
      
        public string FechaAlq { get => fechaAlq; set => fechaAlq = value; }
        public string FechaDev { get => fechaDev; set => fechaDev = value; }
        public double Kms { get => kms; set => kms = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double TotalAPagar { get => totalAPagar; set => totalAPagar = value; }
    }
}
