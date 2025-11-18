namespace CapaPresentacion
{
    partial class FormCorte
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblModuloCorte;
        private System.Windows.Forms.TextBox txtModuloCorte;
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
            txtModuloCorte = new TextBox();
            lblModuloCorte = new Label();
            txtAltura = new TextBox();
            lblAltura = new Label();
            txtArea = new TextBox();
            lblArea = new Label();
            txtFuerza = new TextBox();
            lblFuerza = new Label();
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
            gbDatos.Controls.Add(txtModuloCorte);
            gbDatos.Controls.Add(lblModuloCorte);
            gbDatos.Controls.Add(txtAltura);
            gbDatos.Controls.Add(lblAltura);
            gbDatos.Controls.Add(txtArea);
            gbDatos.Controls.Add(lblArea);
            gbDatos.Controls.Add(txtFuerza);
            gbDatos.Controls.Add(lblFuerza);
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
            // txtModuloCorte
            // 
            txtModuloCorte.Font = new Font("Segoe UI", 9.75F);
            txtModuloCorte.Location = new Point(200, 235);
            txtModuloCorte.Name = "txtModuloCorte";
            txtModuloCorte.ReadOnly = true;
            txtModuloCorte.Size = new Size(200, 25);
            txtModuloCorte.TabIndex = 9;
            // 
            // lblModuloCorte
            // 
            lblModuloCorte.AutoSize = true;
            lblModuloCorte.Font = new Font("Segoe UI", 9.75F);
            lblModuloCorte.Location = new Point(20, 238);
            lblModuloCorte.Name = "lblModuloCorte";
            lblModuloCorte.Size = new Size(149, 17);
            lblModuloCorte.TabIndex = 8;
            lblModuloCorte.Text = "Módulo de Corte S (Pa):";
            // 
            // txtAltura
            // 
            txtAltura.Font = new Font("Segoe UI", 9.75F);
            txtAltura.Location = new Point(200, 185);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(200, 25);
            txtAltura.TabIndex = 7;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 9.75F);
            lblAltura.Location = new Point(20, 188);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(79, 17);
            lblAltura.TabIndex = 6;
            lblAltura.Text = "Altura h (m):";
            // 
            // txtArea
            // 
            txtArea.Font = new Font("Segoe UI", 9.75F);
            txtArea.Location = new Point(200, 135);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(200, 25);
            txtArea.TabIndex = 5;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 9.75F);
            lblArea.Location = new Point(20, 138);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(159, 17);
            lblArea.TabIndex = 4;
            lblArea.Text = "Área donde actúa F∥ (m²):";
            // 
            // txtFuerza
            // 
            txtFuerza.Font = new Font("Segoe UI", 9.75F);
            txtFuerza.Location = new Point(200, 85);
            txtFuerza.Name = "txtFuerza";
            txtFuerza.Size = new Size(200, 25);
            txtFuerza.TabIndex = 3;
            // 
            // lblFuerza
            // 
            lblFuerza.AutoSize = true;
            lblFuerza.Font = new Font("Segoe UI", 9.75F);
            lblFuerza.Location = new Point(20, 88);
            lblFuerza.Name = "lblFuerza";
            lblFuerza.Size = new Size(137, 17);
            lblFuerza.TabIndex = 2;
            lblFuerza.Text = "Fuerza Paralela F∥ (N):";
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
            // FormCorte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 147, 164);
            ClientSize = new Size(990, 580);
            Controls.Add(gbResultados);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gbDatos);
            Name = "FormCorte";
            Text = "Cálculo de Corte";
            Load += FormCorte_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbResultados.ResumeLayout(false);
            gbResultados.PerformLayout();
            ResumeLayout(false);
        }
    }
}