namespace CapaPresentacion
{
    partial class FormPropiedadesMateriales
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Button btnExportar;

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
            dgvMateriales = new DataGridView();
            gbFiltros = new GroupBox();
            btnExportar = new Button();
            cboFiltro = new ComboBox();
            lblFiltro = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).BeginInit();
            gbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMateriales
            // 
            dgvMateriales.AllowUserToAddRows = false;
            dgvMateriales.AllowUserToDeleteRows = false;
            dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMateriales.BackgroundColor = Color.FromArgb(88, 103, 119);
            dgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriales.Location = new Point(20, 120);
            dgvMateriales.Name = "dgvMateriales";
            dgvMateriales.ReadOnly = true;
            dgvMateriales.RowHeadersWidth = 51;
            dgvMateriales.Size = new Size(950, 440);
            dgvMateriales.TabIndex = 0;
            // 
            // gbFiltros
            // 
            gbFiltros.Controls.Add(btnExportar);
            gbFiltros.Controls.Add(cboFiltro);
            gbFiltros.Controls.Add(lblFiltro);
            gbFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbFiltros.Location = new Point(20, 20);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(950, 80);
            gbFiltros.TabIndex = 1;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Opciones";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(0, 122, 204);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(700, 30);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(220, 35);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "EXPORTAR A CSV";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // cboFiltro
            // 
            cboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltro.Font = new Font("Segoe UI", 9.75F);
            cboFiltro.FormattingEnabled = true;
            cboFiltro.Location = new Point(200, 35);
            cboFiltro.Name = "cboFiltro";
            cboFiltro.Size = new Size(250, 25);
            cboFiltro.TabIndex = 1;
            cboFiltro.SelectedIndexChanged += cboFiltro_SelectedIndexChanged;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 9.75F);
            lblFiltro.Location = new Point(30, 38);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(87, 17);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Mostrar solo:";
            // 
            // FormPropiedadesMateriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 147, 164);
            ClientSize = new Size(990, 580);
            Controls.Add(gbFiltros);
            Controls.Add(dgvMateriales);
            Name = "FormPropiedadesMateriales";
            Text = "Propiedades de Materiales";
            Load += FormPropiedadesMateriales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMateriales).EndInit();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            ResumeLayout(false);
        }
    }
}