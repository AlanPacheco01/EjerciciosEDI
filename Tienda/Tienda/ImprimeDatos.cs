using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class ImprimeDatos:TiendaModel
    {
        TiendaService conexion = new TiendaService();
        public ImprimeDatos()
        {
        }

        public ImprimeDatos(long id, string nombre, string aPaterno, string aMaterno, string correo, string password, string tipoEmpleado, string sucursal, string turno) : base(id, nombre, aPaterno, aMaterno, correo, password, tipoEmpleado, sucursal, turno)
        {
        }

       
    }
}
