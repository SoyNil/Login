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

namespace Inicio_Sesion
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void login()
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void btningre_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-C0BT61P;Initial Catalog=LOGIN;Integrated Security=True");
            cn.Open();
            SqlCommand cm = new SqlCommand("select IDUsuario, CONTRA from SESION where IDUsuario='"+usuario.Text+"'and CONTRA='"+contra.Text+"'",cn);
            cm.Parameters.AddWithValue("IDUsuario", usuario);
            cm.Parameters.AddWithValue("CONTRA", contra);
            SqlDataAdapter sda = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count==1)
            {
                this.Hide();
                if (dt.Rows[0][0].ToString() == "usuario")
                {

                }
                //MessageBox.Show("Login Exitoso", "Sistema");
                
                //new UsuarioCorrecto(dt.Rows[0],IDUsuario);
            }
            else
            {
                MessageBox.Show("Login Incorrecto", "Sistema");
            }
        }
    }
}
