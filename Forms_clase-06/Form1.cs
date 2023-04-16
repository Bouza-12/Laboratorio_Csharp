namespace Forms_clase_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Persona> lista = new List<Persona>();

        public  void AgregarPersona(Persona p)
        {
            lista.Add(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click Botón");


            var nombre = txb_nombre.Text;

            lbl_titulo.Text = "Hola " + nombre;


        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formPersona = new FormPersona();

            formPersona.ShowDialog();

            
        }

        
    }
}