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
    public partial class Usuario : Form
    {
        public Usuario(string nombre)
        {
            InitializeComponent();
            lblmensaje.Text = nombre;
        }
    }
}
