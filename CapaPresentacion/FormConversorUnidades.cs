using System;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormConversorUnidades : Form
    {
        private ConversionUnidades conversion;

        public FormConversorUnidades()
        {
            InitializeComponent();
            conversion = new ConversionUnidades();
        }

        private void FormConversorUnidades_Load(object sender, EventArgs e)
        {
            ConfigurarComboBoxes();
        }

        private void ConfigurarComboBoxes()
        {
            // Presión
            cboPresionOrigen.Items.AddRange(new string[] { "Pascal (Pa)", "Kilopascal (kPa)", "Megapascal (MPa)", "PSI", "Atmósfera (atm)" });
            cboPresionDestino.Items.AddRange(new string[] { "Pascal (Pa)", "Kilopascal (kPa)", "Megapascal (MPa)", "PSI", "Atmósfera (atm)" });
            cboPresionOrigen.SelectedIndex = 0;
            cboPresionDestino.SelectedIndex = 1;

            // Longitud
            cboLongitudOrigen.Items.AddRange(new string[] { "Metros (m)", "Centímetros (cm)", "Milímetros (mm)", "Kilómetros (km)" });
            cboLongitudDestino.Items.AddRange(new string[] { "Metros (m)", "Centímetros (cm)", "Milímetros (mm)", "Kilómetros (km)" });
            cboLongitudOrigen.SelectedIndex = 0;
            cboLongitudDestino.SelectedIndex = 2;

            // Fuerza
            cboFuerzaOrigen.Items.AddRange(new string[] { "Newtons (N)", "Kilonewtons (kN)", "Meganewtons (MN)" });
            cboFuerzaDestino.Items.AddRange(new string[] { "Newtons (N)", "Kilonewtons (kN)", "Meganewtons (MN)" });
            cboFuerzaOrigen.SelectedIndex = 0;
            cboFuerzaDestino.SelectedIndex = 1;
        }

        private void btnConvertirPresion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtPresionEntrada.Text, out double valor))
                {
                    MessageBox.Show("Ingrese un valor numérico válido.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string origen = cboPresionOrigen.SelectedItem.ToString();
                string destino = cboPresionDestino.SelectedItem.ToString();

                // Convertir todo a Pascal primero
                double valorPascal = ConvertirAPascal(valor, origen);

                // Luego convertir de Pascal a la unidad destino
                double resultado = ConvertirDesdePascal(valorPascal, destino);

                txtPresionResultado.Text = $"{resultado:E6} {destino}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la conversión: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ConvertirAPascal(double valor, string unidad)
        {
            switch (unidad)
            {
                case "Pascal (Pa)":
                    return valor;
                case "Kilopascal (kPa)":
                    return valor * 1000;
                case "Megapascal (MPa)":
                    return valor * 1e6;
                case "PSI":
                    return conversion.PsiAPascal(valor);
                case "Atmósfera (atm)":
                    return conversion.AtmAPascal(valor);
                default:
                    return valor;
            }
        }

        private double ConvertirDesdePascal(double valorPascal, string unidad)
        {
            switch (unidad)
            {
                case "Pascal (Pa)":
                    return valorPascal;
                case "Kilopascal (kPa)":
                    return valorPascal / 1000;
                case "Megapascal (MPa)":
                    return valorPascal / 1e6;
                case "PSI":
                    return conversion.PascalAPsi(valorPascal);
                case "Atmósfera (atm)":
                    return conversion.PascalAAtm(valorPascal);
                default:
                    return valorPascal;
            }
        }

        private void btnConvertirLongitud_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtLongitudEntrada.Text, out double valor))
                {
                    MessageBox.Show("Ingrese un valor numérico válido.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string origen = cboLongitudOrigen.SelectedItem.ToString();
                string destino = cboLongitudDestino.SelectedItem.ToString();

                // Convertir todo a metros primero
                double valorMetros = ConvertirAMetros(valor, origen);

                // Luego convertir de metros a la unidad destino
                double resultado = ConvertirDesdeMetros(valorMetros, destino);

                txtLongitudResultado.Text = $"{resultado:N6} {destino}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la conversión: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ConvertirAMetros(double valor, string unidad)
        {
            switch (unidad)
            {
                case "Metros (m)":
                    return valor;
                case "Centímetros (cm)":
                    return conversion.CentimetrosAMetros(valor);
                case "Milímetros (mm)":
                    return conversion.MilimetrosAMetros(valor);
                case "Kilómetros (km)":
                    return valor * 1000;
                default:
                    return valor;
            }
        }

        private double ConvertirDesdeMetros(double valorMetros, string unidad)
        {
            switch (unidad)
            {
                case "Metros (m)":
                    return valorMetros;
                case "Centímetros (cm)":
                    return conversion.MetrosACentimetros(valorMetros);
                case "Milímetros (mm)":
                    return conversion.MetrosAMilimetros(valorMetros);
                case "Kilómetros (km)":
                    return valorMetros / 1000;
                default:
                    return valorMetros;
            }
        }

        private void btnConvertirFuerza_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtFuerzaEntrada.Text, out double valor))
                {
                    MessageBox.Show("Ingrese un valor numérico válido.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string origen = cboFuerzaOrigen.SelectedItem.ToString();
                string destino = cboFuerzaDestino.SelectedItem.ToString();

                // Convertir todo a Newtons primero
                double valorNewtons = ConvertirANewtons(valor, origen);

                // Luego convertir de Newtons a la unidad destino
                double resultado = ConvertirDesdeNewtons(valorNewtons, destino);

                txtFuerzaResultado.Text = $"{resultado:N6} {destino}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la conversión: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ConvertirANewtons(double valor, string unidad)
        {
            switch (unidad)
            {
                case "Newtons (N)":
                    return valor;
                case "Kilonewtons (kN)":
                    return conversion.KilonewtonsANewtons(valor);
                case "Meganewtons (MN)":
                    return valor * 1e6;
                default:
                    return valor;
            }
        }

        private double ConvertirDesdeNewtons(double valorNewtons, string unidad)
        {
            switch (unidad)
            {
                case "Newtons (N)":
                    return valorNewtons;
                case "Kilonewtons (kN)":
                    return conversion.NewtonsAKilonewtons(valorNewtons);
                case "Meganewtons (MN)":
                    return valorNewtons / 1e6;
                default:
                    return valorNewtons;
            }
        }
    }
}