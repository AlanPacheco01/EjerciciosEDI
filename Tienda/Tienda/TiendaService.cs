using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;



namespace Tienda
{
    class TiendaService
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

        public void IngresaNombre()
        {
            bool fin;
            do
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingresa el nombre del empleado");
                string ingresaTexto = Console.ReadLine();
                string regexTexto = @"^([^0-9]+)*$";
                Match ingresoTrue = Regex.Match(ingresaTexto, regexTexto);
                if (!ingresoTrue.Success || string.IsNullOrWhiteSpace(ingresaTexto))
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    user.SetNombre(ingresaTexto);
                    Console.WriteLine($"Se ha registrado {ingresaTexto} con éxito");
                    fin = false;
                }
            } while (fin);

        }
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
                if (!ingresoTrue.Success || string.IsNullOrWhiteSpace(ingresaTexto))
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    user.SetApaterno(ingresaTexto);
                    Console.WriteLine($"Se ha registrado {ingresaTexto} con éxito");
                    fin = false;
                }
            } while (fin);

        }
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
                if (!ingresoTrue.Success || string.IsNullOrWhiteSpace(ingresaTexto))
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    user.SetAmaterno(ingresaTexto);
                    Console.WriteLine($"Se ha registrado {ingresaTexto} con éxito");
                    fin = false;
                }
            } while (fin);
        }
        public void IngresaCorreo()
        {
            bool fin;
            do
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingresa el correo del empleado");
                string ingresaTexto = Console.ReadLine();
                string regexCorreo = @"[\.a-zA-Z0-9.-_]+[@a-zA-Z]+[\.a-z]";
                Match ingresoTrue = Regex.Match(ingresaTexto, regexCorreo);
                if (!ingresoTrue.Success || string.IsNullOrWhiteSpace(ingresaTexto))
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    user.SetCorreo(ingresaTexto);
                    Console.WriteLine($"Se ha registrado {ingresaTexto} con éxito");
                    fin = false;
                }
            } while (fin);
        }
        public void IngresaPassword()
        {
            bool fin;
            do
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingresa el password del empleado");
                string ingresaTexto = Console.ReadLine();
                string regexPassword = @"[a-zA-Z0-9@.-_$%&#!¡¿?+*]{8,12}";
                Match ingresoTrue = Regex.Match(ingresaTexto, regexPassword);
                if (!ingresoTrue.Success || string.IsNullOrWhiteSpace(ingresaTexto))
                {

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{ingresaTexto} no es válido");
                    fin = true;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    user.SetPassword(ingresaTexto);
                    Console.WriteLine($"Se ha registrado {ingresaTexto} con éxito");
                    fin = false;
                }
            } while (fin);
        }
        public void IngresaTipoEmpleado()
        {
            bool seleccionEmpleado;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese el tipo de empleado: " +
                        $"\n1.{TipoEmpleado.asesor}" +
                        $"\n2.{TipoEmpleado.cajero}" +
                        $"\n3.{TipoEmpleado.demostrador}" +
                        $"\n4.{TipoEmpleado.gerente}" +
                        $"\n5.{TipoEmpleado.outsourcing}" +
                        $"\n6.{TipoEmpleado.vendedor}");
                int seleccionTipoEmpleado = Convert.ToInt32(Console.ReadLine());
                seleccionEmpleado = true;
                switch (seleccionTipoEmpleado)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.asesor}");
                        user.SetTipoEmpleado($"{TipoEmpleado.asesor}");
                        seleccionEmpleado = false;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.cajero}");
                        user.SetTipoEmpleado($"{TipoEmpleado.cajero}");
                        seleccionEmpleado = false;
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.demostrador}");
                        user.SetTipoEmpleado($"{TipoEmpleado.demostrador}");
                        seleccionEmpleado = false;
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.gerente}");
                        user.SetTipoEmpleado($"{TipoEmpleado.gerente}");
                        seleccionEmpleado = false;
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.outsourcing}");
                        user.SetTipoEmpleado($"{TipoEmpleado.outsourcing}");
                        seleccionEmpleado = false;
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Se designó a {user.GetNombre()} como {TipoEmpleado.vendedor}");
                        user.SetTipoEmpleado($"{TipoEmpleado.vendedor}");
                        seleccionEmpleado = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ha seleccionado una opción que no es válida");
                        break;
                }
            } while (seleccionEmpleado);

        }
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
                int seleccionSucursal = Convert.ToInt32(Console.ReadLine());
                cicloSucursal = true;
                switch (seleccionSucursal)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Empleado asignado a {Sucursales.Azcapotzalco}");
                        user.SetSucursal($"{Sucursales.Azcapotzalco}");
                        cicloSucursal = false;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Empleado asignado a {Sucursales.Copilco}");
                        user.SetSucursal($"{Sucursales.Copilco}");
                        cicloSucursal = false;
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Empleado asignado a {Sucursales.Coyoacán}");
                        user.SetSucursal($"{Sucursales.Coyoacán}");
                        cicloSucursal = false;
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Empleado asignado a {Sucursales.Perisur}");
                        user.SetSucursal($"{Sucursales.Perisur}");
                        cicloSucursal = false;
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Empleado asignado a {Sucursales.Potrero}");
                        user.SetSucursal($"{Sucursales.Potrero}");
                        cicloSucursal = false;
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Empleado asignado a {Sucursales.Taxqueña}");
                        user.SetSucursal($"{Sucursales.Taxqueña}");
                        cicloSucursal = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ha seleccionado una opción que no es válida");
                        break;
                }
            } while (cicloSucursal);
        }
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
                int selTurno = Convert.ToInt32(Console.ReadLine());
                seleccionTurno = true;
                switch (selTurno)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Empleado asignado a {Turno.Matutino}");
                        user.SetTurno($"{Turno.Matutino}");
                        seleccionTurno = false;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Empleado asignado a {Turno.Vespertino}");
                        user.SetTurno($"{Turno.Nocturno}");
                        seleccionTurno = false;
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Empleado asignado a {Turno.Nocturno}");
                        user.SetTurno($"{Turno.Nocturno}");
                        seleccionTurno = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Ha seleccionado una opción que no es válida");
                        break;
                }

            } while (seleccionTurno);

        }
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
            var temp = new List<string> { "Nombre(s): " + addName, "Apellido Paterno: " + addFlname, "Apellido Materno: " + addSlname, "Correo: " + addCorreo, "Password: " + addPassword, "Tipo de empleado: " + addTipoEmpleado, "Sucursal: " + addSucursal, "Turno: " + addTurno };
            tiendaRepository.Add(temp);
        }
        public void MostrarDatos()
        {
            foreach (var empleado in tiendaRepository.usuarios)
            {
                string separador = string.Concat(Enumerable.Repeat("-", Console.WindowWidth));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n{separador}\n");
                foreach (var datos in empleado)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{datos}");

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n{separador}\n");
            }
        }
        public void BuscarUsuario()
        {
            Console.WriteLine("Sección dedicada a buscar datos de un empleado, seleccione " +
                "\n1.Búsqueda por apellidos del empleado" +
                "\n2.Búsqueda por correo electrónico");
            string input = Console.ReadLine();
            bool inputEmpty = string.IsNullOrEmpty(input);
            string pattern = @"^[0-9]${1,1}";
            Match inSel = Regex.Match(input, pattern);
            bool inSelTrue = inSel.Success;
            List<string> datosEmpleado;

            if (inSelTrue && !inputEmpty)
            {
                int seleccion = Convert.ToInt32(input);

                switch (seleccion)
                {
                    case 1:
                    Inicio:
                        Console.WriteLine("Ingrese el apellido paterno del empleado");
                        string aPaterno = Console.ReadLine();
                        string busquedaPaterno = "Apellido Paterno: " + aPaterno;
                        bool aPaternoEmpty = string.IsNullOrEmpty(aPaterno);
                        Console.WriteLine("Ingrese el apellido Materno del empleado");
                        string aMaterno = Console.ReadLine();
                        string busquedaMaterno = "Apellido Materno: " + aMaterno;
                        bool aMaternoEmpty = string.IsNullOrEmpty(aMaterno);
                        bool bPaterno;
                        bool bMaterno;
                        if (!aPaternoEmpty || !aMaternoEmpty)
                        {
                            foreach (var empleado in tiendaRepository.usuarios)
                            {
                                bPaterno = empleado.Contains(busquedaPaterno);
                                bMaterno = empleado.Contains(busquedaMaterno);

                                if (bPaterno && bMaterno)
                                {
                                    foreach (var dato in empleado)
                                    {
                                        Console.WriteLine(dato);
                                    }
                                    Console.WriteLine($"El ID del empleado es: {tiendaRepository.usuarios.IndexOf(empleado)}");

                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Estos campos no se pueden dejar vacíos");
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
                        bool bCorreo;
                        if (!correoEmpty && correoTrue.Success)
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
                            }
                        }
                        else
                        {
                            Console.WriteLine("Estos campos no se pueden dejar vacíos");
                            goto InicioCorreo;
                        }
                        break;
                    default:
                        Console.WriteLine("Ha seleccionado una opción que no es parte del menú");
                        break;
                }
            }
            else
            {

                Console.WriteLine("Este campo no se puede dejar vacío y solo debe contener un número");
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
                    Console.WriteLine($"Welcome {logCorreo}");
                    user.SetCorreo(logCorreo);
                    user.SetPassword(logContrasena);
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
        public string RegistroUsuario()
        {
            string registro = user.GetCorreo();
            return registro;
        }
        public string RegistroConstrasena()
        {
            string registro = user.GetPassword();
            return registro;
        }
        public void ImprimeRegistros()
        {
            //string fileName = $"Registros{DateTime.Now}";
            string path = string.Format(@"C:\Users\apacheco\source\repos\Tienda\Tienda\assets\Registros{0:yyyy-MM-dd_HH-mm-ss}.txt",DateTime.Now);
            string content = $"último cambio realizado por {RegistroUsuario()} {DateTime.Now}";
            File.WriteAllText(path,content);
        }
    }
}