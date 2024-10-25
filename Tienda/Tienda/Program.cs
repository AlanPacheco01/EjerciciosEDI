
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aplicación diseñada para practicar
            //--principios SOLID
            //--POO
            //--el uso de VS 2019/2022 y el framework .NET
            //--operaciones Create, Read, Update, Delete básicas

            Bienvenida mensajes = new Bienvenida();
            TiendaController tienda = new TiendaController();
            mensajes.DibujoSup();
            tienda.Interaccion();
        }
    }
}
