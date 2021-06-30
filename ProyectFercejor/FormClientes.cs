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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        SqlConnection conx = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = Fercejor2021; Integrated Security = True");

        public void llenarTabla()
        {
            string consulta = "select * from Cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            DataTable dta = new DataTable();
            adaptador.Fill(dta);
            dataGridView1.DataSource = dta;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCodigoCliente.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textRuc.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textRaznSoc.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textDirec.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textTelefono.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conx.Open();
            int codigoCliente = int.Parse(textCodigoCliente.Text);
            String RUC = textRuc.Text;
            String razonSocial = textRaznSoc.Text;
            String direcc = textDirec.Text;
            String telefo = textTelefono.Text;
            String sql = "INSERT INTO Cliente(IdCliente,RUC,RazonSocial,Direccion,Telefono) values('" + codigoCliente + "','" + RUC + "','" + razonSocial + "','" + direcc + "','" + telefo + "')";
            SqlCommand comando = new SqlCommand(sql, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado correctamente");
            textCodigoCliente.Text = null;
            textRuc.Text = null;
            textRaznSoc.Text = null;
            textDirec.Text = null;
            textTelefono.Text = null;

            llenarTabla();

            conx.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conx.Open();

            String consulta = " delete from Cliente where IdCliente=" + textCodigoCliente.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenarTabla();
            textCodigoCliente.Text = null;
            textRuc.Text = null;
            textRaznSoc.Text = null;
            textDirec.Text = null;
            textTelefono.Text = null;

            conx.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conx.Open();
            string consulta = "update Cliente set IdCliente=" + textCodigoCliente.Text + ",RUC='" + textRuc.Text + "' ,RazonSocial='" + textRaznSoc.Text + "', Direccion='" + textDirec.Text + "', Telefono='" + textTelefono.Text + "'where IdCliente=" + textCodigoCliente.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conx);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Registro modificado");
            }
            llenarTabla();
            conx.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conx.Open();

            String consulta = "select * from Cliente where IdCliente= " + textCodigoCliente.Text + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            DataTable dta = new DataTable();
            adaptador.Fill(dta);
            dataGridView1.DataSource = dta;
            SqlCommand comando = new SqlCommand(consulta, conx);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            conx.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //String consulta = "select * from Cliente";
            //SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            //DataTable dta = new DataTable();
            //adaptador.Fill(dta);
            //dataGridView1.DataSource = dta;

            //textCodigoCliente.Text = dataGridView1.SelectedCells[0].Value.ToString();
            //textRuc.Text = dataGridView1.SelectedCells[1].Value.ToString();
            //textRaznSoc.Text = dataGridView1.SelectedCells[2].Value.ToString();
            //textDirec.Text = dataGridView1.SelectedCells[3].Value.ToString();
            //textTelefono.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}
