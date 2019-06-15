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
    public partial class FormLibros : Form
    {
        //PATRON SINGLETON (EVITA QUE EL FORMULARIO SE ABRA N CANTIDAD DE VECES
        private FormLibros()
        {
            InitializeComponent();
        }
        private static FormLibros Instancia = null;
        public static FormLibros obtenerInstancia()
        {
            if (Instancia == null) Instancia = new FormLibros();
            return Instancia;
        }
    }
}
