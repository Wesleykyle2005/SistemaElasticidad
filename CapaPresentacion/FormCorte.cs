using System;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FormCorte : Form
    {
        private MaterialRepositorio materialRepo;
        private CalculoCorte calculoCorte;

        public FormCorte()
        {
            InitializeComponent();
            materialRepo = new MaterialRepositorio();
            calculoCorte = new CalculoCorte();
        }

        private void FormCorte_Load(object sender, EventArgs e)
        {
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            cboMaterial.Items.Clear();
            var materiales = materialRepo.ObtenerTodos();
            foreach (var material in materiales)
            {
                if (material.ModuloCorte > 0)
                {
                    cboMaterial.Items.Add(material.Nombre);
                }
            }
            if (cboMaterial.Items.Count > 0)
            {
                cboMaterial.SelectedIndex = 0;
            }
        }

        private void cboMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaterial.SelectedItem != null)
            {
                var material = materialRepo.ObtenerPorNombre(cboMaterial.SelectedItem.ToString());
                if (material != null)
                {
                    txtModuloCorte.Text = material.ModuloCorte.ToString("E3");
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtFuerza.Text, out double fuerza))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para la fuerza.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtArea.Text, out double area))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el área.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtAltura.Text, out double altura))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para la altura.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtModuloCorte.Text, out double moduloCorte))
                {
                    MessageBox.Show("Seleccione un material válido.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var resultado = calculoCorte.CalcularCorte(fuerza, area, altura, moduloCorte);
                MostrarResultados(resultado, fuerza, area, altura, moduloCorte);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el cálculo: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResultados(ResultadoCorte resultado, double fuerza,
                                     double area, double altura, double moduloCorte)
        {
            txtResultados.Clear();
            txtResultados.AppendText("═══════════════════════════════════════════════════════\r\n");
            txtResultados.AppendText("          RESULTADOS DEL CÁLCULO DE CORTE\r\n");
            txtResultados.AppendText("═══════════════════════════════════════════════════════\r\n\r\n");

            txtResultados.AppendText("DATOS DE ENTRADA:\r\n");
            txtResultados.AppendText("───────────────────────────────────────────────────────\r\n");
            txtResultados.AppendText($"Material: {cboMaterial.SelectedItem}\r\n");
            txtResultados.AppendText($"Fuerza paralela (F∥): {fuerza:N2} N\r\n");
            txtResultados.AppendText($"Área: {area:E3} m²\r\n");
            txtResultados.AppendText($"Altura (h): {altura:N4} m\r\n");
            txtResultados.AppendText($"Módulo de corte (S): {moduloCorte:E3} Pa\r\n\r\n");

            txtResultados.AppendText("RESULTADOS CALCULADOS:\r\n");
            txtResultados.AppendText("───────────────────────────────────────────────────────\r\n");
            txtResultados.AppendText($"Esfuerzo de corte (τ):\r\n");
            txtResultados.AppendText($"  {resultado.EsfuerzoCorte:E3} Pa\r\n");
            txtResultados.AppendText($"  {resultado.EsfuerzoCorte / 1e6:N2} MPa\r\n\r\n");

            txtResultados.AppendText($"Deformación por corte (γ):\r\n");
            txtResultados.AppendText($"  {resultado.DeformacionCorte:E6} (adimensional)\r\n\r\n");

            txtResultados.AppendText($"Desplazamiento (x):\r\n");
            txtResultados.AppendText($"  {resultado.Desplazamiento:E6} m\r\n");
            txtResultados.AppendText($"  {resultado.Desplazamiento * 1000:N6} mm\r\n\r\n");

            txtResultados.AppendText($"Ángulo de deformación:\r\n");
            txtResultados.AppendText($"  {resultado.AnguloRadianes:E6} radianes\r\n");
            txtResultados.AppendText($"  {resultado.AnguloGrados:N6} grados\r\n\r\n");

            txtResultados.AppendText("FÓRMULAS UTILIZADAS:\r\n");
            txtResultados.AppendText("───────────────────────────────────────────────────────\r\n");
            txtResultados.AppendText("τ = F∥ / A\r\n");
            txtResultados.AppendText("γ = x / h\r\n");
            txtResultados.AppendText("S = τ / γ\r\n");
            txtResultados.AppendText("x = (τ / S) × h\r\n");
            txtResultados.AppendText("θ ≈ γ (para ángulos pequeños)\r\n");
            txtResultados.AppendText("═══════════════════════════════════════════════════════\r\n");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFuerza.Clear();
            txtArea.Clear();
            txtAltura.Clear();
            txtResultados.Clear();
            if (cboMaterial.Items.Count > 0)
            {
                cboMaterial.SelectedIndex = 0;
            }
            txtFuerza.Focus();
        }
    }
}