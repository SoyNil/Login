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
        public UsuarioCorrecto(string usuario)
        {
            InitializeComponent();
            Hola.Text = usuario;
        }
    }
}
