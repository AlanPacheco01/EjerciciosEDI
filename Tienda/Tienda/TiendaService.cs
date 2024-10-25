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

                //Patrón para validad que solo se acepte texto de parte del usuario
                string regexTexto = @"^([^0-9]+)*$";
                Match ingresoTrue = Regex.Match(ingresaTexto, regexTexto);
                bool IsValidName = ingresoTrue.Success;
                bool IsValidTexto = string.IsNullOrWhiteSpace(ingresaTexto);

                if (IsValidName && !IsValidTexto)
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
                string regexTexto = @"^([^0-9]+)*$";
                Match ingresoTrue = Regex.Match(ingresaTexto, regexTexto);
                bool IsValidFlname = ingresoTrue.Success;
                bool IsEmptyFlname = string.IsNullOrWhiteSpace(ingresaTexto);
                if (IsValidFlname && !IsEmptyFlname)
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
                string regexTexto = @"^([^0-9]+)*$";
                Match ingresoTrue = Regex.Match(ingresaTexto, regexTexto);
                bool IsValidSlname = ingresoTrue.Success;
                bool IsEmptySlname = string.IsNullOrWhiteSpace(ingresaTexto);
                if (IsValidSlname && !IsEmptySlname)
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

                //Patrón que permite el ingreso de un correo válido
                string regexCorreo = @"[\.a-zA-Z0-9.-_]+[@a-zA-Z]+[\.a-z]";
                Match ingresoTrue = Regex.Match(ingresaTexto, regexCorreo);
                bool IsValidEmail = ingresoTrue.Success;
                bool IsEmptyEmail = string.IsNullOrWhiteSpace(ingresaTexto);
                if (IsValidEmail && !IsEmptyEmail)
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
                if (IsValidPassword && IsEmptyPassword)
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
                string patterSeleccion = @"^[0-9]{1,1}$";
                Match RegexSel = Regex.Match(input, patterSeleccion);
                bool IsValidSel = RegexSel.Success;
                bool IsEmpty = string.IsNullOrEmpty(input);
                seleccionEmpleado = true;

                if (IsValidSel && !IsEmpty)
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
                    AlertaDatosErroneos();
                    throw new InvalidDataException();
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
                string patterSucursal = @"^[0-9]{1,1}$";
                Match RegexSucursal = Regex.Match(inputSucursal, patterSucursal);
                bool IsValidSucursal = RegexSucursal.Success;
                bool IsEmptySucursal = string.IsNullOrEmpty(inputSucursal);
                cicloSucursal = true;
                if (IsValidSucursal && !IsEmptySucursal)
                {
                    int seleccionSucursal = Convert.ToInt32(Console.ReadLine());
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
                    AlertaDatosErroneos();
                    throw new InvalidDataException();
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
                string patterTurno = @"^[0-9]{1,1}$";
                Match RegexTurno = Regex.Match(inputTurno, patterTurno);
                bool IsValidTurno = RegexTurno.Success;
                bool IsEmptyTurno = string.IsNullOrEmpty(inputTurno);
                seleccionTurno = true;

                if (IsValidTurno && !IsEmptyTurno)
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
                    throw new InvalidDataException();
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

        //Busca los datos de los empleados en función de los apellidos del empleado y 
        //su correo electrónico
        
        public bool BuscarApellido()
        {
            if ()
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void BuscarUsuario()
        {
            //Le informa al usuario la utilidad de esta sección
            Console.WriteLine("\nSección dedicada a buscar datos de un empleado, seleccione " +
                "\n1.Búsqueda por apellidos del empleado" +
                "\n2.Búsqueda por correo electrónico");

            //Restringe el ingreso de datos para evitar el ingreso de datos inválidos
            string input = Console.ReadLine();
            bool inputEmpty = string.IsNullOrEmpty(input);
            string pattern = @"^[0-9]${1,1}";
            Match inSel = Regex.Match(input, pattern);
            bool inSelTrue = inSel.Success;

            if (inSelTrue && !inputEmpty)
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
                throw new InvalidDataException();
            }
        }
        public void ActualizarDatos()
        {
            BuscarUsuario();
            Console.WriteLine("Confirme el ID del empleado para continuar con la operación: ");
            string inputName = Console.ReadLine();
            int confirmacionId = Convert.ToInt32(inputName);
            Console.WriteLine("Seleccione la operación que desea realizar:" +
                "\n1.Actualizar Nombre(s)" +
                "\n2.Actualizar Apellido Paterno" +
                "\n3.Actualizar Apellido MAterno" +
                "\n4.Actualizar Correo" +
                "\n5.Actualizar Password" +
                "\n6.Actualizar Tipo Empleado" +
                "\n7.Actualizar Sucursal" +
                "\n8.Actualizar Turno");
            string input = Console.ReadLine();
            int seleccion = Convert.ToInt32(input);
            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Ingrese el nuevo nombre del empleado: ");
                    string inputCorreccionNombre = Console.ReadLine();
                    string correccionNombre = "Nombre(s): " + inputCorreccionNombre;

                    foreach (var empleados in tiendaRepository.usuarios)
                    {
                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                        {
                            empleados[0] = correccionNombre;
                            Console.WriteLine(empleados[0]);
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese el nuevo apellido paterno del empleado: ");
                    string inputCorreccionApaterno = Console.ReadLine();
                    string correccionApaterno = "Apellido Paterno: " + inputCorreccionApaterno;

                    foreach (var empleados in tiendaRepository.usuarios)
                    {
                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                        {
                            empleados[1] = correccionApaterno;
                            Console.WriteLine(empleados[1]);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrese el nuevo apellido materno del empleado: ");
                    string inputCorreccionAmaterno = Console.ReadLine();
                    string correccionAmaterno = "Apellido Paterno: " + inputCorreccionAmaterno;

                    foreach (var empleados in tiendaRepository.usuarios)
                    {
                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                        {
                            empleados[2] = correccionAmaterno;
                            Console.WriteLine(empleados[2]);
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Ingrese el nuevo correo del empleado: ");
                    string inputCorreccionCorreo = Console.ReadLine();
                    string correccionCorreo = "Correo: " + inputCorreccionCorreo;

                    foreach (var empleados in tiendaRepository.usuarios)
                    {
                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                        {
                            empleados[3] = correccionCorreo;
                            Console.WriteLine(empleados[3]);
                        }
                    }
                    break;
                case 5:
                    Console.WriteLine("Ingrese el nuevo password del empleado: ");
                    string inputCorreccionPassword = Console.ReadLine();
                    string correccionPassword = "Password: " + inputCorreccionPassword;

                    foreach (var empleados in tiendaRepository.usuarios)
                    {
                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                        {
                            empleados[4] = correccionPassword;
                            Console.WriteLine(empleados[4]);
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("Ingrese el nuevo rol empleado: ");
                    string inputCorreccionTipoEmpleado = Console.ReadLine();
                    string correccionTipoEmpleado = "Tipo de empleado: " + inputCorreccionTipoEmpleado;

                    foreach (var empleados in tiendaRepository.usuarios)
                    {
                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                        {
                            empleados[5] = correccionTipoEmpleado;
                            Console.WriteLine(empleados[5]);
                        }
                    }
                    break;
                case 7:
                    Console.WriteLine("Ingrese la nueva sucursal a la que será asignado el empelado: ");
                    string inputCorreccionSucursal = Console.ReadLine();
                    string correccionSucursal = "Sucursal: " + inputCorreccionSucursal;

                    foreach (var empleados in tiendaRepository.usuarios)
                    {
                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                        {
                            empleados[6] = correccionSucursal;
                            Console.WriteLine(empleados[6]);
                        }
                    }
                    break;
                case 8:
                    Console.WriteLine("Ingrese el nuevo turno del empelado: ");
                    string inputCorreccionTurno = Console.ReadLine();
                    string correccionTurno = "Turno: " + inputCorreccionTurno;

                    foreach (var empleados in tiendaRepository.usuarios)
                    {
                        if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                        {
                            empleados[7] = correccionTurno;
                            Console.WriteLine(empleados[7]);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Ha ingresado una opción que no es válida");
                    break;
            }
        }
        public void EliminarUsuario()
        {
            BuscarUsuario();
            Console.WriteLine("Confirme el ID del empleado para continuar con la operación: ");
            string inputName = Console.ReadLine();
            int confirmacionId = Convert.ToInt32(inputName);
            foreach (var empleados in tiendaRepository.usuarios)
            {
                if (tiendaRepository.usuarios.IndexOf(empleados) == confirmacionId)
                {
                    tiendaRepository.usuarios.Remove(empleados);
                    Console.WriteLine(empleados[confirmacionId]);
                    break;
                }
            }
        }
        public bool ValidarUsuario()
        {

            int j = 0;
            Console.WriteLine("Ingrese correo: ");
            string logCorreo = Console.ReadLine();
            string regexCorreo = @"[\.a-zA-Z0-9.-_]+[@a-zA-Z]+[\.a-z]";
            Match regexLogin = Regex.Match(logCorreo, regexCorreo);
            bool IsValidRegexdCorreo = regexLogin.Success;
            bool IsEmptyRegexCorreo = string.IsNullOrEmpty(logCorreo);
            if (IsValidRegexdCorreo && !IsEmptyRegexCorreo)
            {

                string vCorreo = "Correo: " + logCorreo;
                Console.WriteLine("Ingrese contraseña: ");
                string logContrasena = Console.ReadLine();
                string vContrasena = "Password: " + logContrasena;
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
                        user.SetRegistroCambiosCorreo(logCorreo);
                        user.SetRegistroCambiosPassword(logContrasena);
                        Console.ForegroundColor = ConsoleColor.White;
                        DibujoInf();
                        return true;
                    }
                    else if (!IsValidContrasena && !IsValidCorreo)
                    {
                        j++;
                        if (j == tiendaRepository.usuarios.Count)
                        {
                            return false;
                        }
                        else
                        {
                            continue;
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
        public void ImprimeRegistros()
        {
            //string fileName = $"Registros{DateTime.Now}";
            string path = string.Format(@"C:\Users\apacheco\source\repos\Tienda\Tienda\assets\Registros{0:yyyy-MM-dd_HH-mm-ss}.txt", DateTime.Now);
            string content = $"último cambio realizado por {RegistroUsuario()} {DateTime.Now}";
            File.WriteAllText(path, content);
        }
        public void ContextoSeleccion()
        {
            DibujoSup();
            Console.WriteLine("\n\nLa siguiente operación requiere que confirme su contraseña para continuar\n");
            DibujoInf();
            Console.WriteLine("\n\nContraseña: ");
        }

    }
}