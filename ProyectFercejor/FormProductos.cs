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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro Cerrar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            new FormLogin().Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conx = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = LoginProyecto; Integrated Security = True");
            conx.Open();
            String nombre = textNombre.Text;
            float precio = float.Parse(textPrecio.Text);
            int cantidad = int.Parse(textCantidad.Text);
            String desc = textDescripcion.Text;
            String sql = "INSERT INTO productos(nombre,precio,cantidad,descp) values('" + nombre + "','" + precio + "','" + cantidad + "','" + desc + "')";
            SqlCommand comando = new SqlCommand(sql, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado correctamente");
            textNombre.Text = null;
            textPrecio.Text = null;
            textCantidad.Text = null;
            textDescripcion.Text = null;
            conx.Close();

        }
    }
}
