using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Material
    {
        public string Nombre { get; set; }
        public double ModuloYoung { get; set; } // Pa
        public double ModuloVolumen { get; set; } // Pa
        public double ModuloCorte { get; set; } // Pa
        public double EsfuerzoRotura { get; set; } // Pa
        public double Compresibilidad { get; set; } // Pa^-1

        public Material()
        {
        }

        public Material(string nombre, double moduloYoung, double moduloVolumen,
                       double moduloCorte, double esfuerzoRotura)
        {
            Nombre = nombre;
            ModuloYoung = moduloYoung;
            ModuloVolumen = moduloVolumen;
            ModuloCorte = moduloCorte;
            EsfuerzoRotura = esfuerzoRotura;
            Compresibilidad = 1.0 / moduloVolumen;
        }
    }
}
