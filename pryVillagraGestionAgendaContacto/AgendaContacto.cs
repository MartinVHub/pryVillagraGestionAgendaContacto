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

        private void btnRegistrar_click(object sender, EventArgs e)
        {
            if (txtContacto.Text != "" && mtbNumero.Text !="")


            { 
                
                vContacto = txtContacto.Text;
                vNumero = mtbNumero.Text;

                //Guardar en los vectores
                vecContactos[indice] = vContacto;
                vecNumero[indice] = vNumero;

                //Mostrar en el ListBox


                lstResumen.Items.Add("contacto: " + vContacto + " - Telefono: " + vNumero);

                //Aumentar contador
                vContador++;
                indice++;

                //Mostrar cantidad y fecha/hora en labels
                 lblCant.Text = "CantContacto: " vContador.ToString();
                lblFechay.Text = "Fecha y Hora: " + DateTime.Now.ToString();
                
                //Limpiar campos

                txtContacto.Text = "";
                mtbNumero.Text = "";

                //Volver el foco al textbox

                 txtContacto.Focus();
               
            }
            else
            {
                MessageBox.Show("Debe completar ambos campos.");
            }
    }


        private void btnCancelar_click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mtbNumero.Text = "";
            txtContacto.Focus();
        }



      
    



