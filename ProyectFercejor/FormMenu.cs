using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectFercejor
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public FormMenu(string nombre)
        {
            InitializeComponent();
            lblmensajeAdmin.Text = nombre;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("¿Estas seguro de cerrar sesion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
            new FormLogin().Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form consulta = new FrmCatalogo();
            consulta.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form consulta = new FormProductos();
            consulta.Show();
            this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form consulta = new FormClientes();
            consulta.Show();
            this.Hide();
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            Form consulta = new FormEnvíos();
            consulta.Show();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Form consulta = new FormPedidos();
            consulta.Show();
            this.Hide();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Form consulta = new FormFacturas();
            consulta.Show();
            this.Hide();
        }
    }
}
