using Ingresante;
using System.Runtime.CompilerServices;
using System.Text;

namespace For_Ejercicio_I02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            var nombre = txb_nombre.Text;
            var direccion = txb_direccion.Text;
            var edad = nud_edad.Value;
            var genero = "";

            if (rbtn_femenino.Checked)
            {
                genero = rbtn_femenino.Text;
            }
            else if (rbtn_masculino.Checked)
            {
                genero = rbtn_masculino.Text;
            }
            else if (rbtn_noBinario.Checked)
            {
                genero = rbtn_noBinario.Text;
            }

            var pais = lib_pais.Text;
            List<string> cursos = new List<string>();
            if (chkb_cpp.Checked)
            {
                cursos.Add("C++");
            }
            if (chkb_csharp.Checked)
            {
                cursos.Add("C#");
            }
            if (chkb_javascript.Checked)
            {
                cursos.Add("JavaScript");
            }
            
            Ingresante.Ingresante ingresante = new Ingresante.Ingresante(nombre,direccion,genero,pais,cursos,(int)edad);

            MessageBox.Show(ingresante.ToString());



        }

        
    }
}