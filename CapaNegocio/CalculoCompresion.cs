using System;
using CapaEntidades;

namespace CapaNegocio
{
    public class CalculoCompresion
    {
        public ResultadoCompresion CalcularCompresion(double fuerza, double area,
                                                     double longitudInicial,
                                                     double moduloYoung)
        {
            ResultadoCompresion resultado = new ResultadoCompresion();

            try
            {
                if (area <= 0 || longitudInicial <= 0 || moduloYoung <= 0)
                {
                    resultado.Mensaje = "Los valores de área, longitud inicial y módulo de Young deben ser positivos.";
                    return resultado;
                }

                // Esfuerzo de compresión: σ = F⊥ / A
                resultado.EsfuerzoCompresion = fuerza / area;

                // Deformación por compresión: ε = ΔL / L₀
                resultado.DeformacionCompresion = resultado.EsfuerzoCompresion / moduloYoung;

                // Acortamiento absoluto: ΔL = ε * L₀ (positivo aunque sea reducción)
                resultado.AcortamientoAbsoluto = resultado.DeformacionCompresion * longitudInicial;

                // Longitud final: Lf = L₀ - ΔL
                resultado.LongitudFinal = longitudInicial - resultado.AcortamientoAbsoluto;

                // Verificar límite elástico
                double limiteElastico = moduloYoung * Constantes.FACTOR_LIMITE_ELASTICO;

            }
            catch (Exception ex)
            {
                resultado.Mensaje = $"Error en el cálculo: {ex.Message}";
            }

            return resultado;
        }

        public double CalcularEsfuerzoCriticoColumna(double moduloYoung, double inercia,
                                                     double longitud, double factorSoporte)
        {
            // Fórmula de Euler: σ_cr = (π² * E * I) / (k * L)²
            return (Math.PI * Math.PI * moduloYoung * inercia) /
                   Math.Pow(factorSoporte * longitud, 2);
        }
    }
}