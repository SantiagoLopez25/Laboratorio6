using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    class Vehiculo
    {
        String placa;
        String marca;
        String modelo;
        String color;
        Double precioKm;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioKm { get => precioKm; set => precioKm = value; }
    }
}
