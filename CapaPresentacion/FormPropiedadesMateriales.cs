using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FormPropiedadesMateriales : Form
    {
        private MaterialRepositorio materialRepo;
        private DataTable dtMateriales;

        public FormPropiedadesMateriales()
        {
            InitializeComponent();
            materialRepo = new MaterialRepositorio();
        }

        private void FormPropiedadesMateriales_Load(object sender, EventArgs e)
        {
            ConfigurarFiltros();
            CargarDatos("Todos");
        }

        private void ConfigurarFiltros()
        {
            cboFiltro.Items.Add("Todos");
            cboFiltro.Items.Add("Con Módulo de Young");
            cboFiltro.Items.Add("Con Módulo de Volumen");
            cboFiltro.Items.Add("Con Módulo de Corte");
            cboFiltro.Items.Add("Con Esfuerzo de Rotura");
            cboFiltro.SelectedIndex = 0;
        }

        private void CargarDatos(string filtro)
        {
            dtMateriales = new DataTable();
            dtMateriales.Columns.Add("Material", typeof(string));
            dtMateriales.Columns.Add("Módulo Young (Pa)", typeof(string));
            dtMateriales.Columns.Add("Módulo Volumen (Pa)", typeof(string));
            dtMateriales.Columns.Add("Módulo Corte (Pa)", typeof(string));
            dtMateriales.Columns.Add("Esfuerzo Rotura (Pa)", typeof(string));
            dtMateriales.Columns.Add("Compresibilidad (Pa⁻¹)", typeof(string));

            var materiales = materialRepo.ObtenerTodos();

            foreach (var material in materiales)
            {
                bool incluir = false;

                switch (filtro)
                {
                    case "Todos":
                        incluir = true;
                        break;
                    case "Con Módulo de Young":
                        incluir = material.ModuloYoung > 0;
                        break;
                    case "Con Módulo de Volumen":
                        incluir = material.ModuloVolumen > 0;
                        break;
                    case "Con Módulo de Corte":
                        incluir = material.ModuloCorte > 0;
                        break;
                    case "Con Esfuerzo de Rotura":
                        incluir = material.EsfuerzoRotura > 0;
                        break;
                }

                if (incluir)
                {
                    dtMateriales.Rows.Add(
                        material.Nombre,
                        material.ModuloYoung > 0 ? material.ModuloYoung.ToString("E3") : "N/A",
                        material.ModuloVolumen > 0 ? material.ModuloVolumen.ToString("E3") : "N/A",
                        material.ModuloCorte > 0 ? material.ModuloCorte.ToString("E3") : "N/A",
                        material.EsfuerzoRotura > 0 ? material.EsfuerzoRotura.ToString("E3") : "N/A",
                        material.ModuloVolumen > 0 ? material.Compresibilidad.ToString("E3") : "N/A"
                    );
                }
            }

            dgvMateriales.DataSource = dtMateriales;
            ConfigurarEstiloGrid();
        }

        private void ConfigurarEstiloGrid()
        {
            dgvMateriales.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            dgvMateriales.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvMateriales.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dgvMateriales.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMateriales.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvMateriales.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvMateriales.EnableHeadersVisualStyles = false;
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFiltro.SelectedItem != null)
            {
                CargarDatos(cboFiltro.SelectedItem.ToString());
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "PropiedadesMateriales.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escribir encabezados
                        for (int i = 0; i < dgvMateriales.Columns.Count; i++)
                        {
                            sw.Write(dgvMateriales.Columns[i].HeaderText);
                            if (i < dgvMateriales.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Escribir datos
                        foreach (DataGridViewRow row in dgvMateriales.Rows)
                        {
                            for (int i = 0; i < dgvMateriales.Columns.Count; i++)
                            {
                                sw.Write(row.Cells[i].Value?.ToString() ?? "");
                                if (i < dgvMateriales.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Datos exportados exitosamente.", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}