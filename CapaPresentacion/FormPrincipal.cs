using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formulario)
        {
            panelPrincipal.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formulario);
            formulario.Show();
        }

        private void tensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormTension());
        }

        private void compresionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormCompresion());
        }

        private void corteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormCorte());
        }

        private void volumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormVolumen());
        }

        private void gestionarMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormGestionMateriales());
        }

        private void verPropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormPropiedadesMateriales());
        }

        private void conversorUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FormConversorUnidades());
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sistema de Cálculo de Esfuerzos y Deformaciones\n\n" +
                "Versión 1.0\n\n" +
                "Este sistema permite realizar cálculos de:\n" +
                "- Tensión y compresión\n" +
                "- Esfuerzos de corte\n" +
                "- Deformaciones volumétricas\n" +
                "- Gestión de propiedades de materiales\n\n" +
                "Basado en la Ley de Hooke y módulos de elasticidad",
                "Acerca de",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}