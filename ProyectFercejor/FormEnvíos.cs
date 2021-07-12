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
    public partial class FormEnvíos : Form
    {
        public FormEnvíos()
        {
            InitializeComponent();
        }

        SqlConnection conx = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = Fercejor2021; Integrated Security = True");

        public void llenarTabla()
        {
            string consulta = "select * from Envio";
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
            textDestino.Text = dataGridView1.SelectedCells[2].Value.ToString();
            cboTransporte.SelectedIndex = int.Parse(dataGridView1.SelectedCells[3].Value.ToString()) - 1;
            cboEstado.SelectedIndex = int.Parse(dataGridView1.SelectedCells[4].Value.ToString()) - 1;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conx.Open();
            int codigoPedido = int.Parse(textCodigoPedido.Text);
            int codigoClien = int.Parse(textCodigoCliente.Text);
            String Destino = textDestino.Text;
            int tipTranspor = 0;
            if (cboTransporte.SelectedItem.Equals("Aereo"))
            {
                tipTranspor = 1;
            }
            else if(cboTransporte.SelectedItem.Equals("Terrestre"))
            {
                tipTranspor = 2;
            }
            else
            {
                tipTranspor = 3;
            }
            int tipEstado = 0;
            if (cboEstado.SelectedItem.Equals("Pendiente"))
            {
                tipEstado = 1;
            }
            else
            {
                tipEstado = 2;
            }
            String sql = "INSERT INTO Envio(IdPedido,IdCliente,Destino,IdTipoTransporte,IdTipoEstado) values('" + codigoPedido + "','" + codigoClien + "','" + Destino + "','" + tipTranspor + "','" + tipEstado + "')";
            SqlCommand comando = new SqlCommand(sql, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado correctamente");
            llenarTabla();
            textCodigoPedido.Text = null;
            textCodigoCliente.Text = null;
            textDestino.Text = null;
            cboTransporte.Text = null;
            cboEstado.Text = null;
            conx.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conx.Open();

            String consulta = " delete from Envio where IdPedido=" + textCodigoPedido.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conx);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            llenarTabla();
            textCodigoPedido.Text = null;
            textCodigoCliente.Text = null;
            textDestino.Text = null;
            cboTransporte.Text = null;
            cboEstado.Text = null;

            conx.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conx.Open();
            int tipTranspor ;
            if (cboTransporte.SelectedItem.Equals("Aereo"))
            {
                tipTranspor = 1;
            }
            else if (cboTransporte.SelectedItem.Equals("Terrestre"))
            {
                tipTranspor = 2;
            }
            else
            {
                tipTranspor = 3;
            }
            int tipEstado ;
            if (cboEstado.SelectedItem.Equals("Pendiente"))
            {
                tipEstado = 1;
            }
            else
            {
                tipEstado = 2;
            }
            string consulta = "update Envio set IdPedido=" + textCodigoPedido.Text + " ,IdCliente=" + textCodigoCliente.Text + ", Destino='" + textDestino.Text + "', IdTipoTransporte=" + tipTranspor + ", IdTipoEstado=" + tipEstado + "where IdPedido='" + textCodigoPedido.Text + "'";
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

            String consulta = "select * from Envio where IdPedido= " + textCodigoPedido.Text + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conx);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            conx.Close();
        }

        private void FormEnvíos_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }
    }
}
