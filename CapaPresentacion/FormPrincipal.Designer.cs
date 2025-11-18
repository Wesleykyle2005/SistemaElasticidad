namespace CapaPresentacion
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compresionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarMaterialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPropiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversorUnidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblDescripcion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            calculosToolStripMenuItem = new ToolStripMenuItem();
            tensionToolStripMenuItem = new ToolStripMenuItem();
            compresionToolStripMenuItem = new ToolStripMenuItem();
            corteToolStripMenuItem = new ToolStripMenuItem();
            volumenToolStripMenuItem = new ToolStripMenuItem();
            materialesToolStripMenuItem = new ToolStripMenuItem();
            gestionarMaterialesToolStripMenuItem = new ToolStripMenuItem();
            verPropiedadesToolStripMenuItem = new ToolStripMenuItem();
            herramientasToolStripMenuItem = new ToolStripMenuItem();
            conversorUnidadesToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            lblDescripcion = new Label();
            lblBienvenida = new Label();
            menuStrip1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { calculosToolStripMenuItem, materialesToolStripMenuItem, herramientasToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // calculosToolStripMenuItem
            // 
            calculosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tensionToolStripMenuItem, compresionToolStripMenuItem, corteToolStripMenuItem, volumenToolStripMenuItem });
            calculosToolStripMenuItem.Name = "calculosToolStripMenuItem";
            calculosToolStripMenuItem.Size = new Size(64, 20);
            calculosToolStripMenuItem.Text = "Cálculos";
            // 
            // tensionToolStripMenuItem
            // 
            tensionToolStripMenuItem.Name = "tensionToolStripMenuItem";
            tensionToolStripMenuItem.Size = new Size(139, 22);
            tensionToolStripMenuItem.Text = "Tensión";
            tensionToolStripMenuItem.Click += tensionToolStripMenuItem_Click;
            // 
            // compresionToolStripMenuItem
            // 
            compresionToolStripMenuItem.Name = "compresionToolStripMenuItem";
            compresionToolStripMenuItem.Size = new Size(139, 22);
            compresionToolStripMenuItem.Text = "Compresión";
            compresionToolStripMenuItem.Click += compresionToolStripMenuItem_Click;
            // 
            // corteToolStripMenuItem
            // 
            corteToolStripMenuItem.Name = "corteToolStripMenuItem";
            corteToolStripMenuItem.Size = new Size(139, 22);
            corteToolStripMenuItem.Text = "Corte";
            corteToolStripMenuItem.Click += corteToolStripMenuItem_Click;
            // 
            // volumenToolStripMenuItem
            // 
            volumenToolStripMenuItem.Name = "volumenToolStripMenuItem";
            volumenToolStripMenuItem.Size = new Size(139, 22);
            volumenToolStripMenuItem.Text = "Volumen";
            volumenToolStripMenuItem.Click += volumenToolStripMenuItem_Click;
            // 
            // materialesToolStripMenuItem
            // 
            materialesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarMaterialesToolStripMenuItem, verPropiedadesToolStripMenuItem });
            materialesToolStripMenuItem.Name = "materialesToolStripMenuItem";
            materialesToolStripMenuItem.Size = new Size(73, 20);
            materialesToolStripMenuItem.Text = "Materiales";
            // 
            // gestionarMaterialesToolStripMenuItem
            // 
            gestionarMaterialesToolStripMenuItem.Name = "gestionarMaterialesToolStripMenuItem";
            gestionarMaterialesToolStripMenuItem.Size = new Size(181, 22);
            gestionarMaterialesToolStripMenuItem.Text = "Gestionar Materiales";
            gestionarMaterialesToolStripMenuItem.Click += gestionarMaterialesToolStripMenuItem_Click;
            // 
            // verPropiedadesToolStripMenuItem
            // 
            verPropiedadesToolStripMenuItem.Name = "verPropiedadesToolStripMenuItem";
            verPropiedadesToolStripMenuItem.Size = new Size(181, 22);
            verPropiedadesToolStripMenuItem.Text = "Ver Propiedades";
            verPropiedadesToolStripMenuItem.Click += verPropiedadesToolStripMenuItem_Click;
            // 
            // herramientasToolStripMenuItem
            // 
            herramientasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conversorUnidadesToolStripMenuItem });
            herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            herramientasToolStripMenuItem.Size = new Size(90, 20);
            herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // conversorUnidadesToolStripMenuItem
            // 
            conversorUnidadesToolStripMenuItem.Name = "conversorUnidadesToolStripMenuItem";
            conversorUnidadesToolStripMenuItem.Size = new Size(180, 22);
            conversorUnidadesToolStripMenuItem.Text = "Conversor Unidades";
            conversorUnidadesToolStripMenuItem.Click += conversorUnidadesToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(135, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.WhiteSmoke;
            panelPrincipal.BackgroundImage = (Image)resources.GetObject("panelPrincipal.BackgroundImage");
            panelPrincipal.Controls.Add(lblDescripcion);
            panelPrincipal.Controls.Add(lblBienvenida);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 24);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1000, 626);
            panelPrincipal.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(150, 319);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(700, 100);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = resources.GetString("lblDescripcion.Text");
            lblDescripcion.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblBienvenida.ForeColor = SystemColors.HotTrack;
            lblBienvenida.Location = new Point(150, 250);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(700, 40);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Sistema de Cálculo de Elasticidad";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Cálculo de Esfuerzos y Deformaciones";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}