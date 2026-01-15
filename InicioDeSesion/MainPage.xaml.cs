using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace InicioDeSesion
{
    public partial class MainPage : ContentPage
    {
        IniciarSersionService _service;

        public MainPage(IniciarSersionService iniciodeSesionService)
        {
            InitializeComponent();
            _service = iniciodeSesionService;
        }

        private void Button_Clicked(object? sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = EntryUsuario.Text.Trim();
            contrasena = EntryContrasena.Text.Trim();

            bool resultado = _service.IniciarSesion(usuario, contrasena);

            if (resultado)
            {
                Toast.Make("Inicio de sesión exitoso." + usuario, ToastDuration.Long, 14).Show();
            }
            else
            {
                Toast.Make("Usuario o contraseña incorrectos.", ToastDuration.Long, 14).Show();
            }
        }
    }
}
