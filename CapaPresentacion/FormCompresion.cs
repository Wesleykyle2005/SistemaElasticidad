using System;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FormCompresion : Form
    {
        private MaterialRepositorio materialRepo;
        private CalculoCompresion calculoCompresion;

        public FormCompresion()
        {
            InitializeComponent();
            materialRepo = new MaterialRepositorio();
            calculoCompresion = new CalculoCompresion();
        }

        private void FormCompresion_Load(object sender, EventArgs e)
        {
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            cboMaterial.Items.Clear();
            var materiales = materialRepo.ObtenerTodos();
            foreach (var material in materiales)
            {
                if (material.ModuloYoung > 0)
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
                    txtModuloYoung.Text = material.ModuloYoung.ToString("E3");
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

                if (!double.TryParse(txtLongitudInicial.Text, out double longitudInicial))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para la longitud inicial.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtModuloYoung.Text, out double moduloYoung))
                {
                    MessageBox.Show("Seleccione un material válido.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var resultado = calculoCompresion.CalcularCompresion(fuerza, area, longitudInicial, moduloYoung);
                MostrarResultados(resultado, fuerza, area, longitudInicial, moduloYoung);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el cálculo: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResultados(ResultadoCompresion resultado, double fuerza,
                                     double area, double longitudInicial, double moduloYoung)
        {
            txtResultados.Clear();
            txtResultados.AppendText("═══════════════════════════════════════════════════════\r\n");
            txtResultados.AppendText("       RESULTADOS DEL CÁLCULO DE COMPRESIÓN\r\n");
            txtResultados.AppendText("═══════════════════════════════════════════════════════\r\n\r\n");

            txtResultados.AppendText("DATOS DE ENTRADA:\r\n");
            txtResultados.AppendText("───────────────────────────────────────────────────────\r\n");
            txtResultados.AppendText($"Material: {cboMaterial.SelectedItem}\r\n");
            txtResultados.AppendText($"Fuerza de compresión (F⊥): {fuerza:N2} N\r\n");
            txtResultados.AppendText($"Área transversal (A): {area:E3} m²\r\n");
            txtResultados.AppendText($"Longitud inicial (L₀): {longitudInicial:N4} m\r\n");
            txtResultados.AppendText($"Módulo de Young (Y): {moduloYoung:E3} Pa\r\n\r\n");

            txtResultados.AppendText("RESULTADOS CALCULADOS:\r\n");
            txtResultados.AppendText("───────────────────────────────────────────────────────\r\n");
            txtResultados.AppendText($"Esfuerzo de compresión (σ):\r\n");
            txtResultados.AppendText($"  {resultado.EsfuerzoCompresion:E3} Pa\r\n");
            txtResultados.AppendText($"  {resultado.EsfuerzoCompresion / 1e6:N2} MPa\r\n\r\n");

            txtResultados.AppendText($"Deformación por compresión (ε):\r\n");
            txtResultados.AppendText($"  {resultado.DeformacionCompresion:E6} (adimensional)\r\n");
            txtResultados.AppendText($"  {resultado.DeformacionCompresion * 100:N6} %\r\n\r\n");

            txtResultados.AppendText($"Acortamiento absoluto (ΔL):\r\n");
            txtResultados.AppendText($"  {resultado.AcortamientoAbsoluto:E6} m\r\n");
            txtResultados.AppendText($"  {resultado.AcortamientoAbsoluto * 1000:N6} mm\r\n\r\n");

            txtResultados.AppendText($"Longitud final (Lf):\r\n");
            txtResultados.AppendText($"  {resultado.LongitudFinal:N6} m\r\n\r\n");

            txtResultados.AppendText("FÓRMULAS UTILIZADAS:\r\n");
            txtResultados.AppendText("───────────────────────────────────────────────────────\r\n");
            txtResultados.AppendText("σ = F⊥ / A\r\n");
            txtResultados.AppendText("ε = ΔL / L₀\r\n");
            txtResultados.AppendText("Y = σ / ε\r\n");
            txtResultados.AppendText("ΔL = (σ / Y) × L₀\r\n");
            txtResultados.AppendText("Lf = L₀ - ΔL\r\n");
            txtResultados.AppendText("═══════════════════════════════════════════════════════\r\n");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFuerza.Clear();
            txtArea.Clear();
            txtLongitudInicial.Clear();
            txtResultados.Clear();
            if (cboMaterial.Items.Count > 0)
            {
                cboMaterial.SelectedIndex = 0;
            }
            txtFuerza.Focus();
        }
    }
}