using System.Data.SqlClient;

namespace Aplicaci_n_Mostrar.DataAccesObjects_DAO_
{
    class ConexionDB
    {
        static string Cadena = "Server=DESKTOP-AMOEA6A\\SQLEXPRESS;DataBase=Practica_Patrones;Integrated Security=true";
        protected SqlConnection conexion = new SqlConnection(Cadena);
    }
}
