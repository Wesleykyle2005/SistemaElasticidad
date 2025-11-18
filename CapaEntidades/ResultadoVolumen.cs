using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ResultadoVolumen
    {
        public double EsfuerzoVolumen { get; set; } // Pa (Delta P)
        public double DeformacionVolumen { get; set; } // adimensional
        public double CambioVolumen { get; set; } // m³
        public double VolumenFinal { get; set; } // m³
        public double PresionTotal { get; set; } // Pa
        public string Mensaje { get; set; }

        public ResultadoVolumen()
        {
            Mensaje = string.Empty;
        }
    }
}
