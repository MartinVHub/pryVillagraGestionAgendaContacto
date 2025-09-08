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
            listBox1 = new ListBox();
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
            txtContacto.TextChanged += this.txtContacto_TextChanged;
            // 
            // mtbNumero
            // 
            mtbNumero.Font = new Font("Segoe UI", 12F);
            mtbNumero.Location = new Point(282, 137);
            mtbNumero.Mask = "99999";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(100, 29);
            mtbNumero.TabIndex = 3;
            mtbNumero.ValidatingType = typeof(int);
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
            btnCancelar.Location = new Point(168, 248);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(344, 248);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 40);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(262, 315);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 7;
            // 
            // AgendaContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(586, 450);
            Controls.Add(listBox1);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(mtbNumero);
            Controls.Add(txtContacto);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Name = "AgendaContacto";
            Text = "Agenda Contacto";
            Load += this.AgendaContacto_Load;
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
        private ListBox listBox1;
    }
}
