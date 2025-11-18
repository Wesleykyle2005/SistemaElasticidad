using System;
using CapaEntidades;

namespace CapaNegocio
{
    public class CalculoCorte
    {
        public ResultadoCorte CalcularCorte(double fuerzaParalela, double area,
                                           double altura, double moduloCorte)
        {
            ResultadoCorte resultado = new ResultadoCorte();

            try
            {
                if (area <= 0 || altura <= 0 || moduloCorte <= 0)
                {
                    resultado.Mensaje = "Los valores de área, altura y módulo de corte deben ser positivos.";
                    return resultado;
                }

                // Esfuerzo de corte: τ = F∥ / A
                resultado.EsfuerzoCorte = fuerzaParalela / area;

                // Deformación por corte: γ = x / h
                // De la ley de Hooke: S = τ / γ → γ = τ / S
                resultado.DeformacionCorte = resultado.EsfuerzoCorte / moduloCorte;

                // Desplazamiento: x = γ * h
                resultado.Desplazamiento = resultado.DeformacionCorte * altura;

                // Ángulo en radianes (para ángulos pequeños: γ ≈ tan(θ) ≈ θ)
                resultado.AnguloRadianes = resultado.DeformacionCorte;

                // Ángulo en grados
                resultado.AnguloGrados = resultado.AnguloRadianes * (180.0 / Math.PI);

                resultado.Mensaje = "Cálculo de corte exitoso.";
            }
            catch (Exception ex)
            {
                resultado.Mensaje = $"Error en el cálculo: {ex.Message}";
            }

            return resultado;
        }

        public double CalcularFuerzaCortanteMaxima(double area, double esfuerzoCortanteMax)
        {
            // F = τ_max * A
            return esfuerzoCortanteMax * area;
        }

        public double CalcularModuloCorteDesdeYoung(double moduloYoung, double coeficientePoisson)
        {
            // S = E / (2 * (1 + ν))
            return moduloYoung / (2.0 * (1.0 + coeficientePoisson));
        }
    }
}