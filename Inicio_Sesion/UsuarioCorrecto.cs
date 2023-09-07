using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_Sesion
{
    public partial class UsuarioCorrecto : Form
    {
        public UsuarioCorrecto(string IDUsuario)
        {
            InitializeComponent();
            Hola.Text = Hola.Text +"Hola, "+IDUsuario+"!";
        }

        private void UsuarioCorrecto_Load(object sender, EventArgs e)
        {

        }

        private void NombrUsu_Click(object sender, EventArgs e)
        {

        }
    }
}
