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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = Fercejor2021; Integrated Security = True");

        public void logear(string usuario, string contraseña)
        {
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand("SELECT Nombre, Tipo_usuario FROM usuarios WHERE Usuario = @usuario AND Password = @pas", conexion);
                command.Parameters.AddWithValue("usuario", usuario);
                command.Parameters.AddWithValue("pas", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        new FormMenu(dt.Rows[0][0].ToString()).Show();
                        
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new FormReporte(dt.Rows[0][0].ToString()).Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }



        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            
            textUsuario.Clear();
            textContraseña.Clear();
            this.Show();
            textUsuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.textUsuario.Text, this.textContraseña.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
