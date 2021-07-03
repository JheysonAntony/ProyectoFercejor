using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectFercejor
{
    public partial class Usuario : Form
    {
        public Usuario(string nombre)
        {
            InitializeComponent();
            lblmensaje.Text = nombre;
        }
        SqlConnection conx = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = prueba; Integrated Security = True");
        DateTime hoy = DateTime.Now;

       

        private void Usuario_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conx.Open();
            DateTime fech =  DateTime.Parse(textFechita.Text = hoy.ToString("dd/MM/yy"));
            //int codigo = int.Parse(textCodigo.Text);
            
            
            String sql = "INSERT INTO Data(Fecha) values('" + fech + "')";
            SqlCommand comando = new SqlCommand(sql, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado correctamente");
            

            

            conx.Close();
        }
    }
}
