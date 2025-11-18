using CapaEntidades;

namespace CapaNegocio
{
    public class ConversionUnidades
    {
        // Conversiones de presión
        public double PascalAPsi(double pascal)
        {
            return pascal * Constantes.PA_A_PSI;
        }

        public double PsiAPascal(double psi)
        {
            return psi * Constantes.PSI_A_PA;
        }

        public double PascalAAtm(double pascal)
        {
            return pascal * Constantes.PA_A_ATM;
        }

        public double AtmAPascal(double atm)
        {
            return atm * Constantes.ATM_A_PA;
        }

        // Conversiones de longitud
        public double MetrosAMilimetros(double metros)
        {
            return metros * 1000.0;
        }

        public double MilimetrosAMetros(double milimetros)
        {
            return milimetros / 1000.0;
        }

        public double MetrosACentimetros(double metros)
        {
            return metros * 100.0;
        }

        public double CentimetrosAMetros(double centimetros)
        {
            return centimetros / 100.0;
        }

        // Conversiones de área
        public double MetrosCuadradosAMilimetrosCuadrados(double m2)
        {
            return m2 * 1e6;
        }

        public double MilimetrosCuadradosAMetrosCuadrados(double mm2)
        {
            return mm2 / 1e6;
        }

        // Conversiones de fuerza
        public double NewtonsAKilonewtons(double newtons)
        {
            return newtons / 1000.0;
        }

        public double KilonewtonsANewtons(double kilonewtons)
        {
            return kilonewtons * 1000.0;
        }
    }
}