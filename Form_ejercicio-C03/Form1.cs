using Sob_C01;

namespace Form_ejercicio_C03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_binToDec_Click(object sender, EventArgs e)
        {
            int convertir;
            bool pareseadoOK = int.TryParse(txb_binToDec.Text, out convertir);
            bool CerosyUnos = Conversor.EsBinario(txb_binToDec.Text);



            if (pareseadoOK && CerosyUnos)
            {
                txb_resultadoDec.Text = Conversor.ConvertirBinarioADecimal(convertir).ToString();
            }
            else
            {
                MessageBox.Show("Debe Ingresar un numero Binario, solo admite '0's y '1's");
            }

        }

        private void btn_decToBin_Click(object sender, EventArgs e)
        {
            int convertir;
            bool parseadoOK = int.TryParse(txb_decToBin.Text, out convertir);

            if (parseadoOK)
            {
                txb_resultadoBin.Text = Conversor.ConvertirDecimalABinario(convertir);
            }
            else
            {
                MessageBox.Show("Debe Ingresar un numero");
            }
        }
    }
}