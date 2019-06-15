using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicaci_n_Mostrar.DataTransferObjects_DTO_
{
    class ClientesDTO
    {
        //ATRIBUTOS
        int _ID;
        string _Nombre;
        string _Apellido;
        string _Direccion;
        string _Ciudad;
        string _Email;
        string _Telefono;
        string _Oucpacion;

        public int ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Oucpacion { get => _Oucpacion; set => _Oucpacion = value; }
        //PROPIEDADES GET AND SET
    }
}
