﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Lab2_repaso___Empresa_de_autos
{
    internal class Alquiler
    {
        string nit;//si tengo 1 dato en 2 clases es bueno que tengan exactamente el mismo nombre
        string placa;
        DateTime fechaAlquiler;
        DateTime fechaDevolucion;
        int kilometros;

        public string Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime FechaAlquiler { get => fechaAlquiler; set => fechaAlquiler = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public int Kilometros { get => kilometros; set => kilometros = value; }
    }
}
