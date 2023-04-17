namespace Form_Ejercicio_C02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conversosFarenheit_Click(object sender, EventArgs e)
        {
            bool parseOK = double.TryParse(txb_farenheit.Text, out double temperatura);
            if (parseOK)
            {
                Temperaturas.Farenheit farenheit = new Temperaturas.Farenheit(temperatura);

                txb_resFarenOnFaren.Text = farenheit.ToString();

                txb_resFarenOnCel.Text = ((Temperaturas.Celsius)farenheit).ToString();

                txb_resFarenOnKelvin.Text = Temperaturas.Farenheit.ConvertirFarenAKelv(farenheit).ToString();
            }
        }

        private void btn_conversorCelsius_MouseClick(object sender, MouseEventArgs e)
        {
            bool parseOK = double.TryParse(txb_celsius.Text, out double temperatura);
            if (parseOK)
            {
                Temperaturas.Celsius celsius = new Temperaturas.Celsius(temperatura);

                txb_resCelOnFaren.Text = ((Temperaturas.Farenheit)celsius).ToString();

                txb_resCelOnCel.Text = celsius.ToString();

                txb_resCelOnKelvin.Text = ((Temperaturas.Kelvin)celsius).ToString();
            }
        }

        private void btn_conversosKelvin_Click(object sender, EventArgs e)
        {
            bool parseOK = double.TryParse(txb_kelvin.Text, out double temperatura);

            if(parseOK)
            {
                Temperaturas.Kelvin kelvin = new Temperaturas.Kelvin(temperatura);

                txb_resKelvinOnFaren.Text = ((Temperaturas.Farenheit)kelvin).ToString();

                txb_resKelvinOnCel.Text = ((Temperaturas.Celsius)kelvin).ToString();

                txb_resKelvinOnKelvin.Text = kelvin.ToString();
            }
        }
    }
}