using System.Drawing.Text;

namespace pryVillagraGestionAgendaContacto
{
    public partial class AgendaContacto : Form
    {
        public AgendaContacto()
        {
            InitializeComponent();
        }


        string vContacto = "";
        string vNumero = "";
        DateTime vFecha = DateTime.Now;

        string[] vecContactos = new string[5];
        string[] vecNumero = new string[5];
        int v = 0;
        int vContador = 0;


        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text == "")
            {
                mtbNumero.Enabled = false;

            }
            else
            {
                mtbNumero.Enabled = true;

            }
        }

        private void btnCancelar_click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mtbNumero.Text = "";
        }


        int indice = 0;

        private void btnAceptar_click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;
            vecContactos[indice] = mtbNumero.Text;


            lstResumen.Items.Add("contacto: + vContacto + = Telefono: ");

            vContador = vContador + 1;
            txtContacto.Text = Convert.ToString(vContador);
            mtbNumero.Text = Convert.ToString(vFecha);

            txtContacto.Text = "";
            mtbNumero.Text = "";

            indice++;
            txtContacto.Focus();
        }
    }
}

      
    



