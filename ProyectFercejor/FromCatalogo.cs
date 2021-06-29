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
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

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
    }
}
