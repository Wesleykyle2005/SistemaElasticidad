namespace CapaPresentacion
{
    partial class FormGestionMateriales
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbListaMateriales;
        private System.Windows.Forms.ListBox lstMateriales;
        private System.Windows.Forms.GroupBox gbDatosMaterial;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblModuloYoung;
        private System.Windows.Forms.TextBox txtModuloYoung;
        private System.Windows.Forms.Label lblModuloVolumen;
        private System.Windows.Forms.TextBox txtModuloVolumen;
        private System.Windows.Forms.Label lblModuloCorte;
        private System.Windows.Forms.TextBox txtModuloCorte;
        private System.Windows.Forms.Label lblEsfuerzoRotura;
        private System.Windows.Forms.TextBox txtEsfuerzoRotura;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;

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
            gbListaMateriales = new GroupBox();
            lstMateriales = new ListBox();
            gbDatosMaterial = new GroupBox();
            txtEsfuerzoRotura = new TextBox();
            lblEsfuerzoRotura = new Label();
            txtModuloCorte = new TextBox();
            lblModuloCorte = new Label();
            txtModuloVolumen = new TextBox();
            lblModuloVolumen = new Label();
            txtModuloYoung = new TextBox();
            lblModuloYoung = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            gbListaMateriales.SuspendLayout();
            gbDatosMaterial.SuspendLayout();
            SuspendLayout();
            // 
            // gbListaMateriales
            // 
            gbListaMateriales.Controls.Add(lstMateriales);
            gbListaMateriales.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbListaMateriales.Location = new Point(20, 20);
            gbListaMateriales.Name = "gbListaMateriales";
            gbListaMateriales.Size = new Size(300, 500);
            gbListaMateriales.TabIndex = 0;
            gbListaMateriales.TabStop = false;
            gbListaMateriales.Text = "Materiales Disponibles";
            // 
            // lstMateriales
            // 
            lstMateriales.BackColor = Color.FromArgb(88, 103, 119);
            lstMateriales.Font = new Font("Segoe UI", 9.75F);
            lstMateriales.ForeColor = Color.White;
            lstMateriales.FormattingEnabled = true;
            lstMateriales.ItemHeight = 17;
            lstMateriales.Location = new Point(15, 30);
            lstMateriales.Name = "lstMateriales";
            lstMateriales.Size = new Size(270, 446);
            lstMateriales.TabIndex = 0;
            lstMateriales.SelectedIndexChanged += lstMateriales_SelectedIndexChanged;
            // 
            // gbDatosMaterial
            // 
            gbDatosMaterial.Controls.Add(txtEsfuerzoRotura);
            gbDatosMaterial.Controls.Add(lblEsfuerzoRotura);
            gbDatosMaterial.Controls.Add(txtModuloCorte);
            gbDatosMaterial.Controls.Add(lblModuloCorte);
            gbDatosMaterial.Controls.Add(txtModuloVolumen);
            gbDatosMaterial.Controls.Add(lblModuloVolumen);
            gbDatosMaterial.Controls.Add(txtModuloYoung);
            gbDatosMaterial.Controls.Add(lblModuloYoung);
            gbDatosMaterial.Controls.Add(txtNombre);
            gbDatosMaterial.Controls.Add(lblNombre);
            gbDatosMaterial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbDatosMaterial.Location = new Point(340, 20);
            gbDatosMaterial.Name = "gbDatosMaterial";
            gbDatosMaterial.Size = new Size(430, 380);
            gbDatosMaterial.TabIndex = 1;
            gbDatosMaterial.TabStop = false;
            gbDatosMaterial.Text = "Datos del Material";
            // 
            // txtEsfuerzoRotura
            // 
            txtEsfuerzoRotura.Font = new Font("Segoe UI", 9.75F);
            txtEsfuerzoRotura.Location = new Point(200, 325);
            txtEsfuerzoRotura.Name = "txtEsfuerzoRotura";
            txtEsfuerzoRotura.Size = new Size(200, 25);
            txtEsfuerzoRotura.TabIndex = 9;
            // 
            // lblEsfuerzoRotura
            // 
            lblEsfuerzoRotura.AutoSize = true;
            lblEsfuerzoRotura.Font = new Font("Segoe UI", 9.75F);
            lblEsfuerzoRotura.Location = new Point(20, 328);
            lblEsfuerzoRotura.Name = "lblEsfuerzoRotura";
            lblEsfuerzoRotura.Size = new Size(149, 17);
            lblEsfuerzoRotura.TabIndex = 8;
            lblEsfuerzoRotura.Text = "Esfuerzo de Rotura (Pa):";
            // 
            // txtModuloCorte
            // 
            txtModuloCorte.Font = new Font("Segoe UI", 9.75F);
            txtModuloCorte.Location = new Point(200, 255);
            txtModuloCorte.Name = "txtModuloCorte";
            txtModuloCorte.Size = new Size(200, 25);
            txtModuloCorte.TabIndex = 7;
            // 
            // lblModuloCorte
            // 
            lblModuloCorte.AutoSize = true;
            lblModuloCorte.Font = new Font("Segoe UI", 9.75F);
            lblModuloCorte.Location = new Point(20, 258);
            lblModuloCorte.Name = "lblModuloCorte";
            lblModuloCorte.Size = new Size(149, 17);
            lblModuloCorte.TabIndex = 6;
            lblModuloCorte.Text = "Módulo de Corte S (Pa):";
            // 
            // txtModuloVolumen
            // 
            txtModuloVolumen.Font = new Font("Segoe UI", 9.75F);
            txtModuloVolumen.Location = new Point(200, 185);
            txtModuloVolumen.Name = "txtModuloVolumen";
            txtModuloVolumen.Size = new Size(200, 25);
            txtModuloVolumen.TabIndex = 5;
            // 
            // lblModuloVolumen
            // 
            lblModuloVolumen.AutoSize = true;
            lblModuloVolumen.Font = new Font("Segoe UI", 9.75F);
            lblModuloVolumen.Location = new Point(20, 188);
            lblModuloVolumen.Name = "lblModuloVolumen";
            lblModuloVolumen.Size = new Size(167, 17);
            lblModuloVolumen.TabIndex = 4;
            lblModuloVolumen.Text = "Módulo de Volumen B (Pa):";
            // 
            // txtModuloYoung
            // 
            txtModuloYoung.Font = new Font("Segoe UI", 9.75F);
            txtModuloYoung.Location = new Point(200, 115);
            txtModuloYoung.Name = "txtModuloYoung";
            txtModuloYoung.Size = new Size(200, 25);
            txtModuloYoung.TabIndex = 3;
            // 
            // lblModuloYoung
            // 
            lblModuloYoung.AutoSize = true;
            lblModuloYoung.Font = new Font("Segoe UI", 9.75F);
            lblModuloYoung.Location = new Point(20, 118);
            lblModuloYoung.Name = "lblModuloYoung";
            lblModuloYoung.Size = new Size(153, 17);
            lblModuloYoung.TabIndex = 2;
            lblModuloYoung.Text = "Módulo de Young Y (Pa):";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(200, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 25);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(20, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Material:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(40, 167, 69);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(340, 420);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(200, 40);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 122, 204);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(570, 420);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(200, 40);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(340, 480);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(200, 40);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(64, 64, 64);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(570, 480);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 40);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormGestionMateriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 147, 164);
            ClientSize = new Size(790, 540);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(gbDatosMaterial);
            Controls.Add(gbListaMateriales);
            Name = "FormGestionMateriales";
            Text = "Gestión de Materiales";
            Load += FormGestionMateriales_Load;
            gbListaMateriales.ResumeLayout(false);
            gbDatosMaterial.ResumeLayout(false);
            gbDatosMaterial.PerformLayout();
            ResumeLayout(false);
        }
    }
}