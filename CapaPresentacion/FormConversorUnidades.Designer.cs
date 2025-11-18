namespace CapaPresentacion
{
    partial class FormConversorUnidades
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbPresion;
        private System.Windows.Forms.Label lblPresionEntrada;
        private System.Windows.Forms.TextBox txtPresionEntrada;
        private System.Windows.Forms.ComboBox cboPresionOrigen;
        private System.Windows.Forms.ComboBox cboPresionDestino;
        private System.Windows.Forms.Button btnConvertirPresion;
        private System.Windows.Forms.TextBox txtPresionResultado;
        private System.Windows.Forms.GroupBox gbLongitud;
        private System.Windows.Forms.Label lblLongitudEntrada;
        private System.Windows.Forms.TextBox txtLongitudEntrada;
        private System.Windows.Forms.ComboBox cboLongitudOrigen;
        private System.Windows.Forms.ComboBox cboLongitudDestino;
        private System.Windows.Forms.Button btnConvertirLongitud;
        private System.Windows.Forms.TextBox txtLongitudResultado;
        private System.Windows.Forms.GroupBox gbFuerza;
        private System.Windows.Forms.Label lblFuerzaEntrada;
        private System.Windows.Forms.TextBox txtFuerzaEntrada;
        private System.Windows.Forms.ComboBox cboFuerzaOrigen;
        private System.Windows.Forms.ComboBox cboFuerzaDestino;
        private System.Windows.Forms.Button btnConvertirFuerza;
        private System.Windows.Forms.TextBox txtFuerzaResultado;

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
            gbPresion = new GroupBox();
            txtPresionResultado = new TextBox();
            btnConvertirPresion = new Button();
            cboPresionDestino = new ComboBox();
            cboPresionOrigen = new ComboBox();
            txtPresionEntrada = new TextBox();
            lblPresionEntrada = new Label();
            gbLongitud = new GroupBox();
            txtLongitudResultado = new TextBox();
            btnConvertirLongitud = new Button();
            cboLongitudDestino = new ComboBox();
            cboLongitudOrigen = new ComboBox();
            txtLongitudEntrada = new TextBox();
            lblLongitudEntrada = new Label();
            gbFuerza = new GroupBox();
            txtFuerzaResultado = new TextBox();
            btnConvertirFuerza = new Button();
            cboFuerzaDestino = new ComboBox();
            cboFuerzaOrigen = new ComboBox();
            txtFuerzaEntrada = new TextBox();
            lblFuerzaEntrada = new Label();
            gbPresion.SuspendLayout();
            gbLongitud.SuspendLayout();
            gbFuerza.SuspendLayout();
            SuspendLayout();
            // 
            // gbPresion
            // 
            gbPresion.Controls.Add(txtPresionResultado);
            gbPresion.Controls.Add(btnConvertirPresion);
            gbPresion.Controls.Add(cboPresionDestino);
            gbPresion.Controls.Add(cboPresionOrigen);
            gbPresion.Controls.Add(txtPresionEntrada);
            gbPresion.Controls.Add(lblPresionEntrada);
            gbPresion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbPresion.Location = new Point(30, 30);
            gbPresion.Name = "gbPresion";
            gbPresion.Size = new Size(450, 250);
            gbPresion.TabIndex = 0;
            gbPresion.TabStop = false;
            gbPresion.Text = "Conversión de Presión";
            // 
            // txtPresionResultado
            // 
            txtPresionResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtPresionResultado.Location = new Point(30, 195);
            txtPresionResultado.Name = "txtPresionResultado";
            txtPresionResultado.ReadOnly = true;
            txtPresionResultado.Size = new Size(390, 27);
            txtPresionResultado.TabIndex = 5;
            txtPresionResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConvertirPresion
            // 
            btnConvertirPresion.BackColor = Color.FromArgb(0, 122, 204);
            btnConvertirPresion.FlatStyle = FlatStyle.Flat;
            btnConvertirPresion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConvertirPresion.ForeColor = Color.White;
            btnConvertirPresion.Location = new Point(140, 145);
            btnConvertirPresion.Name = "btnConvertirPresion";
            btnConvertirPresion.Size = new Size(170, 35);
            btnConvertirPresion.TabIndex = 4;
            btnConvertirPresion.Text = "CONVERTIR";
            btnConvertirPresion.UseVisualStyleBackColor = false;
            btnConvertirPresion.Click += btnConvertirPresion_Click;
            // 
            // cboPresionDestino
            // 
            cboPresionDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPresionDestino.Font = new Font("Segoe UI", 9.75F);
            cboPresionDestino.FormattingEnabled = true;
            cboPresionDestino.Location = new Point(240, 100);
            cboPresionDestino.Name = "cboPresionDestino";
            cboPresionDestino.Size = new Size(180, 25);
            cboPresionDestino.TabIndex = 3;
            // 
            // cboPresionOrigen
            // 
            cboPresionOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPresionOrigen.Font = new Font("Segoe UI", 9.75F);
            cboPresionOrigen.FormattingEnabled = true;
            cboPresionOrigen.Location = new Point(30, 100);
            cboPresionOrigen.Name = "cboPresionOrigen";
            cboPresionOrigen.Size = new Size(180, 25);
            cboPresionOrigen.TabIndex = 2;
            // 
            // txtPresionEntrada
            // 
            txtPresionEntrada.Font = new Font("Segoe UI", 9.75F);
            txtPresionEntrada.Location = new Point(30, 60);
            txtPresionEntrada.Name = "txtPresionEntrada";
            txtPresionEntrada.Size = new Size(390, 25);
            txtPresionEntrada.TabIndex = 1;
            // 
            // lblPresionEntrada
            // 
            lblPresionEntrada.AutoSize = true;
            lblPresionEntrada.Font = new Font("Segoe UI", 9.75F);
            lblPresionEntrada.Location = new Point(30, 35);
            lblPresionEntrada.Name = "lblPresionEntrada";
            lblPresionEntrada.Size = new Size(107, 17);
            lblPresionEntrada.TabIndex = 0;
            lblPresionEntrada.Text = "Valor a convertir:";
            // 
            // gbLongitud
            // 
            gbLongitud.Controls.Add(txtLongitudResultado);
            gbLongitud.Controls.Add(btnConvertirLongitud);
            gbLongitud.Controls.Add(cboLongitudDestino);
            gbLongitud.Controls.Add(cboLongitudOrigen);
            gbLongitud.Controls.Add(txtLongitudEntrada);
            gbLongitud.Controls.Add(lblLongitudEntrada);
            gbLongitud.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbLongitud.Location = new Point(510, 30);
            gbLongitud.Name = "gbLongitud";
            gbLongitud.Size = new Size(450, 250);
            gbLongitud.TabIndex = 1;
            gbLongitud.TabStop = false;
            gbLongitud.Text = "Conversión de Longitud";
            // 
            // txtLongitudResultado
            // 
            txtLongitudResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtLongitudResultado.Location = new Point(30, 195);
            txtLongitudResultado.Name = "txtLongitudResultado";
            txtLongitudResultado.ReadOnly = true;
            txtLongitudResultado.Size = new Size(390, 27);
            txtLongitudResultado.TabIndex = 5;
            txtLongitudResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConvertirLongitud
            // 
            btnConvertirLongitud.BackColor = Color.FromArgb(0, 122, 204);
            btnConvertirLongitud.FlatStyle = FlatStyle.Flat;
            btnConvertirLongitud.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConvertirLongitud.ForeColor = Color.White;
            btnConvertirLongitud.Location = new Point(140, 145);
            btnConvertirLongitud.Name = "btnConvertirLongitud";
            btnConvertirLongitud.Size = new Size(170, 35);
            btnConvertirLongitud.TabIndex = 4;
            btnConvertirLongitud.Text = "CONVERTIR";
            btnConvertirLongitud.UseVisualStyleBackColor = false;
            btnConvertirLongitud.Click += btnConvertirLongitud_Click;
            // 
            // cboLongitudDestino
            // 
            cboLongitudDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLongitudDestino.Font = new Font("Segoe UI", 9.75F);
            cboLongitudDestino.FormattingEnabled = true;
            cboLongitudDestino.Location = new Point(240, 100);
            cboLongitudDestino.Name = "cboLongitudDestino";
            cboLongitudDestino.Size = new Size(180, 25);
            cboLongitudDestino.TabIndex = 3;
            // 
            // cboLongitudOrigen
            // 
            cboLongitudOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLongitudOrigen.Font = new Font("Segoe UI", 9.75F);
            cboLongitudOrigen.FormattingEnabled = true;
            cboLongitudOrigen.Location = new Point(30, 100);
            cboLongitudOrigen.Name = "cboLongitudOrigen";
            cboLongitudOrigen.Size = new Size(180, 25);
            cboLongitudOrigen.TabIndex = 2;
            // 
            // txtLongitudEntrada
            // 
            txtLongitudEntrada.Font = new Font("Segoe UI", 9.75F);
            txtLongitudEntrada.Location = new Point(30, 60);
            txtLongitudEntrada.Name = "txtLongitudEntrada";
            txtLongitudEntrada.Size = new Size(390, 25);
            txtLongitudEntrada.TabIndex = 1;
            // 
            // lblLongitudEntrada
            // 
            lblLongitudEntrada.AutoSize = true;
            lblLongitudEntrada.Font = new Font("Segoe UI", 9.75F);
            lblLongitudEntrada.Location = new Point(30, 35);
            lblLongitudEntrada.Name = "lblLongitudEntrada";
            lblLongitudEntrada.Size = new Size(107, 17);
            lblLongitudEntrada.TabIndex = 0;
            lblLongitudEntrada.Text = "Valor a convertir:";
            // 
            // gbFuerza
            // 
            gbFuerza.Controls.Add(txtFuerzaResultado);
            gbFuerza.Controls.Add(btnConvertirFuerza);
            gbFuerza.Controls.Add(cboFuerzaDestino);
            gbFuerza.Controls.Add(cboFuerzaOrigen);
            gbFuerza.Controls.Add(txtFuerzaEntrada);
            gbFuerza.Controls.Add(lblFuerzaEntrada);
            gbFuerza.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbFuerza.Location = new Point(30, 300);
            gbFuerza.Name = "gbFuerza";
            gbFuerza.Size = new Size(450, 250);
            gbFuerza.TabIndex = 2;
            gbFuerza.TabStop = false;
            gbFuerza.Text = "Conversión de Fuerza";
            // 
            // txtFuerzaResultado
            // 
            txtFuerzaResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtFuerzaResultado.Location = new Point(30, 195);
            txtFuerzaResultado.Name = "txtFuerzaResultado";
            txtFuerzaResultado.ReadOnly = true;
            txtFuerzaResultado.Size = new Size(390, 27);
            txtFuerzaResultado.TabIndex = 5;
            txtFuerzaResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConvertirFuerza
            // 
            btnConvertirFuerza.BackColor = Color.FromArgb(0, 122, 204);
            btnConvertirFuerza.FlatStyle = FlatStyle.Flat;
            btnConvertirFuerza.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConvertirFuerza.ForeColor = Color.White;
            btnConvertirFuerza.Location = new Point(140, 145);
            btnConvertirFuerza.Name = "btnConvertirFuerza";
            btnConvertirFuerza.Size = new Size(170, 35);
            btnConvertirFuerza.TabIndex = 4;
            btnConvertirFuerza.Text = "CONVERTIR";
            btnConvertirFuerza.UseVisualStyleBackColor = false;
            btnConvertirFuerza.Click += btnConvertirFuerza_Click;
            // 
            // cboFuerzaDestino
            // 
            cboFuerzaDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuerzaDestino.Font = new Font("Segoe UI", 9.75F);
            cboFuerzaDestino.FormattingEnabled = true;
            cboFuerzaDestino.Location = new Point(240, 100);
            cboFuerzaDestino.Name = "cboFuerzaDestino";
            cboFuerzaDestino.Size = new Size(180, 25);
            cboFuerzaDestino.TabIndex = 3;
            // 
            // cboFuerzaOrigen
            // 
            cboFuerzaOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuerzaOrigen.Font = new Font("Segoe UI", 9.75F);
            cboFuerzaOrigen.FormattingEnabled = true;
            cboFuerzaOrigen.Location = new Point(30, 100);
            cboFuerzaOrigen.Name = "cboFuerzaOrigen";
            cboFuerzaOrigen.Size = new Size(180, 25);
            cboFuerzaOrigen.TabIndex = 2;
            // 
            // txtFuerzaEntrada
            // 
            txtFuerzaEntrada.Font = new Font("Segoe UI", 9.75F);
            txtFuerzaEntrada.Location = new Point(30, 60);
            txtFuerzaEntrada.Name = "txtFuerzaEntrada";
            txtFuerzaEntrada.Size = new Size(390, 25);
            txtFuerzaEntrada.TabIndex = 1;
            // 
            // lblFuerzaEntrada
            // 
            lblFuerzaEntrada.AutoSize = true;
            lblFuerzaEntrada.Font = new Font("Segoe UI", 9.75F);
            lblFuerzaEntrada.Location = new Point(30, 35);
            lblFuerzaEntrada.Name = "lblFuerzaEntrada";
            lblFuerzaEntrada.Size = new Size(107, 17);
            lblFuerzaEntrada.TabIndex = 0;
            lblFuerzaEntrada.Text = "Valor a convertir:";
            // 
            // FormConversorUnidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(131, 147, 164);
            ClientSize = new Size(990, 580);
            Controls.Add(gbFuerza);
            Controls.Add(gbLongitud);
            Controls.Add(gbPresion);
            Name = "FormConversorUnidades";
            Text = "Conversor de Unidades";
            Load += FormConversorUnidades_Load;
            gbPresion.ResumeLayout(false);
            gbPresion.PerformLayout();
            gbLongitud.ResumeLayout(false);
            gbLongitud.PerformLayout();
            gbFuerza.ResumeLayout(false);
            gbFuerza.PerformLayout();
            ResumeLayout(false);
        }
    }
}