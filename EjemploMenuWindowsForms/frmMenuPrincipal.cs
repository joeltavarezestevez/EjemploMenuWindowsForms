using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploMenuWindowsForms
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void formulario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir formulario como modal
            Form regclientes = new frmRegistroClientes();
            regclientes.ShowDialog();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir formulario normal
            Form regproductos = new frmRegistroProductos();
            regproductos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Realmente desea salir?", "Aviso", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
