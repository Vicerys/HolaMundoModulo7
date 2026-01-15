

namespace RFC
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonRFC_Clicked(object sender, EventArgs e)
        {
            string nombre;
            string primerApellido;
            string segundoApellido;
            DateTime fechadeNacimiento;
            string RFC;
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

            nombre = EntryNombre.Text;
            primerApellido = EntryPrimerApellido.Text;
            segundoApellido = EntrySegundoApellido.Text;
            fechadeNacimiento = (DateTime)DatePicker.Date;

            //4 digitos de los nombres
            char[] caracteres = primerApellido.ToCharArray();

            if (caracteres[0] == 'Ñ')
            {
                RFC = "X";
            }
            else
            {
                RFC = caracteres[0].ToString();
            }


            bool flag = true;
            foreach (char c in caracteres)
            {
                if (flag)
                {
                    foreach (char v in vocales)
                    {
                        if (c == v)
                        {
                            RFC = RFC + c;
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            caracteres = segundoApellido.ToCharArray();
            RFC = RFC + caracteres[0].ToString();
            caracteres = nombre.ToCharArray();
            RFC = RFC + caracteres[0].ToString();

            //6 dígitos numéricos (fecha de nacimiento en formato AAMMDD)
            RFC = RFC + fechadeNacimiento.ToString("yy");
            RFC = RFC + fechadeNacimiento.ToString("MM");
            RFC = RFC + fechadeNacimiento.ToString("dd");

            //Mostrar resultado en un label
            LabelRFC.Text = "Tu RFC es: " + RFC;
        }
    }
}
