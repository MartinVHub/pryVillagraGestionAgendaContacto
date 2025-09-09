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
            label3 = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            lstResumen = new ListBox();
            lblcantcontacto = new Label();
            label2 = new Label();
            lblCantidad = new Label();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(130, 82);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(90, 25);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(134, 135);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(83, 25);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 12F);
            txtContacto.Location = new Point(282, 82);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 29);
            txtContacto.TabIndex = 2;
            // 
            // mtbNumero
            // 
            mtbNumero.Font = new Font("Segoe UI", 12F);
            mtbNumero.Location = new Point(282, 137);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 29);
            mtbNumero.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(134, 9);
            label3.Name = "label3";
            label3.Size = new Size(365, 32);
            label3.TabIndex = 4;
            label3.Text = " GESTIÓN AGENDA CONTACTO";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(157, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(302, 210);
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
            lstResumen.Location = new Point(157, 273);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(225, 64);
            lstResumen.TabIndex = 7;
            // 
            // lblcantcontacto
            // 
            lblcantcontacto.AutoSize = true;
            lblcantcontacto.Location = new Point(157, 367);
            lblcantcontacto.Name = "lblcantcontacto";
            lblcantcontacto.Size = new Size(84, 15);
            lblcantcontacto.TabIndex = 8;
            lblcantcontacto.Text = "Cant Contacto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 407);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 9;
            label2.Text = "Fecha y Hora";
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
            // AgendaContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(586, 450);
            Controls.Add(lblFecha);
            Controls.Add(lblCantidad);
            Controls.Add(label2);
            Controls.Add(lblcantcontacto);
            Controls.Add(lstResumen);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
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
        private Label label3;
        private Button btnCancelar;
        private Button btnRegistrar;
        private ListBox lstResumen;
        private Label lblcantcontacto;
        private Label label2;
        private Label lblCantidad;
        private Label lblFecha;
    }
}
