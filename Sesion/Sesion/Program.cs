using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Metodos prueba = new Metodos();

            prueba.Lectura();
            prueba.Actualizacion();            
            prueba.Escritura();

        }


    }
}