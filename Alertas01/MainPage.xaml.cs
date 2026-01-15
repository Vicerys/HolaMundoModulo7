using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Alertas01
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonAlert_Clicked(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Alerta", "Hola Mundo", "OK");
        }


        private async void ButtonAlert2_Clicked(object sender, EventArgs e)
        {
            bool respuesta = await DisplayAlertAsync("Piensalo carnalito", "¿Estás seguro carnalito?", "Simón", "Nel");
            if (respuesta)
            {
                await Toast.Make("Si", ToastDuration.Long, 14).Show();
            }
            else
            {
                await Toast.Make("No", ToastDuration.Long, 14).Show();
            }
        }

        private async void ButtonAlert3_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Nombre", "¿Cual es su nombre?");
            await Toast.Make(result, ToastDuration.Long, 14).Show();
        }

        private async void ButtonDisplayActionSheet_Clicked(object sender, EventArgs e)
        {
            string[] frutas = { "Manzana", "Naranja", "Platano" };
            var data = await DisplayActionSheetAsync("Elija una fruta", null, null, frutas);
            await Toast.Make(data, ToastDuration.Long, 14).Show();
        }

        private async void ButtonToast_Clicked(object sender, EventArgs e)
        {
            await Toast.Make("Hola Mundo", ToastDuration.Long, 14).Show();
        }
    }
}
