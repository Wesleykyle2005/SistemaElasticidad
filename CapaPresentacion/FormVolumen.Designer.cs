namespace CapaPresentacion
{
    partial class FormVolumen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label lblPresionInicial;
        private System.Windows.Forms.TextBox txtPresionInicial;
        private System.Windows.Forms.Label lblCambioPresion;
        private System.Windows.Forms.TextBox txtCambioPresion;
        private System.Windows.Forms.Label lblVolumenInicial;
        private System.Windows.Forms.TextBox txtVolumenInicial;
        private System.Windows.Forms.Label lblModuloVolumen;
        private System.Windows.Forms.TextBox txtModuloVolumen;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.TextBox txtResultados;

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
            gbDatos = new GroupBox();
            txtModuloVolumen = new TextBox();
            lblModuloVolumen = new Label();
            txtVolumenInicial = new TextBox();
            lblVolumenInicial = new Label();
            txtCambioPresion = new TextBox();
            lblCambioPresion = new Label();
            txtPresionInicial = new TextBox();
            lblPresionInicial = new Label();
            cboMaterial = new ComboBox();
            lblMaterial = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbResultados = new GroupBox();
            txtResultados = new TextBox();
            gbDatos.SuspendLayout();
            gbResultados.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(txtModuloVolumen);
            gbDatos.Controls.Add(lblModuloVolumen);
            gbDatos.Controls.Add(txtVolumenInicial);
            gbDatos.Controls.Add(lblVolumenInicial);
            gbDatos.Controls.Add(txtCambioPresion);
            gbDatos.Controls.Add(lblCambioPresion);
            gbDatos.Controls.Add(txtPresionInicial);
            gbDatos.Controls.Add(lblPresionInicial);
            gbDatos.Controls.Add(cboMaterial);
            gbDatos.Controls.Add(lblMaterial);
            gbDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbDatos.Location = new Point(20, 20);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(450, 280);
            gbDatos.TabIndex = 0;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos de Entrada";
            // 
            // txtModuloVolumen
            // 
            txtModuloVolumen.Font = new Font("Segoe UI", 9.75F);
            txtModuloVolumen.Location = new Point(200, 235);
            txtModuloVolumen.Name = "txtModuloVolumen";
            txtModuloVolumen.ReadOnly = true;
            txtModuloVolumen.Size = new Size(200, 25);
            txtModuloVolumen.TabIndex = 9;
            // 
            // lblModuloVolumen
            // 
            lblModuloVolumen.AutoSize = true;
            lblModuloVolumen.Font = new Font("Segoe UI", 9.75F);
            lblModuloVolumen.Location = new Point(20, 238);
            lblModuloVolumen.Name = "lblModuloVolumen";
            lblModuloVolumen.Size = new Size(167, 17);
            lblModuloVolumen.TabIndex = 8;
            lblModuloVolumen.Text = "Módulo de Volumen B (Pa):";
            // 
            // txtVolumenInicial
            // 
            txtVolumenInicial.Font = new Font("Segoe UI", 9.75F);
            txtVolumenInicial.Location = new Point(200, 185);
            txtVolumenInicial.Name = "txtVolumenInicial";
            txtVolumenInicial.Size = new Size(200, 25);
            txtVolumenInicial.TabIndex = 7;
            // 
            // lblVolumenInicial
            // 
            lblVolumenInicial.AutoSize = true;
            lblVolumenInicial.Font = new Font("Segoe UI", 9.75F);
            lblVolumenInicial.Location = new Point(20, 188);
            lblVolumenInicial.Name = "lblVolumenInicial";
            lblVolumenInicial.Size = new Size(142, 17);
            lblVolumenInicial.TabIndex = 6;
            lblVolumenInicial.Text = "Volumen Inicial V₀ (m³):";
            // 
            // txtCambioPresion
            // 
            txtCambioPresion.Font = new Font("Segoe UI", 9.75F);
            txtCambioPresion.Location = new Point(200, 135);
            txtCambioPresion.Name = "txtCambioPresion";
            txtCambioPresion.Size = new Size(200, 25);
            txtCambioPresion.TabIndex = 5;
            // 
            // lblCambioPresion
            // 
            lblCambioPresion.AutoSize = true;
            lblCambioPresion.Font = new Font("Segoe UI", 9.75F);
            lblCambioPresion.Location = new Point(20, 138);
            lblCambioPresion.Name = "lblCambioPresion";
            lblCambioPresion.Size = new Size(168, 17);
            lblCambioPresion.TabIndex = 4;
            lblCambioPresion.Text = "Cambio de Presión Δp (Pa):";
            // 
            // txtPresionInicial
            // 
            txtPresionInicial.Font = new Font("Segoe UI", 9.75F);
            txtPresionInicial.Location = new Point(200, 85);
            txtPresionInicial.Name = "txtPresionInicial";
            txtPresionInicial.Size = new Size(200, 25);
            txtPresionInicial.TabIndex = 3;
            txtPresionInicial.Text = "101325";
            // 
            // lblPresionInicial
            // 
            lblPresionInicial.AutoSize = true;
            lblPresionInicial.Font = new Font("Segoe UI", 9.75F);
            lblPresionInicial.Location = new Point(20, 88);
            lblPresionInicial.Name = "lblPresionInicial";
            lblPresionInicial.Size = new Size(133, 17);
            lblPresionInicial.TabIndex = 2;
            lblPresionInicial.Text = "Presión Inicial p₀ (Pa):";
            // 
            // cboMaterial
            // 
            cboMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaterial.Font = new Font("Segoe UI", 9.75F);
            cboMaterial.FormattingEnabled = true;
            cboMaterial.Location = new Point(200, 35);
            cboMaterial.Name = "cboMaterial";
            cboMaterial.Size = new Size(200, 25);
            cboMaterial.TabIndex = 1;
            cboMaterial.SelectedIndexChanged += cboMaterial_SelectedIndexChanged;
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Font = new Font("Segoe UI", 9.75F);
            lblMaterial.Location = new Point(20, 38);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(59, 17);
            lblMaterial.TabIndex = 0;
            lblMaterial.Text = "Material:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 122, 204);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(20, 320);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(220, 40);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(250, 320);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(220, 40);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // gbResultados
            // 
            gbResultados.Controls.Add(txtResultados);
            gbResultados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbResultados.Location = new Point(490, 20);
            gbResultados.Name = "gbResultados";
            gbResultados.Size = new Size(480, 540);
            gbResultados.TabIndex = 3;
            gbResultados.TabStop = false;
            gbResultados.Text = "Resultados";
            // 
            // txtResultados
            // 
            txtResultados.BackColor = Color.FromArgb(88, 103, 119);
            txtResultados.Font = new Font("Consolas", 9.75F);
            txtResultados.ForeColor = Color.White;
            txtResultados.Location = new Point(15, 30);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.ReadOnly = true;
            txtResultados.ScrollBars = ScrollBars.Vertical;
            txtResultados.Size = new Size(450, 495);
            txtResultados.TabIndex = 0;
            // 
            // FormVolumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 147, 164);
            ClientSize = new Size(990, 580);
            Controls.Add(gbResultados);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gbDatos);
            Name = "FormVolumen";
            Text = "Cálculo de Deformación Volumétrica";
            Load += FormVolumen_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbResultados.ResumeLayout(false);
            gbResultados.PerformLayout();
            ResumeLayout(false);
        }
    }
}