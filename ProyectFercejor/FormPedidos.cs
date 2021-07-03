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
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        SqlConnection conx = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = Fercejor2021; Integrated Security = True");

        public void llenarTabla()
        {
            string consulta = "select * from Pedido";
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
            textCodigoPedido.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textCodigoCliente.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textDescuento.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textFecha.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textDetalle.Text = dataGridView1.SelectedCells[4].Value.ToString();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conx.Open();
            int codigoPed = int.Parse(textCodigoPedido.Text);
            int codigoClien = int.Parse(textCodigoCliente.Text);
            int descuento = int.Parse(textDescuento.Text);           
            String detalle = textDetalle.Text;
            String sql = "INSERT INTO Pedido(IdPedido,IdCliente,Descuento,Fecha,Detalle) values('" + codigoPed + "','" + codigoClien + "','" + descuento + "','" + DateTime.Now + "','" + detalle + "')";
            SqlCommand comando = new SqlCommand(sql, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado correctamente");
            llenarTabla();
            textCodigoPedido.Text = null;
            textCodigoCliente.Text = null;
            textDescuento.Text = null;
            textDetalle.Text = null;
            conx.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conx.Open();

            String consulta = " delete from Pedido where IdPedido=" + textCodigoPedido.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenarTabla();
            textCodigoPedido.Text = null;
            textCodigoCliente.Text = null;
            textDescuento.Text = null;
            textDetalle.Text = null;

            conx.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conx.Open();
            string consulta = "update Pedido set IdPedido=" + textCodigoPedido.Text + ",IdCliente=" + textCodigoCliente.Text + " ,Descuento=" + textDescuento.Text + ", Detalle='" + textDetalle.Text + "'where IdPedido='" + textCodigoPedido.Text + "'";
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

            String consulta = "select * from Pedido where IdPedido= " + textCodigoPedido.Text + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conx);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            conx.Close();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}
