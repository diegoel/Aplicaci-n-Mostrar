using Aplicaci_n_Mostrar.DataTransferObjects_DTO_;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Aplicaci_n_Mostrar.DataAccesObjects_DAO_
{
    class ClienteDAO : ConexionDB
    {
        //LEER FILAS DE TABLAS
        SqlDataReader LeerFilas;
        //EJECUTAR INSTRUCCIONES TRANSACT SQL O PROCEDIMIENTOS ALMACENADOS
        SqlCommand Comando = new SqlCommand(); 

        //METODOS CRUD

        //METODO PARA MOSTRAR LOS REGISTROS
        //NO ES BUENO USAR DATATABLE EN POO PORQUE CONSUMEN MUCHA MEMORIA, EN SU LUGAR USAR OBJETOS SERIALISABLES
        public List<ClientesDTO> VerRegistros(string Condicion)
        {
            //ESPECIFICA LA CONEXION
            Comando.Connection = conexion;
            //INSTRUCCION SQL O PROCEDIMIENTO ALMACENADO
            Comando.CommandText = "VerRegistros";
            //TIPO DE COMANDO
            Comando.CommandType = CommandType.StoredProcedure;
            //ENVIA EL VALOR AL PARAMETRO DEL PROCEDIMIENTO
            Comando.Parameters.AddWithValue("@Condicion", Condicion);

            conexion.Open();

            //LEER FILAS 
            LeerFilas = Comando.ExecuteReader();
            //LISTA DE OBJETOS SERIALIZABLES
            List<ClientesDTO> ListaGenerica = new List<ClientesDTO>();
            //CONDICIONAMOS QUE MIENTRAS LEER FILAS SIGA LEYENDO AGREGAMOS FILAS A NUESTRA FILA GENERICA
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new ClientesDTO//CARGAMOS VALORES A LOS ATRIBUTOS DEL OBJETO CLIENTE A TRAVEZ DE SUS PROPIEDADES
                {
                    ID = LeerFilas.GetInt32(0),//OBTENEMOS EL VALOR DE LA COLUMNA COMO UNA CADENA COLOCANDO EL NUMERO DE LA COLUMNA
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Oucpacion = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            conexion.Close();
            return ListaGenerica;
        }
        public void Insert() { }
        public void Edit() { }
        public void Delete() { }

    }
}
