using Billetes;

namespace Form_Ejercicio_c01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btn_contertEuro_Click(object sender, EventArgs e)
        {
            txb_euro_euro.Text = string.Format("100");
        }
    }
}