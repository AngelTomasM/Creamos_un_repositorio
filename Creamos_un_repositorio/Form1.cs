using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creamos_un_repositorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (txtEntrada.Text == "")
                lblResultado.Text = "Hola";
            else
                lblResultado.Text = txtEntrada.Text;
        }
    }
}
