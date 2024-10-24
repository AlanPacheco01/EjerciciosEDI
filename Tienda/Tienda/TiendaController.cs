using System;

namespace Tienda
{
    class TiendaController
    {
        TiendaService conexion = new TiendaService();
        TiendaModel user = new TiendaModel();

        public void Interaccion()
        {
            int seleccion;
            conexion.DatosPrueba();
            bool isvalid = conexion.ValidarUsuario();
            /*
             "Correo: " + "scuevasa@gmail.com", "Password: " + "CorazonMelon@8"
             */
            if (isvalid)
            {
                do
                {
                Inicio:
                    Console.WriteLine("El siguiente programa le permitirá interactuar con la información de un usuario, seleccione: " +
                    "\n1.Crear un nuevo usuario" +
                    "\n2.Mostrar a los usuarios existentes" +
                    "\n3.Buscar un usuario" +
                    "\n4.Actualizar datos" +
                    "\n5.Eliminar a un usuario" +
                    "\nO presione 0 para salir del programa");
                    string input = Console.ReadLine();
                    seleccion = Convert.ToInt32(input);

                    switch (seleccion)
                    {
                        case 1:
                            Console.WriteLine("La siguiente operación requiere que confirme su contraseña para continuar" +
                                "\nIngrese contraseña: ");
                            string inputPassword = Console.ReadLine();
                            bool IsValidPassword = inputPassword.Equals(conexion.RegistroConstrasena());
                            if (IsValidPassword)
                            {
                                CrearUsuario();
                                conexion.RegistroUsuario();
                            }
                            else
                            {
                                Console.WriteLine("Contraseña erronea");
                                goto Inicio;
                            }
                            break;
                        case 2:
                            ShowAllUsers();
                            break;
                        case 3:
                            conexion.BuscarUsuario();
                            break;
                        case 4:
                            Console.WriteLine("La siguiente operación requiere que confirme su contraseña para continuar" +
                                "\nIngrese contraseña: ");
                            string inputActualizar = Console.ReadLine();
                            bool IsValidActualizar = inputActualizar.Equals(conexion.RegistroConstrasena());
                            if (IsValidActualizar)
                            {
                                conexion.ActualizarDatos();
                                conexion.RegistroUsuario();


                            }
                            else
                            {
                                Console.WriteLine("Contraseña erronea");
                                goto Inicio;
                            }
                            break;
                        case 5:
                            Console.WriteLine("La siguiente operación requiere que confirme su contraseña para continuar" +
                                "\nIngrese contraseña: ");
                            string inputEliminar = Console.ReadLine();
                            bool IsValidEliminar = inputEliminar.Equals(conexion.RegistroConstrasena());
                            if (IsValidEliminar)
                            {
                                conexion.EliminarUsuario();
                                conexion.RegistroUsuario();

                            }
                            else
                            {
                                Console.WriteLine("Contraseña erronea");
                                goto Inicio;
                            }
                            break;
                        case 0:
                            Console.WriteLine($"Gracias por usar nuestros servicios");
                            break;
                        case 2024:
                            Console.WriteLine("Opción de superadministrador, imprime registros de modificaciones");
                            conexion.ImprimeRegistros();

                            break;
                        default:
                            Console.WriteLine("Ha seleccionado una opción inválida");
                            break;
                    }
                } while (seleccion != 0);
            }
            else
            {
                Console.WriteLine("Usuario o contraseña erroneo");
            }
            Console.ReadKey();
        }

        public void CrearUsuario()
        {
            bool seleccion;
            do
            {
            Inicio:
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Esta sección le permitirá dar de alta a un nuevo empleado: " +
                    "\n¿Desea comenzar con el proceso (y/n)?");
                string proceso = Console.ReadLine();
                seleccion = true;
                if (proceso == "y")
                {
                    conexion.IngresaNombre();
                    conexion.IngresaApaterno();
                    conexion.IngresaAmaterno();
                    conexion.IngresaCorreo();
                    conexion.IngresaPassword();
                    conexion.IngresaSucursal();
                    conexion.IngresaTipoEmpleado();
                    conexion.IngresaTurno();
                    conexion.GuardarDatos();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("El empleado ha sido registrado con éxito, ¿Desea añadir a otro empleado (y/n)?");
                    string finalizarProceso = Console.ReadLine();
                    if (finalizarProceso == "n")
                    {
                        seleccion = false;

                    }
                    else
                    {
                        goto Inicio;
                    }
                }
                else if (proceso == "n")
                {
                    Console.WriteLine("¿Desea finalizar el programa (y/n)?");
                    string continuaProceso = Console.ReadLine();
                    if (continuaProceso == "y")
                    {
                        seleccion = false;
                    }
                    else
                    {
                        goto Inicio;
                    }
                }
                else
                {
                    Console.WriteLine("Ha seleccionado una opción inválida");
                }

            } while (seleccion);

        }

        public void ShowAllUsers()
        {
            conexion.MostrarDatos();
        }
    }


}
