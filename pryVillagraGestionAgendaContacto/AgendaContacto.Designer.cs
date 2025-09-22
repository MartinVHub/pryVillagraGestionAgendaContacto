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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaContacto));
            lblContacto = new Label();
            lblNumero = new Label();
            txtContacto = new TextBox();
            mtbNumero = new MaskedTextBox();
            lblGestion = new Label();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            lstResumen = new ListBox();
            lblcantcontacto = new Label();
            lblFechayHora = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(116, 82);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(90, 25);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(116, 137);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(83, 25);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 12F);
            txtContacto.Location = new Point(255, 82);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 29);
            txtContacto.TabIndex = 2;
            // 
            // mtbNumero
            // 
            mtbNumero.Font = new Font("Segoe UI", 12F);
            mtbNumero.Location = new Point(255, 133);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 29);
            mtbNumero.TabIndex = 3;
            // 
            // lblGestion
            // 
            lblGestion.AutoSize = true;
            lblGestion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestion.Location = new Point(68, 9);
            lblGestion.Name = "lblGestion";
            lblGestion.Size = new Size(365, 32);
            lblGestion.TabIndex = 4;
            lblGestion.Text = " GESTIÓN AGENDA CONTACTO";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(117, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(272, 200);
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
            lstResumen.Location = new Point(130, 270);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(225, 64);
            lstResumen.TabIndex = 7;
            // 
            // lblcantcontacto
            // 
            lblcantcontacto.AutoSize = true;
            lblcantcontacto.Location = new Point(130, 367);
            lblcantcontacto.Name = "lblcantcontacto";
            lblcantcontacto.Size = new Size(84, 15);
            lblcantcontacto.TabIndex = 8;
            lblcantcontacto.Text = "Cant Contacto";
            // 
            // lblFechayHora
            // 
            lblFechayHora.AutoSize = true;
            lblFechayHora.Location = new Point(130, 407);
            lblFechayHora.Name = "lblFechayHora";
            lblFechayHora.Size = new Size(76, 15);
            lblFechayHora.TabIndex = 9;
            lblFechayHora.Text = "Fecha y Hora";
            // 
            // AgendaContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(465, 450);
            Controls.Add(lblFechayHora);
            Controls.Add(lblcantcontacto);
            Controls.Add(lstResumen);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(lblGestion);
            Controls.Add(mtbNumero);
            Controls.Add(txtContacto);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AgendaContacto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblNumero;
        private TextBox txtContacto;
        private MaskedTextBox mtbNumero;
        private Label lblGestion;
        private Button btnCancelar;
        private Button btnRegistrar;
        private ListBox lstResumen;
        private Label lblcantcontacto;
        private Label lblFechayHora;
    }
}
