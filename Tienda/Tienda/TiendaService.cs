using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;



namespace Tienda
{
    class TiendaService : Bienvenida
    {

        /*
         Métodos para:
        CREATE - crear un nuevo usuario y contraseña -- Nivel de acceso gerencial 
        READ - iniciar sesión / mostrar empleado -- Nivel general
        UPDATE - actualizar un usuario -- Nivel general(password/correo)/gerencial (tipo empleado/sucursal/turno)
        DELETE -eliminar un usuario -- Nivel gerencial
         */
        TiendaRepository<List<string>> tiendaRepository = new TiendaRepository<List<string>>();
        TiendaRepository<List<string>> registroCambios = new TiendaRepository<List<string>>();
        TiendaModel user = new TiendaModel();


        //Método para crear un nuevo usuario 
        //En todos los casos se incorpora un ciclo do-while que finaliza el programa 
        //cuando los requisitos para el ingreso de datos se han cumplido
        //Se incorpora la validación de datos mediante expresiones regulares
        //Se incorporan enums para listar campos como el turno, la sucursal y el tipo de empleado


        //Solicita el nombre del empleado
        public void IngresaNombre()
        {
            //Inicializa la variable bool para controlar el ciclo do-while
            bool fin;
            do
            {
                //Solicita el ingreso de datos por parte del usuario
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingresa el nombre del empleado");

                string ingresaTexto = Console.ReadLine();

                if (ValText(ingresaTexto))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    //Guarda el nombre del usuario con el método set, se recupera posteriormente
                    user.SetNombre(ingresaTexto);
                    Console.WriteLine($"Se ha registrado a {ingresaTexto} con éxito");
                    fin = false;
                }
                else
                {
                    //Le advierte al usuario que los datos nos son válidos
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;
                }
            } while (fin);
        }
        //Solicita el apellido paterno del empleado
        public void IngresaApaterno()
        {
            bool fin;
            do
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingresa el apellido paterno del empleado");
                string ingresaTexto = Console.ReadLine();

                if (ValText(ingresaTexto))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    user.SetApaterno(ingresaTexto);
                    Console.WriteLine($"Se ha registrado {ingresaTexto} con éxito");
                    fin = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;
                }
            } while (fin);

        }
        //Solicita el apellido materno del empleado
        public void IngresaAmaterno()
        {
            bool fin;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingresa el apellido materno del empleado");
                string ingresaTexto = Console.ReadLine();

                if (ValText(ingresaTexto))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    user.SetAmaterno(ingresaTexto);
                    Console.WriteLine($"Se ha registrado {ingresaTexto} con éxito");
                    fin = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;
                }
            } while (fin);
        }
        //Solicita el correo del empleado
        public void IngresaCorreo()
        {
            bool fin;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingresa el correo del empleado");
                string ingresaTexto = Console.ReadLine();

                if (ValCorreo(ingresaTexto))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    user.SetCorreo(ingresaTexto);
                    Console.WriteLine($"Se ha registrado {ingresaTexto} con éxito");
                    fin = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;
                }
            } while (fin);
        }
        //Solicita la creación de un password para el empleado
        public void IngresaPassword()
        {
            bool fin;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingresa el password del empleado");
                string ingresaTexto = Console.ReadLine();

                if (ValPassword(ingresaTexto))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    user.SetPassword(ingresaTexto);
                    Console.WriteLine($"Se ha registrado {ingresaTexto} con éxito");
                    fin = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;
                }
            } while (fin);
        }
        //Solicita el tipo de empleado que se va a registrar
        public void IngresaTipoEmpleado()
        {
            bool seleccionEmpleado;
            do
            {
                //Muestra al usuario la funcionalidad de esta sección
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese el tipo de empleado: " +
                        $"\n1.{TipoEmpleado.asesor}" +
                        $"\n2.{TipoEmpleado.cajero}" +
                        $"\n3.{TipoEmpleado.demostrador}" +
                        $"\n4.{TipoEmpleado.gerente}" +
                        $"\n5.{TipoEmpleado.outsourcing}" +
                        $"\n6.{TipoEmpleado.vendedor}");

                //Valida que el usuario solo ingrese numeros
                Console.WriteLine("\n\nDigite su elección: ");
                string input = Console.ReadLine();

                seleccionEmpleado = true;

                if (ValSeleccion(input))
                {
                    //Si el dato es válido se convierte de string a input y se continúa con la selección
                    int seleccionTipoEmpleado = Convert.ToInt32(input);

                    //Se emplea switch case para darle que el usuario pueda registrar información en función de diferentes casos
                    //Si el registro es exitoso se imprime un mensaje en la consola en letras verdes
                    switch (seleccionTipoEmpleado)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.asesor}");
                            user.SetTipoEmpleado($"{TipoEmpleado.asesor}");
                            Console.ForegroundColor = ConsoleColor.White;
                            seleccionEmpleado = false;
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.cajero}");
                            user.SetTipoEmpleado($"{TipoEmpleado.cajero}");
                            Console.ForegroundColor = ConsoleColor.White;
                            seleccionEmpleado = false;
                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.demostrador}");
                            user.SetTipoEmpleado($"{TipoEmpleado.demostrador}");
                            Console.ForegroundColor = ConsoleColor.White;
                            seleccionEmpleado = false;
                            break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.gerente}");
                            user.SetTipoEmpleado($"{TipoEmpleado.gerente}");
                            Console.ForegroundColor = ConsoleColor.White;
                            seleccionEmpleado = false;
                            break;

                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.outsourcing}");
                            user.SetTipoEmpleado($"{TipoEmpleado.outsourcing}");
                            Console.ForegroundColor = ConsoleColor.White;
                            seleccionEmpleado = false;
                            break;

                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.vendedor}");
                            user.SetTipoEmpleado($"{TipoEmpleado.vendedor}");
                            Console.ForegroundColor = ConsoleColor.White;
                            seleccionEmpleado = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Ha seleccionado una opción que no es válida");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
                else
                {
                    //Si los datos son erroneos se lanza una alerta que menciona que los datos son inválidos
                    //También lanza una excepción de datos inválidos
                    AlertaOpcionInvalida();
                    //throw new InvalidDataException();
                }
            } while (seleccionEmpleado);

        }
        //Solicita la sucursal a la que va a ser asignado el empleado 
        public void IngresaSucursal()
        {
            bool cicloSucursal;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese la sucursal a la que pertenece el empleado: " +
                    $"\n1.{Sucursales.Azcapotzalco}" +
                    $"\n2.{Sucursales.Copilco}" +
                    $"\n3.{Sucursales.Coyoacán}" +
                    $"\n4.{Sucursales.Perisur}" +
                    $"\n5.{Sucursales.Potrero}" +
                    $"\n6.{Sucursales.Taxqueña}");

                Console.WriteLine("\n\nDigite su elección: ");
                string inputSucursal = Console.ReadLine();
                cicloSucursal = true;

                if (ValSeleccion(inputSucursal))
                {
                    int seleccionSucursal = Convert.ToInt32(inputSucursal);
                    switch (seleccionSucursal)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Empleado asignado a {Sucursales.Azcapotzalco}");
                            user.SetSucursal($"{Sucursales.Azcapotzalco}");
                            Console.ForegroundColor = ConsoleColor.White;
                            cicloSucursal = false;
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Empleado asignado a {Sucursales.Copilco}");
                            user.SetSucursal($"{Sucursales.Copilco}");
                            Console.ForegroundColor = ConsoleColor.White;
                            cicloSucursal = false;
                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Empleado asignado a {Sucursales.Coyoacán}");
                            user.SetSucursal($"{Sucursales.Coyoacán}");
                            Console.ForegroundColor = ConsoleColor.White;
                            cicloSucursal = false;
                            break;

                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Empleado asignado a {Sucursales.Perisur}");
                            user.SetSucursal($"{Sucursales.Perisur}");
                            Console.ForegroundColor = ConsoleColor.White;
                            cicloSucursal = false;
                            break;

                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Empleado asignado a {Sucursales.Potrero}");
                            user.SetSucursal($"{Sucursales.Potrero}");
                            Console.ForegroundColor = ConsoleColor.White;
                            cicloSucursal = false;
                            break;

                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Empleado asignado a {Sucursales.Taxqueña}");
                            user.SetSucursal($"{Sucursales.Taxqueña}");
                            Console.ForegroundColor = ConsoleColor.White;
                            cicloSucursal = false;
                            break;

                        default:
                            AlertaOpcionInvalida();
                            break;
                    }
                }
                else
                {
                    AlertaOpcionInvalida();
                    //throw new InvalidDataException();
                }

            } while (cicloSucursal);
        }
        //Solicita el turno al que va a ser designado el empleado
        public void IngresaTurno()
        {
            bool seleccionTurno;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese la sucursal a la que pertenece el empleado: " +
                    $"\n1.{Turno.Matutino}" +
                    $"\n2.{Turno.Vespertino}" +
                    $"\n3.{Turno.Nocturno}");

                Console.WriteLine("\n\nDigite su elección: ");
                string inputTurno = Console.ReadLine();

                seleccionTurno = true;

                if (ValSeleccion(inputTurno))
                {
                    int selTurno = Convert.ToInt32(inputTurno);
                    switch (selTurno)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Empleado asignado a {Turno.Matutino}");
                            user.SetTurno($"{Turno.Matutino}");
                            Console.ForegroundColor = ConsoleColor.White;
                            seleccionTurno = false;
                            break;

                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Empleado asignado a {Turno.Vespertino}");
                            user.SetTurno($"{Turno.Nocturno}");
                            Console.ForegroundColor = ConsoleColor.White;
                            seleccionTurno = false;
                            break;

                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Empleado asignado a {Turno.Nocturno}");
                            user.SetTurno($"{Turno.Nocturno}");
                            Console.ForegroundColor = ConsoleColor.White;
                            seleccionTurno = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Ha seleccionado una opción que no es válida");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
                else
                {
                    AlertaOpcionInvalida();
                    //throw new InvalidDataException();
                }
            } while (seleccionTurno);

        }
        //Genera un array de datos para similar una base de datos,
        //para realizar operaciones CRUD básicas
        public void DatosPrueba()
        {
            var pruebaUno = new List<string> { "Nombre(s): " + "Juan Pablo", "Apellido Paterno: " + "Ortega", "Apellido Materno: " + "Gazette", "Correo: " + "portega@gmail.com", "Password: " + "Sistemas12@", "Tipo de empleado: " + "asesor", "Sucursal: " + "coyoacán", "Turno: " + "Matutino" };
            var pruebaDos = new List<string> { "Nombre(s): " + "Carolina Andrea", "Apellido Paterno: " + "Herrera", "Apellido Materno: " + "López", "Correo: " + "cherrera@gmail.com", "Password: " + "Pulparindo12@", "Tipo de empleado: " + "vendedor", "Sucursal: " + "taxqueña", "Turno: " + "Vespertino" };
            var pruebaTres = new List<string> { "Nombre(s): " + "Sandra", "Apellido Paterno: " + "Sánchez", "Apellido Materno: " + "Almazán", "Correo: " + "salmazan@gmail.com", "Password: " + "Camila78@", "Tipo de empleado: " + "outsourcing", "Sucursal: " + "perisur", "Turno: " + "Nocturno" };
            var pruebaCuatro = new List<string> { "Nombre(s): " + "Carolina Fernanda", "Apellido Paterno: " + "Herrera", "Apellido Materno: " + "Castro", "Correo: " + "castro@gmail.com", "Password: " + "Juan1235@", "Tipo de empleado: " + "vendedor", "Sucursal: " + "taxqueña", "Turno: " + "Vespertino" };
            var pruebaCinco = new List<string> { "Nombre(s): " + "Sandra María", "Apellido Paterno: " + "Cuevas", "Apellido Materno: " + "Castro", "Correo: " + "scuevasa@gmail.com", "Password: " + "CorazonMelon@8", "Tipo de empleado: " + "vendedor", "Sucursal: " + "taxqueña", "Turno: " + "Vespertino" };
            var pruebaSeis = new List<string> { "Nombre(s): " + "Ana Karen", "Apellido Paterno: " + "Ortega", "Apellido Materno: " + "Sántos", "Correo: " + "santos@gmail.com", "Password: " + "Ventas456@", "Tipo de empleado: " + "asesor", "Sucursal: " + "coyoacán", "Turno: " + "Matutino" };
            var pruebaSiete = new List<string> { "Nombre(s): " + "Alan Alberto", "Apellido Paterno: " + "Pacheco", "Apellido Materno: " + "Ramírez", "Correo: " + "iq.alpa95@gmail.com", "Password: " + "Soporte.2029@", "Tipo de empleado: " + "Desarrollo", "Sucursal: " + "Santa Fé", "Turno: " + "Matutino" };
            tiendaRepository.Add(pruebaUno);
            tiendaRepository.Add(pruebaDos);
            tiendaRepository.Add(pruebaTres);
            tiendaRepository.Add(pruebaCuatro);
            tiendaRepository.Add(pruebaCinco);
            tiendaRepository.Add(pruebaSeis);
            tiendaRepository.Add(pruebaSiete);
        }
        //Añade los datos capturados a un array que forma parte de una colección genérica
        //de objetos iterables
        public void GuardarDatos()
        {
            string addName = user.GetNombre();
            string addFlname = user.GetApaterno();
            string addSlname = user.GetAmaterno();
            string addCorreo = user.GetCorreo();
            string addPassword = user.GetPassword();
            string addTipoEmpleado = user.GetTipoEmpleado();
            string addSucursal = user.GetSucursal();
            string addTurno = user.GetTurno();
            //La lista de datos presenta la siguiente forma, lo que permite que al iterar por medio de un foreach
            //se pueda mostrar la naturaleza de cada dato
            var temp = new List<string> { "Nombre(s): " + addName, "Apellido Paterno: " + addFlname, "Apellido Materno: " + addSlname, "Correo: " + addCorreo, "Password: " + addPassword, "Tipo de empleado: " + addTipoEmpleado, "Sucursal: " + addSucursal, "Turno: " + addTurno };
            //Los datos se almacenan en tiendaRepository 
            tiendaRepository.Add(temp);
        }
        //Método para mostrar los datos que se almacenan en el array o aquellos que ya se crearon en el 
        //método Datos prueba
        public void MostrarDatos()
        {
            //Itera sobre el array usuarios, mostrando a los sub elementos "empleados" los cuales 
            //también son una colección de datos
            foreach (var empleado in tiendaRepository.usuarios)
            {
                //Genera un separador echo de guiones para separar cada dato
                string separador = string.Concat(Enumerable.Repeat("-", Console.WindowWidth));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n{separador}\n");

                //Itera sobre los datos que conforman al arreglo empleados
                //muestra la información de cada empleado
                foreach (var datos in empleado)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{datos}");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n{separador}\n");
            }
        }

        //Solicita al usuario los datos del empleado que va a buscar, en caso que exista una coincidencia positiva
        //retrona un valor true, de lo contrario es false
        public bool BuscarApellido()
        {
            //Ingresa los datos del usuario
            Console.WriteLine("Ingrese el apellido paterno del empleado");
            string aPaterno = Console.ReadLine();
            string busquedaPaterno = "Apellido Paterno: " + aPaterno;

            Console.WriteLine("Ingrese el apellido Materno del empleado");
            string aMaterno = Console.ReadLine();
            string busquedaMaterno = "Apellido Materno: " + aMaterno;

            //Patrón para validad que solo se acepte texto de parte del usuario
            bool evPaterno = ValText(aPaterno);
            bool evMaterno = ValText(aMaterno);

            //encapsula a la colección empleados en una variable más compacta
            var coleccionEmpleados = tiendaRepository.usuarios;
            bool bPaterno;
            bool bMaterno;
            int j = 0;
            //IsValidPaterno && IsValidMaterno && !IsEmptyPaterno && !IsEmptyMaterno
            if (evPaterno && evMaterno)
            {
                foreach (var empleado in coleccionEmpleados)
                {
                    bPaterno = empleado.Contains(busquedaPaterno);
                    bMaterno = empleado.Contains(busquedaMaterno);
                    if (bPaterno && bMaterno)
                    {
                        foreach (var dato in empleado)
                        {
                            Console.WriteLine($"\n{dato}\n");
                        }
                        Console.WriteLine($"\nEl ID del empleado es: {tiendaRepository.usuarios.IndexOf(empleado)}\n");
                        return true;
                    }
                    else if (!bPaterno && !bMaterno)
                    {
                        j++;

                        if (j == coleccionEmpleados.Count)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("No se ha encontrado al empleado, verifique los datos de ingreso");
                            Console.ForegroundColor = ConsoleColor.White;
                            return false;
                        }
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        //Busca los datos de los empleados en función de los apellidos del empleado y 
        //su correo electrónico
        public void BuscarUsuario()
        {
            //Le informa al usuario la utilidad de esta sección
            Console.WriteLine("\nSección dedicada a buscar datos de un empleado, seleccione " +
                "\n1.Búsqueda por apellidos del empleado" +
                "\n2.Búsqueda por correo electrónico");

            //Restringe el ingreso de datos para evitar el ingreso de datos inválidos
            string input = Console.ReadLine();

            if (ValSeleccion(input))
            {
                int seleccion = Convert.ToInt32(input);

                switch (seleccion)
                {
                    case 1:
                    Inicio:

                        //Solicita al usuario los datos del empleado que desea buscar
                        Console.WriteLine("Ingrese el apellido paterno del empleado");
                        string aPaterno = Console.ReadLine();
                        string busquedaPaterno = "Apellido Paterno: " + aPaterno;
                        bool aPaternoEmpty = string.IsNullOrEmpty(aPaterno);
                        Console.WriteLine("Ingrese el apellido Materno del empleado");
                        string aMaterno = Console.ReadLine();
                        string busquedaMaterno = "Apellido Materno: " + aMaterno;

                        //Valores booleanos que se emplearan durante la iteración en la 
                        //colección tienda repository
                        bool aMaternoEmpty = string.IsNullOrEmpty(aMaterno);
                        bool bPaterno;
                        bool bMaterno;
                        int j = 0;
                        if (!aPaternoEmpty || !aMaternoEmpty)
                        {
                            //Itera sobre la colección que tiene los datos de los usuarios
                            foreach (var empleado in tiendaRepository.usuarios)
                            {
                                //Se declara un boleano que retorna true si los datos ingresados coinciden con 
                                //los que se tienen en la colección usuarios
                                bPaterno = empleado.Contains(busquedaPaterno);
                                bMaterno = empleado.Contains(busquedaMaterno);

                                if (bPaterno && bMaterno)
                                {
                                    //Si la coincidencia es positiva se imprime en pantalla la información 
                                    //del empleado y se termina el ciclo
                                    foreach (var dato in empleado)
                                    {
                                        Console.WriteLine(dato);
                                    }
                                    Console.WriteLine($"El ID del empleado es: {tiendaRepository.usuarios.IndexOf(empleado)}");
                                    break;
                                }
                                //Como el ciclo foreach recorre cada elemento de la colección usuarios
                                //se usa al contador j para registrar las veces que la búsqueda de los 
                                //datos ha sido negativa
                                else if (!bPaterno && !bMaterno)
                                {
                                    j++;

                                    //Si este contador llega a ser equivalente a la longitud de la colección 
                                    //usuarios se da por terminado el ciclo y se imprime un mensaje de un 
                                    //resultado negativo
                                    if (j == tiendaRepository.usuarios.Count)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("No se ha encontrado al empleado, verifique los datos de ingreso");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    }
                                    else
                                    {
                                        //Mientras el contador sea menor a la cantidad de elementos que componen a
                                        //la colección usuarios el ciclo continua
                                        continue;
                                    }
                                }
                            }
                        }
                        else
                        {
                            //Si los campos se dejan vacíos se dispara la alerta
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Estos campos no se pueden dejar vacíos");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Inicio;
                        }
                        break;
                    case 2:
                    InicioCorreo:
                        Console.WriteLine("Ingrese el correo del empleado: ");
                        string inputCorreo = Console.ReadLine();
                        string busquedaCorreo = "Correo: " + inputCorreo;
                        string regexCorreo = @"[\.a-zA-Z0-9.-_]+[@a-zA-Z]+[\.a-z]";
                        Match correoTrue = Regex.Match(inputCorreo, regexCorreo);
                        bool correoEmpty = string.IsNullOrEmpty(inputCorreo);
                        bool IsValidCorreo = correoTrue.Success;
                        bool bCorreo;
                        int k = 0;

                        if (!correoEmpty && IsValidCorreo)
                        {
                            foreach (var empleado in tiendaRepository.usuarios)
                            {
                                bCorreo = empleado.Contains(busquedaCorreo);

                                if (bCorreo)
                                {
                                    foreach (var dato in empleado)
                                    {
                                        Console.WriteLine(dato);
                                    }
                                    break;
                                }
                                else if (!bCorreo)
                                {
                                    k++;
                                    if (k == tiendaRepository.usuarios.Count)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("No se ha encontrado al usuario, verifique los datos que ingresa");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Estos campos no se pueden dejar vacíos");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto InicioCorreo;
                        }
                        break;
                    default:
                        AlertaOpcionInvalida();
                        break;
                }
            }
            else
            {
                AlertaOpcionInvalida();
                //throw new InvalidDataException();
            }
        }
        //Método para actualizar los datos de un empleado, toma como parámetros los apellidos del empelado
        public void ActualizarDatos()
        {
            //Se usa el método buscar usuario para esta operación, si el resultado es verdadero se procede
            //Con la operación, de contrario se cancela
            if (BuscarApellido())
            {

                //Solicita la confirmación del Id para que el método foreach pueda iterar sobre la colección de empleados                
                Console.WriteLine("Confirme el ID del empleado para continuar con la operación: ");
                string inputID = Console.ReadLine();

                //Cuando se confirma el Id del empleado se procede con la actualización de los datos
                if (ValSeleccion(inputID))
                {
                    //Convierte la opción ingresada a un int para acceder a las opciones
                    int confirmacionId = Convert.ToInt32(inputID);

                    //Le informa al usuario las opciones que están disponibles en la aplicación
                    Console.WriteLine("Seleccione la operación que desea realizar:" +
                        "\n1.Actualizar Nombre(s)" +
                        "\n2.Actualizar Apellido Paterno" +
                        "\n3.Actualizar Apellido MAterno" +
                        "\n4.Actualizar Correo" +
                        "\n5.Actualizar Password" +
                        "\n6.Actualizar Tipo Empleado" +
                        "\n7.Actualizar Sucursal" +
                        "\n8.Actualizar Turno");

                    //valida que la selección sea un entero, con un solo dígito y se encuentre dentro de las opciones 
                    //mediante un switch-case
                    string inputSeleccion = Console.ReadLine();

                    //Si es válido se procede con las operaciones
                    if (ValSeleccion(inputSeleccion))
                    {
                        int seleccion = Convert.ToInt32(inputSeleccion);

                        //almacena las opciones disponibles, se activa en función de la elección del empleado
                        switch (seleccion)
                        {
                            //Actualiza el nombre del usuario
                            case 1:

                                //Solicita la corrección de nombre de empleado al usuario
                                Console.WriteLine("Ingrese el nuevo nombre del empleado: ");
                                string inputCorreccionNombre = Console.ReadLine();

                                //Si los datos son válidos y no se tienen campos vacío se procede con la operación
                                if (ValText(inputCorreccionNombre))
                                {
                                    //si el patrón es válido se concatena con el parámetro nombre, de modo que sirva como
                                    //referencia para iterar sobre el array
                                    string correccionNombre = "Nombre(s): " + inputCorreccionNombre;

                                    //Itera sobre la colección usuarios
                                    foreach (var empleados in tiendaRepository.usuarios)
                                    {
                                        //Si el Id es confirmado se selecciona el index que esta información ocupa en la colección 
                                        //empleados
                                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                                        {
                                            //Al campo nombre le corresponde la posición 0 dentro de la colección, 
                                            //cuando se confirma la información, se sobreescribe la información anterior
                                            //con la que ha ingresado el usuario
                                            empleados[0] = correccionNombre;
                                            Console.WriteLine($"Se ha actualizado el nombre del empleado con el id: {confirmacionId}" +
                                                $"\nEl nuevo nombre  es: {empleados[0]}");
                                        }
                                    }
                                }
                                else
                                {
                                    AlertaOpcionInvalida();
                                    //throw new InvalidDataException();
                                }
                                break;
                            case 2:

                                //Solicita la corrección de nombre de empleado al usuario
                                Console.WriteLine("Ingrese el nuevo apellido paterno del empleado: ");
                                string inputCorreccionApaterno = Console.ReadLine();

                                if (ValText(inputCorreccionApaterno))
                                {
                                    string correccionApaterno = "Apellido Paterno: " + inputCorreccionApaterno;
                                    foreach (var empleados in tiendaRepository.usuarios)
                                    {
                                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                                        {
                                            empleados[1] = correccionApaterno;
                                            Console.WriteLine(empleados[1]);
                                        }
                                    }
                                }
                                else
                                {
                                    AlertaOpcionInvalida();
                                    //throw new InvalidDataException();
                                }
                                break;
                            case 3:

                                //Solicita al usuario la corrección del apellido materno
                                Console.WriteLine("Ingrese el nuevo apellido materno del empleado: ");
                                string inputCorreccionAmaterno = Console.ReadLine();

                                if (ValText(inputCorreccionAmaterno))
                                {
                                    string correccionAmaterno = "Apellido Paterno: " + inputCorreccionAmaterno;

                                    foreach (var empleados in tiendaRepository.usuarios)
                                    {
                                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                                        {
                                            empleados[2] = correccionAmaterno;
                                            Console.WriteLine(empleados[2]);
                                        }
                                    }
                                }
                                else
                                {
                                    AlertaOpcionInvalida();
                                    //throw new InvalidDataException();
                                }
                                break;
                            case 4:

                                //Solicita al usuario el ingreso de un correo
                                Console.WriteLine("Ingrese el nuevo correo del empleado: ");
                                string inputCorreccionCorreo = Console.ReadLine();

                                if (ValCorreo(inputCorreccionCorreo))
                                {
                                    string correccionCorreo = "Correo: " + inputCorreccionCorreo;
                                    foreach (var empleados in tiendaRepository.usuarios)
                                    {
                                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                                        {
                                            empleados[3] = correccionCorreo;
                                            Console.WriteLine(empleados[3]);
                                        }
                                    }
                                }
                                else
                                {
                                    AlertaOpcionInvalida();
                                    // throw new InvalidDataException();
                                }
                                break;
                            case 5:

                                //Solicita al usuario el nuevo password
                                Console.WriteLine("Ingrese el nuevo password del empleado: ");
                                string inputCorreccionPassword = Console.ReadLine();

                                if (ValPassword(inputCorreccionPassword))
                                {
                                    string correccionPassword = "Password: " + inputCorreccionPassword;

                                    foreach (var empleados in tiendaRepository.usuarios)
                                    {
                                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                                        {
                                            empleados[4] = correccionPassword;
                                            Console.WriteLine(empleados[4]);
                                        }
                                    }
                                }
                                else
                                {                                    
                                    AlertaOpcionInvalida();
                                    //throw new InvalidDataException();
                                }
                                break;
                            case 6:

                                //Le informa al usuario las opciones disponibles para actualizar el tipo de empleado
                                Console.WriteLine("Sección para actualizar los datos del empleado," +
                                    "recuerde que los roles disponibles son:" +
                                    "\nCajero" +
                                    "\nGerente" +
                                    "\nOutsourcing" +
                                    "\nDemostrador" +
                                    "\nVendedor" +
                                    "\nAsesor");

                                //Recibe los datos de parte del usuario
                                Console.WriteLine("Ingrese el nuevo rol empleado: ");
                                string inputCorreccionTipoEmpleado = Console.ReadLine();

                                if (ValText(inputCorreccionTipoEmpleado))
                                {
                                    string correccionTipoEmpleado = "Tipo de empleado: " + inputCorreccionTipoEmpleado;
                                    foreach (var empleados in tiendaRepository.usuarios)
                                    {
                                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                                        {
                                            empleados[5] = correccionTipoEmpleado;
                                            Console.WriteLine(empleados[5]);
                                        }
                                    }
                                }
                                else
                                {
                                    AlertaOpcionInvalida();
                                    //throw new InvalidDataException();
                                }


                                break;
                            case 7:

                                //Le informa al usuario las opciones disponibles para actualizar el tipo de empleado
                                Console.WriteLine("Sección para actualizar la sucursal del empleado," +
                                    "recuerde que los roles disponibles son:" +
                                    "\nCoyoacán" +
                                    "\nCopilco" +
                                    "\nTaxqueña" +
                                    "\nPerisur" +
                                    "\nPotrero" +
                                    "\nAzcapotzalco");

                                //Recibe la información del usuario 
                                Console.WriteLine("Ingrese la nueva sucursal a la que será asignado el empelado: ");
                                string inputCorreccionSucursal = Console.ReadLine();
                                string correccionSucursal = "Sucursal: " + inputCorreccionSucursal;

                                if (ValText(inputCorreccionSucursal))
                                {
                                    foreach (var empleados in tiendaRepository.usuarios)
                                    {
                                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                                        {
                                            empleados[6] = correccionSucursal;
                                            Console.WriteLine(empleados[6]);
                                        }
                                    }
                                }
                                else
                                {
                                    AlertaOpcionInvalida();
                                    //throw new InvalidDataException();
                                }

                                break;
                            case 8:

                                //Le informa al usuario las opciones disponibles para actualizar el tipo de empleado
                                Console.WriteLine("Sección para actualizar el turno del empleado," +
                                    "recuerde que los roles disponibles son:" +
                                    "\nMatutino" +
                                    "\nVespertino" +
                                    "\nNocturno");

                                //Recive la información del usuario
                                Console.WriteLine("Ingrese el nuevo turno del empelado: ");
                                string inputCorreccionTurno = Console.ReadLine();
                                string correccionTurno = "Turno: " + inputCorreccionTurno;

                                if (ValText(inputCorreccionTurno))
                                {
                                    foreach (var empleados in tiendaRepository.usuarios)
                                    {
                                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                                        {
                                            empleados[7] = correccionTurno;
                                            Console.WriteLine(empleados[7]);
                                        }
                                    }
                                }
                                else
                                {
                                    throw new InvalidDataException();
                                }

                                break;
                            default:
                                AlertaOpcionInvalida();
                                break;
                        }
                    }
                    else
                    {
                        AlertaOpcionInvalida();
                        //throw new InvalidDataException();
                    }
                }
            }
            else
            {
                Console.WriteLine("Verifique la información del empleado");
                throw new IndexOutOfRangeException();
            }

        }
        //Elimina a un empleado, toma como parámetros los apellidos del empleado
        public void EliminarUsuario()
        {
            if (BuscarApellido())
            {
                //Valida que la información suministrada cumpla con la expresión regular planteada en secciones anteriores
                Console.WriteLine("Confirme el ID del empleado para continuar con la operación: ");
                string inputID = Console.ReadLine();

                if (ValSeleccion(inputID))
                {
                    int confirmacionId = Convert.ToInt32(inputID);
                    foreach (var empleados in tiendaRepository.usuarios)
                    {
                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                        {
                            tiendaRepository.usuarios.Remove(empleados);
                            Console.WriteLine($"Se ha removido al usuario con el id {empleados[confirmacionId]}, se actualizará la base de datos");
                            break;
                        }
                    }
                }
                else
                {
                    AlertaOpcionInvalida();
                }
            }
            else
            {
                Console.WriteLine("Verifique los datos del usuario");
            }

        }
        //Solicita al usuario su correo y contraseña para iniciar sesión y comenzar a usar la app
        public bool ValidarUsuario()
        {
            //Se inicializa el contador j para registrar resultados negativos sobre la iteración en la colección usuarios
            int j = 0;

            //Solicita al usuario su correo electrónico para continuar con la ejecución del programa
            Console.WriteLine("Ingrese correo: ");
            string logCorreo = Console.ReadLine();

            if (ValCorreo(logCorreo))
            {

                //Busca el correo que suministró el usuario en la base de datos,
                //si este existe en la base de datos se continua con la ejecución del programa               
                string vCorreo = "Correo: " + logCorreo;

                //Solicita al usuario su contraseña para continuar con la sesión
                Console.WriteLine("Ingrese contraseña: ");
                string logContrasena = Console.ReadLine();
                string vContrasena = "Password: " + logContrasena;

                //Busca correo y contraseña en la base de datos
                foreach (var empleado in tiendaRepository.usuarios)
                {
                    bool IsValidCorreo = empleado.Contains(vCorreo);
                    bool IsValidContrasena = empleado.Contains(vContrasena);

                    if (IsValidCorreo && IsValidContrasena)
                    {
                        Console.Clear();
                        DibujoSup();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\n\nBienvenido {logCorreo}" +
                            $"\nPresione enter para continuar\n");

                        //Almacena la información del usuario que inició sesión dentro de la variable 
                        //SetRegistro
                        user.SetRegistroCambiosCorreo(logCorreo);
                        user.SetRegistroCambiosPassword(logContrasena);
                        Console.ForegroundColor = ConsoleColor.White;
                        DibujoInf();

                        //Si la búsqueda tiene resultados positivos imprime la información en pantalla 
                        // y devuelve un valor true
                        return true;
                    }
                    //Cuenta los resultados negativos en una búsqueda
                    else if (!IsValidContrasena && !IsValidCorreo)
                    {
                        j++;

                        //Si el contador es igual a la longitud de la colección de empleados
                        //termina el ciclo
                        if (j == tiendaRepository.usuarios.Count)
                        {
                            return false;
                        }
                        //de lo contrario continua con las iteraciones
                        else
                        {
                            continue;
                        }
                    }
                    //si la búsqueda tiene resultados negativos retorna valores falsos
                }
                return false;
            }
            else
            {
                return false;
            }

        }
        //Obtiene la información del usuario que ha iniciado sesión
        public string RegistroUsuario()
        {
            string registro = user.GetRegistroCambiosCorreo();
            return registro;
        }
        public string RegistroConstrasena()
        {
            string registro = user.GetRegistroCambiosPassword();
            return registro;
        }
        //Genera un documento.txt que tiene el correo del usuario que ha realizado los últimos cambios
        //en el sistema
        public void ImprimeRegistros()
        {
            string path = string.Format(@"C:\Users\apacheco\source\repos\Tienda\Tienda\assets\Registros{0:yyyy-MM-dd_HH-mm-ss}.txt", DateTime.Now);
            string content = $"último cambio realizado por {RegistroUsuario()} {DateTime.Now}";
            File.WriteAllText(path, content);
        }
        //Se emplea para informarle a un usuario que debe suministrar cierta información para poder realizar una operación
        public void ContextoSeleccion()
        {
            DibujoSup();
            Console.WriteLine("\n\nLa siguiente operación requiere que confirme su contraseña para continuar\n");
            DibujoInf();
            Console.WriteLine("\n\nContraseña: ");
        }
    }
}