using System;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FormGestionMateriales : Form
    {
        private MaterialRepositorio materialRepo;
        private string materialSeleccionado;

        public FormGestionMateriales()
        {
            InitializeComponent();
            materialRepo = new MaterialRepositorio();
        }

        private void FormGestionMateriales_Load(object sender, EventArgs e)
        {
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            lstMateriales.Items.Clear();
            var materiales = materialRepo.ObtenerTodos();
            foreach (var material in materiales)
            {
                lstMateriales.Items.Add(material.Nombre);
            }
        }

        private void lstMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMateriales.SelectedItem != null)
            {
                materialSeleccionado = lstMateriales.SelectedItem.ToString();
                var material = materialRepo.ObtenerPorNombre(materialSeleccionado);
                if (material != null)
                {
                    txtNombre.Text = material.Nombre;
                    txtModuloYoung.Text = material.ModuloYoung.ToString();
                    txtModuloVolumen.Text = material.ModuloVolumen.ToString();
                    txtModuloCorte.Text = material.ModuloCorte.ToString();
                    txtEsfuerzoRotura.Text = material.EsfuerzoRotura.ToString();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del material.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtModuloYoung.Text, out double moduloYoung))
                    moduloYoung = 0;
                if (!double.TryParse(txtModuloVolumen.Text, out double moduloVolumen))
                    moduloVolumen = 0;
                if (!double.TryParse(txtModuloCorte.Text, out double moduloCorte))
                    moduloCorte = 0;
                if (!double.TryParse(txtEsfuerzoRotura.Text, out double esfuerzoRotura))
                    esfuerzoRotura = 0;

                var nuevoMaterial = new Material(txtNombre.Text, moduloYoung, moduloVolumen,
                                                moduloCorte, esfuerzoRotura);
                materialRepo.AgregarMaterial(nuevoMaterial);

                MessageBox.Show("Material agregado exitosamente.", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarMateriales();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar material: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(materialSeleccionado))
                {
                    MessageBox.Show("Seleccione un material de la lista para actualizar.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del material.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtModuloYoung.Text, out double moduloYoung))
                    moduloYoung = 0;
                if (!double.TryParse(txtModuloVolumen.Text, out double moduloVolumen))
                    moduloVolumen = 0;
                if (!double.TryParse(txtModuloCorte.Text, out double moduloCorte))
                    moduloCorte = 0;
                if (!double.TryParse(txtEsfuerzoRotura.Text, out double esfuerzoRotura))
                    esfuerzoRotura = 0;

                var materialActualizado = new Material(txtNombre.Text, moduloYoung, moduloVolumen,
                                                      moduloCorte, esfuerzoRotura);

                if (materialRepo.ActualizarMaterial(materialSeleccionado, materialActualizado))
                {
                    MessageBox.Show("Material actualizado exitosamente.", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMateriales();
                    LimpiarCampos();
                    materialSeleccionado = null;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el material.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar material: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(materialSeleccionado))
                {
                    MessageBox.Show("Seleccione un material de la lista para eliminar.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirmacion = MessageBox.Show($"¿Está seguro de eliminar el material '{materialSeleccionado}'?",
                                                  "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    if (materialRepo.EliminarMaterial(materialSeleccionado))
                    {
                        MessageBox.Show("Material eliminado exitosamente.", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarMateriales();
                        LimpiarCampos();
                        materialSeleccionado = null;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el material.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar material: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            materialSeleccionado = null;
            lstMateriales.ClearSelected();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtModuloYoung.Clear();
            txtModuloVolumen.Clear();
            txtModuloCorte.Clear();
            txtEsfuerzoRotura.Clear();
        }
    }
}