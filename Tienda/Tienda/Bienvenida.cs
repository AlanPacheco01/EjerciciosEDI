using System;


namespace Tienda
{
    class Bienvenida
    {
        public void MensajeBienvenida()
        {
            string pantallainicio = "Bienvenido al sistema Z-001, este programa le permitirá" +
                "realizar operaciones como: " +
                "\n-.Crear a un nuevo empleado en la base de datos" +
                "\n-.Actualizar los datos de un empleado en la base de datos" +
                "\n-.Eliminar la información de un usuario en la base de datos" +
                "\n-.Buscar a un empleado por medio de sus apellidos o por medio de un correo" +
                "\n-.Mostrar a todos los usuarios existentes en la base de datos" +
                "\n-.Generar un reporte con los datos del usuario que realizó la última actualización al sistema";
            Console.WriteLine($"\n\n{pantallainicio}\n");
        }
        public void DibujoSup()
        {
            for (var i = 0; i < Console.WindowWidth; i++)
            {
                var ws = Console.WindowWidth / 10;
                if (i < (ws))
                {
                    Console.Write("-");
                }
                else if (i > (ws) && i < (2* ws))
                {
                    Console.Write("/¯¯¯¯¯\\");
                }
                else
                {
                    while (i<(3*ws))
                    {
                        Console.Write("-" + "-");
                        break;
                    }
                }
            }
        }
        public void DibujoInf()
        {
            for (var i = 0; i < Console.WindowWidth; i++)
            {
                var ws = Console.WindowWidth / 10;
                if (i < (ws))
                {
                    Console.Write("-");
                }
                else if (i > (ws) && i < (2 * ws))
                {
                    Console.Write("\\_____/");
                }
                else
                {
                    while (i < (3 * ws))
                    {
                        Console.Write("-" + "-");
                        break;
                    }
                }
            }
        }
        public void Contexto()
        {
            string pantallaLogin = "Ingrese mediante su correo y su contraseña";
            Console.WriteLine($"\n\n{pantallaLogin}");
        }
        public void OpcionesPantallaInicio()
        {
            string opcionesPantallaInicio = "\n\nEl siguiente programa le permitirá interactuar con la información de un usuario, seleccione: " +
                    "\n1.Crear un nuevo usuario" +
                    "\n2.Mostrar a los usuarios existentes" +
                    "\n3.Buscar un usuario" +
                    "\n4.Actualizar datos" +
                    "\n5.Eliminar a un usuario" +
                    "\nO presione 0 para salir del programa" +
                    "\n";

            Console.WriteLine(opcionesPantallaInicio);
        }
        public void Espacios()
        {
            Console.ReadKey();
            Console.Clear();
        }
        public void ContrasenaErronea()
        {
            DibujoSup();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\nContraseña erronea\n");
            Console.ForegroundColor = ConsoleColor.White;
            DibujoInf();
        }
        public void Agradecimiento()
        {
            DibujoSup();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n\nGracias por usar nuestros servicios\n");
            Console.ForegroundColor = ConsoleColor.White;
            DibujoInf();
        }
        public void AlertaOpcionInvalida()
        {
            DibujoSup();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\nHa seleccionado una opción inválida\n");
            Console.ForegroundColor = ConsoleColor.White;
            DibujoInf();
        }
        public void AlertaDatosErroneos()
        {
            DibujoSup();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\nUsuario o contraseña erroneo\n");
            Console.ForegroundColor = ConsoleColor.White;
            DibujoInf();
        }
    }
}
