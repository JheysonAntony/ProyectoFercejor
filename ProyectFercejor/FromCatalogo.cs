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
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        SqlConnection conx = new SqlConnection(@"Data Source = JHEYSON\SQLEXPRESS; Initial Catalog = Fercejor2021; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            new FormMenu().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro Cerrar?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            new FormLogin().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReportPedidos_Click(object sender, EventArgs e)
        {

        }

        private void btnReportFactura_Click(object sender, EventArgs e)
        {
            
            ProyectFercejor.CrystalReport1 crpFacturas = new CrystalReport1();
            crpFacturas.SetParameterValue("@IdCliente", textFactCliente.Text);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = crpFacturas;
        }

        private void btnReportFecha_Click(object sender, EventArgs e)
        {
            ProyectFercejor.CrystalReport4 crpFechas = new CrystalReport4();
            crpFechas.SetParameterValue("@Fecha", dtFecha.Value.ToString("yyyy-MM-dd"));
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = crpFechas;

            //Console.WriteLine(dtFecha.Value.ToString("yyyy-MM-dd"));
            //Console.ReadLine();
        }

        private void btnReportPedidos_Click_1(object sender, EventArgs e)
        {
            ProyectFercejor.CrystalReport2 crpPedidos = new CrystalReport2();
            crpPedidos.SetParameterValue("@IdCliente", textPedidosCliente.Text);
            crystalReportViewer1.ReportSource = null;
            crystalReportViewer1.ReportSource = crpPedidos;
        }

        private void btnReportProductos_Click(object sender, EventArgs e)
        {
            ProyectFercejor.CrystalReport3 crpProductos = new CrystalReport3();
            crpProductos.SetParameterValue("@Stock", textBox2.Text);
            crystalReportViewer1.ReportSource = null;   
            crystalReportViewer1.ReportSource = crpProductos;
        }
    }
}
