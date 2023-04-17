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
    }
}