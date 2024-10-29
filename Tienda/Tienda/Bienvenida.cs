using System;
using System.Text.RegularExpressions;

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
        public bool ValText(string ingresaTexto)
        {
            //Patrón para validad que solo se acepte texto de parte del usuario
            string regexTexto = @"^([^0-9]+)*$";
            Match ingresoTrue = Regex.Match(ingresaTexto, regexTexto);
            bool IsValidName = ingresoTrue.Success;
            bool IsValidTexto = string.IsNullOrWhiteSpace(ingresaTexto);
            bool comparativo = IsValidName && !IsValidTexto;
            return comparativo;
        }
        public bool ValCorreo(string ingresaTexto)
        {
            //Patrón para validad que solo se acepte texto de parte del usuario
            string regexCorreo = @"^[a-zA-Z0-9._-]+@[a-zA-Z.-]+\.[a-zA-Z]{2,}$";
            Match ingresoTrue = Regex.Match(ingresaTexto, regexCorreo);
            bool IsValidEmail = ingresoTrue.Success;
            bool IsEmptyEmail = string.IsNullOrWhiteSpace(ingresaTexto);
            bool comparativo = IsValidEmail && !IsEmptyEmail;
            return comparativo;
        }
        public bool ValPassword(string ingresaTexto)
        {

            //Patrón de Regex que sigue las siguientes reglas:
            //Contar con al menos 1 Mayúscula
            //Contar con al menos 1 Minúscula
            //Contar con al menos 1 Dígito
            //Contiene al menos 1 caracter especial
            //Longitud mínima de 8 caracteres y máximo 12 

            string regexPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@.-_$%&#!¡¿?+*])[A-Za-z\d@.-_$%&#!¡¿?+*]{8,12}$";
            Match ingresoTrue = Regex.Match(ingresaTexto, regexPassword);
            bool IsValidPassword = ingresoTrue.Success;
            bool IsEmptyPassword = string.IsNullOrWhiteSpace(ingresaTexto);
            bool comparativo = IsValidPassword && !IsEmptyPassword;
            return comparativo;
        }
        public bool ValSeleccion(string input)
        {
            string patterSeleccion = @"^[0-9]{1,1}$";
            Match RegexSel = Regex.Match(input, patterSeleccion);
            bool IsValidSel = RegexSel.Success;
            bool IsEmptySel = string.IsNullOrEmpty(input);
            bool comparativo = IsValidSel && !IsEmptySel;
            return comparativo;
        }

    }
}
