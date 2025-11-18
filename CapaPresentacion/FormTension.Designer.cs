namespace CapaPresentacion
{
    partial class FormTension
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblLongitudInicial;
        private System.Windows.Forms.TextBox txtLongitudInicial;
        private System.Windows.Forms.Label lblModuloYoung;
        private System.Windows.Forms.TextBox txtModuloYoung;
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
            txtModuloYoung = new TextBox();
            lblModuloYoung = new Label();
            txtLongitudInicial = new TextBox();
            lblLongitudInicial = new Label();
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
            gbDatos.Controls.Add(txtModuloYoung);
            gbDatos.Controls.Add(lblModuloYoung);
            gbDatos.Controls.Add(txtLongitudInicial);
            gbDatos.Controls.Add(lblLongitudInicial);
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
            // txtModuloYoung
            // 
            txtModuloYoung.Font = new Font("Segoe UI", 9.75F);
            txtModuloYoung.Location = new Point(200, 235);
            txtModuloYoung.Name = "txtModuloYoung";
            txtModuloYoung.ReadOnly = true;
            txtModuloYoung.Size = new Size(200, 25);
            txtModuloYoung.TabIndex = 9;
            // 
            // lblModuloYoung
            // 
            lblModuloYoung.AutoSize = true;
            lblModuloYoung.Font = new Font("Segoe UI", 9.75F);
            lblModuloYoung.Location = new Point(20, 238);
            lblModuloYoung.Name = "lblModuloYoung";
            lblModuloYoung.Size = new Size(142, 17);
            lblModuloYoung.TabIndex = 8;
            lblModuloYoung.Text = "Módulo de Young (Pa):";
            // 
            // txtLongitudInicial
            // 
            txtLongitudInicial.Font = new Font("Segoe UI", 9.75F);
            txtLongitudInicial.Location = new Point(200, 185);
            txtLongitudInicial.Name = "txtLongitudInicial";
            txtLongitudInicial.Size = new Size(200, 25);
            txtLongitudInicial.TabIndex = 7;
            // 
            // lblLongitudInicial
            // 
            lblLongitudInicial.AutoSize = true;
            lblLongitudInicial.Font = new Font("Segoe UI", 9.75F);
            lblLongitudInicial.Location = new Point(20, 188);
            lblLongitudInicial.Name = "lblLongitudInicial";
            lblLongitudInicial.Size = new Size(136, 17);
            lblLongitudInicial.TabIndex = 6;
            lblLongitudInicial.Text = "Longitud Inicial L₀ (m):";
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
            lblArea.Size = new Size(199, 17);
            lblArea.TabIndex = 4;
            lblArea.Text = "Área de sección transversal (m²):";
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
            lblFuerza.Size = new Size(146, 17);
            lblFuerza.TabIndex = 2;
            lblFuerza.Text = "Fuerza Aplicada F⊥ (N):";
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
            // FormTension
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 147, 164);
            ClientSize = new Size(990, 580);
            Controls.Add(gbResultados);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gbDatos);
            Name = "FormTension";
            Text = "Cálculo de Tensión";
            Load += FormTension_Load;
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            gbResultados.ResumeLayout(false);
            gbResultados.PerformLayout();
            ResumeLayout(false);
        }
    }
}