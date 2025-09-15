namespace pryVillagraGestionAgendaContacto
{
    partial class AgendaContacto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblContacto = new Label();
            lblNumero = new Label();
            txtContacto = new TextBox();
            mtbNumero = new MaskedTextBox();
            lblGestionAgendaContacto = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            lstResumen = new ListBox();
            lblCant = new Label();
            lblFechay = new Label();
            lblCantidad = new Label();
            lblFecha = new Label();
            lblCantContacto = new Label();
            lblFechaHora = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(79, 82);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(90, 25);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(79, 133);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(83, 25);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 12F);
            txtContacto.Location = new Point(235, 82);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 29);
            txtContacto.TabIndex = 2;
            // 
            // mtbNumero
            // 
            mtbNumero.Font = new Font("Segoe UI", 12F);
            mtbNumero.Location = new Point(235, 133);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 29);
            mtbNumero.TabIndex = 3;
            // 
            // lblGestionAgendaContacto
            // 
            lblGestionAgendaContacto.AutoSize = true;
            lblGestionAgendaContacto.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionAgendaContacto.Location = new Point(42, 19);
            lblGestionAgendaContacto.Name = "lblGestionAgendaContacto";
            lblGestionAgendaContacto.Size = new Size(333, 30);
            lblGestionAgendaContacto.TabIndex = 4;
            lblGestionAgendaContacto.Text = " GESTIÓN AGENDA CONTACTO";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(95, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(245, 210);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 40);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lstResumen
            // 
            lstResumen.FormattingEnabled = true;
            lstResumen.ItemHeight = 15;
            lstResumen.Location = new Point(95, 271);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(225, 64);
            lstResumen.TabIndex = 7;
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Location = new Point(103, 367);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(84, 15);
            lblCant.TabIndex = 8;
            lblCant.Text = "Cant Contacto";
            // 
            // lblFechay
            // 
            lblFechay.AutoSize = true;
            lblFechay.Location = new Point(103, 407);
            lblFechay.Name = "lblFechay";
            lblFechay.Size = new Size(76, 15);
            lblFechay.TabIndex = 9;
            lblFechay.Text = "Fecha y Hora";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(292, 367);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(0, 15);
            lblCantidad.TabIndex = 10;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(292, 407);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 15);
            lblFecha.TabIndex = 11;
            // 
            // lblCantContacto
            // 
            lblCantContacto.AutoSize = true;
            lblCantContacto.Location = new Point(237, 370);
            lblCantContacto.Name = "lblCantContacto";
            lblCantContacto.Size = new Size(17, 15);
            lblCantContacto.TabIndex = 12;
            lblCantContacto.Text = "\"\"";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(237, 407);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(17, 15);
            lblFechaHora.TabIndex = 13;
            lblFechaHora.Text = "\"\"";
            // 
            // AgendaContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(446, 450);
            Controls.Add(lblFechaHora);
            Controls.Add(lblCantContacto);
            Controls.Add(lblFecha);
            Controls.Add(lblCantidad);
            Controls.Add(lblFechay);
            Controls.Add(lblCant);
            Controls.Add(lstResumen);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(lblGestionAgendaContacto);
            Controls.Add(mtbNumero);
            Controls.Add(txtContacto);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Name = "AgendaContacto";
            Text = "Agenda Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblNumero;
        private TextBox txtContacto;
        private MaskedTextBox mtbNumero;
        private Label lblGestionAgendaContacto;
        private Button btnCancelar;
        private Button btnRegistrar;
        private ListBox lstResumen;
        private Label lblCant;
        private Label lblFechay;
        private Label lblCantidad;
        private Label lblFecha;
        private Label lblCantContacto;
        private Label lblFechaHora;
    }
}
