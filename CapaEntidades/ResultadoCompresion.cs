using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ResultadoCompresion
    {
        public double EsfuerzoCompresion { get; set; } // Pa
        public double DeformacionCompresion { get; set; } // adimensional
        public double AcortamientoAbsoluto { get; set; } // m
        public double LongitudFinal { get; set; } // m
        public string Mensaje { get; set; }

        public ResultadoCompresion()
        {
            Mensaje = string.Empty;
        }
    }
}
