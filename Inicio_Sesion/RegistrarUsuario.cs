using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace Inicio_Sesion
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }
        private void login(string text, string text1)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-C0BT61P;Initial Catalog=LOGIN;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand("select IDUsuario, CONTRA from SESION where IDUsuario='" + nomb.Text + "'and CONTRA='" + contr.Text + "'", cn);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Este usuario ya está en nuestro sistema, intente uno nuevo", "Sistema");
                //new UsuarioCorrecto(nomb.Text).Show();
            }
            else
            {
                MessageBox.Show("Login Incorrecto", "Sistema");
            }
        }
    }
}
