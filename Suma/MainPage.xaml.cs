using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Suma
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonSuma_Clicked(object sender, EventArgs e)
        {
            decimal numero1;
            decimal numero2;

            try
            {
                if (Decimal.TryParse(EntryNumero1.Text, out numero1))
                {
                }
                else
                {
                    await Toast.Make("el valor" + EntryNumero1.Text + "no es un número.", ToastDuration.Long, 14).Show();
                }

                if (Decimal.TryParse(EntryNumero2.Text, out numero2))
                {
                }
                else
                {
                    await Toast.Make("el valor" + EntryNumero2.Text + "no es un número.", ToastDuration.Long, 14).Show();
                }

                decimal suma = numero1 + numero2;
                await Toast.Make("La suma es: " + suma, ToastDuration.Long, 14).Show();

            }
            catch (Exception ex)
            {
                await Toast.Make("ocurrió un error al sumar " + ex, ToastDuration.Long, 14).Show();
            }

        }
    }
}
