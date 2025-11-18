using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ResultadoTension
    {
        public double EsfuerzoTension { get; set; } // Pa
        public double DeformacionTension { get; set; } // adimensional
        public double AlargamientoAbsoluto { get; set; } // m
        public double LongitudFinal { get; set; } // m
        public string Mensaje { get; set; }

        public ResultadoTension()
        {
            Mensaje = string.Empty;
        }
    }
}
