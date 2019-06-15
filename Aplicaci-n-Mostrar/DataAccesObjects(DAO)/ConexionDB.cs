using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aplicaci_n_Mostrar.DataAccesObjects_DAO_
{
    class ConexionDB
    {
        static string Cadena = "Server=DESKTOP-AMOEA6A\\SQLEXPRESS;DataBase=Practica_Patrones;Integrated Security=true";
        protected SqlConnection conexion = new SqlConnection(Cadena);
    }
}
