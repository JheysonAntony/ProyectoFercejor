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

        SqlConnection conx = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = LoginProyecto; Integrated Security = True");
        
        public void llenarTabla()
        {
            String consulta = "select * from productos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
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
            //SqlConnection conx = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = LoginProyecto; Integrated Security = True");
            conx.Open();
            int codigo = int.Parse(textCodigo.Text);
            String nombre = textNombre.Text;
            float precio = float.Parse(textPrecio.Text);
            int cantidad = int.Parse(textCantidad.Text);
            String desc = textDescripcion.Text;
            String sql = "INSERT INTO productos(codigo,nombre,precio,cantidad,descp) values('" + codigo + "','" + nombre + "','" + precio + "','" + cantidad + "','" + desc + "')";
            SqlCommand comando = new SqlCommand(sql, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado correctamente");
            textCodigo.Text = null;
            textNombre.Text = null;
            textPrecio.Text = null;
            textCantidad.Text = null;
            textDescripcion.Text = null;

            String consulta = "select * from productos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            conx.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCodigo.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textPrecio.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textCantidad.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textDescripcion.Text = dataGridView1.SelectedCells[4].Value.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conx.Open();

            String consulta = " delete from productos where codigo=" + textCodigo.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conx);   
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenarTabla();
            textCodigo.Text = null;
            textNombre.Text = null;
            textPrecio.Text = null;
            textCantidad.Text = null;
            textDescripcion.Text = null;

            conx.Close();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conx.Open();
            string consulta = "update productos set codigo=" + textCodigo.Text + ",nombre='" + textNombre.Text + "' ,precio=" + textPrecio.Text + ", cantidad=" + textCantidad.Text + ", descp='" + textDescripcion.Text + "'where codigo='" + textCodigo.Text + "'" ;
            SqlCommand comando = new SqlCommand(consulta, conx);
            int cant;
            cant = comando.ExecuteNonQuery();
            if(cant > 0)
            {
                MessageBox.Show("Registro modificado");
            }
            llenarTabla();
            conx.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conx.Open();

            String consulta = "select * from productos where codigo= " + textCodigo.Text + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conx);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            conx.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String consulta = "select * from productos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;

            textCodigo.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textPrecio.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textCantidad.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textDescripcion.Text = dataGridView1.SelectedCells[4].Value.ToString();

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}
