using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_clase_06
{
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();
        }

        private Persona _persona;

        public Persona Persona
        {
            get { return _persona; }
        }


        private void CerrarFormulario()
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            //instancia objeto
            _persona = new Persona(txb_nombre.Text, int.Parse(txb_legajo.Text));

            

            CerrarFormulario();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //instancia objeto

            CerrarFormulario();
        }

    }
}
