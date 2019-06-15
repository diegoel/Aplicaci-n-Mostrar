using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicaci_n_Mostrar.User_Interfaces_UI_
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clientestoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form = FormClientes.obtenerInstancia();
            form.MdiParent = this;
            form.Show();
            form.BringToFront();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLibros form = FormLibros.obtenerInstancia();
            form.MdiParent = this;
            form.Show();
            form.BringToFront();
        }
    }
}
