using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

using System.Threading.Tasks;

namespace EditText
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonSaludar_Clicked(object sender, EventArgs e)
        {
            //Declaración de variable
            string nombre;

            //Acceso al componente Entry, obtención de datos por medio de la propiedad Text
            nombre = EntryNombre.Text;

            //Acceso al componente Label y colocandole el saludo
            //LabelSaludo.Text = "Hola " + nombre;

            //Hola desde Toast
            await Toast.Make("Hola " + nombre + "desde un Toast", ToastDuration.Long, 14).Show();
        }
    }
}
