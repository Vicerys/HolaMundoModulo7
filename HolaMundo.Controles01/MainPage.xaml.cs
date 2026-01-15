namespace HolaMundo.Controles01
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = EntryNombre.Text;
            LabelNombre.Text = nombre;

            if (int.TryParse(EntryEdad.Text, out int edad)){

            }
            else
            {
                DisplayAlert("Error", "La edad debe ser un número válido", "OK");
            }
        }

    }
}
