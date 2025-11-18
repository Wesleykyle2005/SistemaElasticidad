using System;
using CapaEntidades;

namespace CapaNegocio
{
    public class CalculoVolumen
    {
        public ResultadoVolumen CalcularCambioVolumen(double presionInicial,
                                                     double cambioPresion,
                                                     double volumenInicial,
                                                     double moduloVolumen)
        {
            ResultadoVolumen resultado = new ResultadoVolumen();

            try
            {
                if (volumenInicial <= 0 || moduloVolumen <= 0)
                {
                    resultado.Mensaje = "El volumen inicial y el módulo de volumen deben ser positivos.";
                    return resultado;
                }

                // Esfuerzo de volumen: Δp
                resultado.EsfuerzoVolumen = cambioPresion;

                // Presión total: p = p₀ + Δp
                resultado.PresionTotal = presionInicial + cambioPresion;

                // Deformación por volumen: ΔV / V₀
                // De B = -Δp / (ΔV/V₀) → ΔV/V₀ = -Δp / B
                resultado.DeformacionVolumen = -cambioPresion / moduloVolumen;

                // Cambio de volumen: ΔV = (ΔV/V₀) * V₀
                resultado.CambioVolumen = resultado.DeformacionVolumen * volumenInicial;

                // Volumen final: Vf = V₀ + ΔV
                resultado.VolumenFinal = volumenInicial + resultado.CambioVolumen;

                if (resultado.CambioVolumen < 0)
                {
                    resultado.Mensaje = $"El volumen se reduce en {Math.Abs(resultado.CambioVolumen):E3} m³ " +
                                       $"debido al aumento de presión.";
                }
                else
                {
                    resultado.Mensaje = $"El volumen aumenta en {resultado.CambioVolumen:E3} m³ " +
                                       $"debido a la disminución de presión.";
                }
            }
            catch (Exception ex)
            {
                resultado.Mensaje = $"Error en el cálculo: {ex.Message}";
            }

            return resultado;
        }

        public double CalcularCompresibilidad(double moduloVolumen)
        {
            // k = 1 / B
            return 1.0 / moduloVolumen;
        }

        public double CalcularModuloVolumenDesdeLiquido(double compresibilidad)
        {
            // B = 1 / k
            return 1.0 / compresibilidad;
        }

        public double CalcularCambioPresionNecesario(double cambioVolumenDeseado,
                                                     double volumenInicial,
                                                     double moduloVolumen)
        {
            // Δp = -B * (ΔV / V₀)
            return -moduloVolumen * (cambioVolumenDeseado / volumenInicial);
        }
    }
}