using System;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FormVolumen : Form
    {
        private MaterialRepositorio materialRepo;
        private CalculoVolumen calculoVolumen;

        public FormVolumen()
        {
            InitializeComponent();
            materialRepo = new MaterialRepositorio();
            calculoVolumen = new CalculoVolumen();
        }

        private void FormVolumen_Load(object sender, EventArgs e)
        {
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            cboMaterial.Items.Clear();
            var materiales = materialRepo.ObtenerTodos();
            foreach (var material in materiales)
            {
                if (material.ModuloVolumen > 0)
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
                    txtModuloVolumen.Text = material.ModuloVolumen.ToString("E3");
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtPresionInicial.Text, out double presionInicial))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para la presión inicial.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtCambioPresion.Text, out double cambioPresion))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el cambio de presión.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtVolumenInicial.Text, out double volumenInicial))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el volumen inicial.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtModuloVolumen.Text, out double moduloVolumen))
                {
                    MessageBox.Show("Seleccione un material válido.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var resultado = calculoVolumen.CalcularCambioVolumen(presionInicial, cambioPresion,
                                                                     volumenInicial, moduloVolumen);
                MostrarResultados(resultado, presionInicial, cambioPresion, volumenInicial, moduloVolumen);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el cálculo: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResultados(ResultadoVolumen resultado, double presionInicial,
                                     double cambioPresion, double volumenInicial, double moduloVolumen)
        {
            txtResultados.Clear();
            txtResultados.AppendText("═══════════════════════════════════════════════════════\r\n");
            txtResultados.AppendText("     RESULTADOS DE DEFORMACIÓN VOLUMÉTRICA\r\n");
            txtResultados.AppendText("═══════════════════════════════════════════════════════\r\n\r\n");

            txtResultados.AppendText("DATOS DE ENTRADA:\r\n");
            txtResultados.AppendText("───────────────────────────────────────────────────────\r\n");
            txtResultados.AppendText($"Material: {cboMaterial.SelectedItem}\r\n");
            txtResultados.AppendText($"Presión inicial (p₀): {presionInicial:E3} Pa\r\n");
            txtResultados.AppendText($"Cambio de presión (Δp): {cambioPresion:E3} Pa\r\n");
            txtResultados.AppendText($"Volumen inicial (V₀): {volumenInicial:E3} m³\r\n");
            txtResultados.AppendText($"Módulo de volumen (B): {moduloVolumen:E3} Pa\r\n\r\n");

            txtResultados.AppendText("RESULTADOS CALCULADOS:\r\n");
            txtResultados.AppendText("───────────────────────────────────────────────────────\r\n");
            txtResultados.AppendText($"Esfuerzo de volumen (Δp):\r\n");
            txtResultados.AppendText($"  {resultado.EsfuerzoVolumen:E3} Pa\r\n");
            txtResultados.AppendText($"  {resultado.EsfuerzoVolumen / 1e6:N2} MPa\r\n\r\n");

            txtResultados.AppendText($"Presión total (p):\r\n");
            txtResultados.AppendText($"  {resultado.PresionTotal:E3} Pa\r\n");
            txtResultados.AppendText($"  {resultado.PresionTotal / 101325:N4} atm\r\n\r\n");

            txtResultados.AppendText($"Deformación volumétrica (ΔV/V₀):\r\n");
            txtResultados.AppendText($"  {resultado.DeformacionVolumen:E6} (adimensional)\r\n");
            txtResultados.AppendText($"  {resultado.DeformacionVolumen * 100:N6} %\r\n\r\n");

            txtResultados.AppendText($"Cambio de volumen (ΔV):\r\n");
            txtResultados.AppendText($"  {resultado.CambioVolumen:E6} m³\r\n");
            if (Math.Abs(resultado.CambioVolumen) < 1)
            {
                txtResultados.AppendText($"  {resultado.CambioVolumen * 1e6:N6} cm³\r\n\r\n");
            }

            txtResultados.AppendText($"Volumen final (Vf):\r\n");
            txtResultados.AppendText($"  {resultado.VolumenFinal:E6} m³\r\n\r\n");

            double compresibilidad = calculoVolumen.CalcularCompresibilidad(moduloVolumen);
            txtResultados.AppendText($"Compresibilidad (k):\r\n");
            txtResultados.AppendText($"  {compresibilidad:E6} Pa⁻¹\r\n\r\n");

            txtResultados.AppendText("FÓRMULAS UTILIZADAS:\r\n");
            txtResultados.AppendText("───────────────────────────────────────────────────────\r\n");
            txtResultados.AppendText("Esfuerzo de volumen = Δp\r\n");
            txtResultados.AppendText("p = p₀ + Δp\r\n");
            txtResultados.AppendText("B = -Δp / (ΔV/V₀)\r\n");
            txtResultados.AppendText("ΔV/V₀ = -Δp / B\r\n");
            txtResultados.AppendText("ΔV = (ΔV/V₀) × V₀\r\n");
            txtResultados.AppendText("Vf = V₀ + ΔV\r\n");
            txtResultados.AppendText("k = 1 / B\r\n");
            txtResultados.AppendText("═══════════════════════════════════════════════════════\r\n");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPresionInicial.Text = "101325";
            txtCambioPresion.Clear();
            txtVolumenInicial.Clear();
            txtResultados.Clear();
            if (cboMaterial.Items.Count > 0)
            {
                cboMaterial.SelectedIndex = 0;
            }
            txtCambioPresion.Focus();
        }
    }
}