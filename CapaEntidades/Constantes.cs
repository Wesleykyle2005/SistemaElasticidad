using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public static class Constantes
    {
        // Conversiones de presión
        public const double PA_A_PSI = 1.450e-4;
        public const double PSI_A_PA = 6895.0;
        public const double PA_A_ATM = 9.8692e-6;
        public const double ATM_A_PA = 101325.0;

        // Límites típicos (porcentaje del módulo)
        public const double FACTOR_LIMITE_PROPORCIONAL = 0.5;
        public const double FACTOR_LIMITE_ELASTICO = 0.7;
    }
}
