using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class ResultadoCorte
    {
        public double EsfuerzoCorte { get; set; } // Pa
        public double DeformacionCorte { get; set; } // adimensional
        public double Desplazamiento { get; set; } // m
        public double AnguloRadianes { get; set; }
        public double AnguloGrados { get; set; }
        public string Mensaje { get; set; }

        public ResultadoCorte()
        {
            Mensaje = string.Empty;
        }
    }
}
