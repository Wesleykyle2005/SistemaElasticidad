using System;
using CapaEntidades;

namespace CapaNegocio
{
    public class CalculoTension
    {
        public ResultadoTension CalcularTension(double fuerza, double area,
                                               double longitudInicial,
                                               double moduloYoung)
        {
            ResultadoTension resultado = new ResultadoTension();

            try
            {
                // Validaciones
                if (area <= 0 || longitudInicial <= 0 || moduloYoung <= 0)
                {
                    resultado.Mensaje = "Los valores de área, longitud inicial y módulo de Young deben ser positivos.";
                    return resultado;
                }

                // Esfuerzo de tensión: σ = F⊥ / A
                resultado.EsfuerzoTension = fuerza / area;

                // Deformación por tensión: ε = ΔL / L₀
                // De la ley de Hooke: Y = σ / ε → ε = σ / Y
                resultado.DeformacionTension = resultado.EsfuerzoTension / moduloYoung;

                // Alargamiento absoluto: ΔL = ε * L₀
                resultado.AlargamientoAbsoluto = resultado.DeformacionTension * longitudInicial;

                // Longitud final: Lf = L₀ + ΔL
                resultado.LongitudFinal = longitudInicial + resultado.AlargamientoAbsoluto;

                // Verificar límite elástico (aproximadamente 70% del módulo)
               
            }
            catch (Exception ex)
            {
                resultado.Mensaje = $"Error en el cálculo: {ex.Message}";
            }

            return resultado;
        }

        public double CalcularFuerzaNecesaria(double alargamientoDeseado, double area,
                                             double longitudInicial, double moduloYoung)
        {
            // F = (Y * A * ΔL) / L₀
            return (moduloYoung * area * alargamientoDeseado) / longitudInicial;
        }

        public double CalcularAreaNecesaria(double fuerza, double esfuerzoMaximo)
        {
            // A = F / σ
            return fuerza / esfuerzoMaximo;
        }
    }
}