namespace Imagen
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        string[] imagenes = new string[]
        {
            "https://picsum.photos/id/237/200/300",
            "https://picsum.photos/id/238/200/300",
            "https://picsum.photos/id/239/200/300",
            "https://picsum.photos/id/240/200/300",
            "https://picsum.photos/id/241/200/300",
        };
        private void Button_Clicked(object? sender, EventArgs e)
        {
            Random random = new Random();
            Image.Source = imagenes[random.Next(imagenes.Length)]; ;
        }
    }
}
