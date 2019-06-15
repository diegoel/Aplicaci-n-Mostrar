using Aplicaci_n_Mostrar.DataAccesObjects_DAO_;
using System;
using System.Windows.Forms;

namespace Aplicaci_n_Mostrar.User_Interfaces_UI_
{
    public partial class FormClientes : Form
    {
        //PATRON SINGLETON (EVITA QUE EL FORMULARIO SE ABRA N CANTIDAD DE VECES
        private FormClientes()
        {
            InitializeComponent();
        }
        private static FormClientes Instancia = null;
        public static FormClientes obtenerInstancia()
        {
            if (Instancia == null) Instancia = new FormClientes();
            return Instancia;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            //INVOCAMOS EL METODO DESDE EL LOAD, ENVIAMOS LA CONDICION VACIA PARA QUE MUESTRE TODOS LOS REGISTROS
            VerRegistros("");
        }

        //METODO PRIVADO PARA VER LOS REGISTROS DE LOS CLIENTES CON UN PARAMETRO STRING PARA LA CONDICION DE BUSQUEDA
        private void VerRegistros(string condicion)
        {
            //SE INSTANCIA CLIENTEDAO
            ClienteDAO DAO = new ClienteDAO();
            //OBTENEMOS LA FUENTE DE LOS DATOS EN EL DATAGRIDVIEW
            dataGridView1.DataSource = DAO.VerRegistros(condicion);
        }
        //METODO BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }

        //FILTAR EN TIEMPO DE EJECUCIÓN
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }
    }
}
