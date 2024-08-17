namespace RegistroContactosApp
{
    public partial class registroContactos : Form
    {
        public registroContactos()
        {
            InitializeComponent();
        }
        private void ButtonAgregar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAgregar_Click_1(object sender, EventArgs e)
        {
            if (TextBoxNombre.Text != "" && TextBoxTelefono.Text != "" && TextBoxEmail.Text != "")
            {
                ListBoxContactos.Items.Add($"{TextBoxNombre.Text} - {TextBoxTelefono.Text} - {TextBoxEmail.Text}");
                LabelEstado.Text = "Contacto agregado con éxito!";
            }
            else
            {
                LabelEstado.Text = "Por favor, complete todos los campos.";
            }
        }

        private void ButtonLimpiar_Click_1(object sender, EventArgs e)
        {
            TextBoxNombre.Clear();
            TextBoxTelefono.Clear();
            TextBoxEmail.Clear();

            LabelEstado.Text = "";
        }

        private void ListBoxContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
