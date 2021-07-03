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
    public partial class FormFacturas : Form
    {
        public FormFacturas()
        {
            InitializeComponent();
        }

        SqlConnection conx = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = Fercejor2021; Integrated Security = True");

        public void llenarTabla()
        {
            string consulta = "select * from Factura";
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
            textCodigoFact.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textCodigoPedido.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textCodigoCliente.Text = dataGridView1.SelectedCells[2].Value.ToString();
            cboTipoCliente.SelectedIndex = int.Parse(dataGridView1.SelectedCells[3].Value.ToString())-1;
            textMonto.Text = dataGridView1.SelectedCells[4].Value.ToString();
            textFecha.Text = dataGridView1.SelectedCells[5].Value.ToString();

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conx.Open();
            int codigoFactura = int.Parse(textCodigoFact.Text);
            int codigoPedido = int.Parse(textCodigoPedido.Text);
            int codigoClien = int.Parse(textCodigoCliente.Text);
            int tipClien = 0;
            if (cboTipoCliente.SelectedItem.Equals("Natural"))
            {
                tipClien = 1;
            }
            else
            {
                tipClien = 2;
            }
            Double monto = Double.Parse(textMonto.Text);
            String sql = "INSERT INTO Factura(IdFactura,IdPedido,IdCliente,IdTipoCliente,Monto,Fecha) values('" + codigoFactura + "','" + codigoPedido + "','" + codigoClien + "','" + tipClien +"','" + monto + "','" + DateTime.Now + "')";
            SqlCommand comando = new SqlCommand(sql, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado correctamente");
            llenarTabla();
            textCodigoFact.Text = null;
            textCodigoPedido.Text = null;
            textCodigoCliente.Text = null;
            cboTipoCliente.Text = null;
            textMonto.Text = null;
            conx.Close();       
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conx.Open();

            String consulta = " delete from Factura where IdFactura=" + textCodigoFact.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenarTabla();
            textCodigoFact.Text = null;
            textCodigoPedido.Text = null;
            textCodigoCliente.Text = null;
            cboTipoCliente.Text = null;
            textMonto.Text = null;

            conx.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conx.Open();
            int tipClien;
            if (cboTipoCliente.SelectedItem.Equals("Natural"))
            {
                tipClien = 1;
            }
            else
            {
                tipClien = 2;
            }
            string consulta = "update Factura set IdFactura=" + textCodigoFact.Text + ",IdPedido=" + textCodigoPedido.Text + " ,IdCliente=" + textCodigoCliente.Text + ", IdTipoCliente=" + tipClien + ", Monto=" + textMonto.Text + "where IdFactura='" + textCodigoFact.Text + "'";
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

            String consulta = "select * from Factura where IdFactura= " + textCodigoFact.Text + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conx);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            conx.Close();
        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}
