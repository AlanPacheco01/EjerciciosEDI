using System;
using System.Text.RegularExpressions;

namespace Tienda
{
    class TiendaController : Bienvenida
    {
        //Instancia los objetos necesarios para la prueba
        TiendaService conexion = new TiendaService();
        TiendaModel user = new TiendaModel();

        //Invoca los métodos necesarios para que el usuario pueda interactuar con el programa
        public void Interaccion()
        {
        //Si la contraseña es erronea reinicia el ciclo con la instrucción goto:
        //Se usa la etiqueta "PantallaInicial para reiniciar el ciclo"
        PantallaInicial:

            //Le dice al usuario el propósito de la aplicación
            MensajeBienvenida();

            //Genera el margen inferior
            DibujoInf();

            //Le dice al usuario que debe ingresar usuario y contraseña
            Contexto();
            int seleccion;

            //Carga una pseudobase de datos que se usa para operaciones
            //Delete, Update y Read
            conexion.DatosPrueba();

            //invoca el método "ValidadUsuario" que tiene la función de buscar el correo
            //y la contraseña en la DB
            //si el usuario existe retorna un true
            bool isvalid = conexion.ValidarUsuario();

            //limpia la información en la consola y detiene la ejecución del programa hasta que el usuario
            //presione "Enter"
            Espacios();

            //Evalua si la información proporcionada es correcta
            if (isvalid)
            {
                //le muestra al usuario las opciones disponibles con las que cuenta el programa
                //Se usa un do-while para que el usuario pueda realizar múltiples operaciones al iniciar sesión
                do
                {

                //Etiqueta "Inicio" se usa para redireccionar al usuario al principio del código si los datos del usuario 
                //son incorrectos o son nulos
                Inicio:
                    DibujoSup();

                    //Le muestra al usuario las funcionalidades de la aplicación
                    OpcionesPantallaInicio();

                    DibujoInf();

                    //Le da al usuario la facultad de selecionar la operación
                    Console.WriteLine("\n\nDigite su elección: ");
                    string input = Console.ReadLine();

                    //Restringe el ingreso de datos a solo números con el siguiente patrón
                    string patterSeleccion = @"^[0-9]{1,1}$";

                    //Se usa "System.Text.RegularExpressions" para comparar la regex con los datos de entrada 
                    Match RegexSel = Regex.Match(input, patterSeleccion);

                    //Se usa para obtener información del ensayo anterior
                    bool IsValidSel = RegexSel.Success;

                    //Se usa para verificar si no se dejan campos vacíos
                    bool IsEmpty = string.IsNullOrEmpty(input);

                    //Convierte la string suministrada en un valor int para continuar con el proceso
                    // si el usuario digita 0 termina el programa

                    seleccion = Convert.ToInt32(input);                   

                    //Si se cumplen los requisitos anteriores, el usuario puede acceder a las funcionalidades
                    //de la aplicación
                    if (IsValidSel && !IsEmpty)
                    {
                        switch (seleccion)
                        {
                            case 1:
                                Console.Clear();

                                //Se solicita la contaseña al usuario para poder continuar con la operación
                                //Solicita la contraseña al usuario
                                conexion.ContextoSeleccion();
                                string inputPassword = Console.ReadLine();
                                Console.WriteLine("\n");

                                //Compara la contraseña suministrada contra la que registrada en la base de datos
                                bool IsValidPassword = inputPassword.Equals(conexion.RegistroConstrasena());
                                if (IsValidPassword)
                                {
                                    Console.Clear();
                                    DibujoSup();
                                    Console.WriteLine("\n");

                                    //Invoca al método CrearUsuario para iniciar con el proceso de registro de un nuevo usuario
                                    CrearUsuario();

                                    //Invoca al método RegistroUsuario para guardar la información del último usuario que realizó 
                                    //cambios en el sistema
                                    conexion.RegistroUsuario();

                                    //Genera un documento.txt con la información que se guardó con el comando anterior
                                    conexion.ImprimeRegistros();

                                    DibujoInf();

                                }
                                else
                                {
                                    //Cambia el color de la letra a rojo para indicar una operación fallida
                                    ContrasenaErronea();
                                    goto Inicio;
                                }
                                break;

                            case 2:
                                //Invoca al método Mostrar datos para imprimir a todos los usuarios en la CLI
                                DibujoSup();
                                conexion.MostrarDatos();
                                DibujoInf();
                                break;
                            case 3:
                                //Invoca al método BuscarUsuario para realizar una búsqueda por medio de los
                                //apellidos de los usuarios
                                DibujoSup();

                                //Busca al usuario por medio de sus apellidos
                                conexion.BuscarUsuario();
                                DibujoInf();
                                break;
                            case 4:
                                conexion.ContextoSeleccion();
                                string inputActualizar = Console.ReadLine();
                                bool IsValidActualizar = inputActualizar.Equals(conexion.RegistroConstrasena());
                                if (IsValidActualizar)
                                {
                                    //Invoca el método "Actualizar datos"
                                    conexion.ActualizarDatos();
                                    conexion.RegistroUsuario();
                                    conexion.ImprimeRegistros();
                                }
                                else
                                {
                                    ContrasenaErronea();
                                    goto Inicio;
                                }
                                break;
                            case 5:
                                conexion.ContextoSeleccion();
                                string inputEliminar = Console.ReadLine();
                                bool IsValidEliminar = inputEliminar.Equals(conexion.RegistroConstrasena());
                                if (IsValidEliminar)
                                {
                                    //Invoca al método "Eliminar usuario"
                                    conexion.EliminarUsuario();
                                    conexion.RegistroUsuario();
                                    conexion.ImprimeRegistros();
                                }
                                else
                                {
                                    ContrasenaErronea();
                                    goto Inicio;
                                }
                                break;
                            case 0:
                                //Agradece al usuario por usar los servicios
                                Agradecimiento();
                                break;
                            default:
                                //Anuncia al usuario que la opción seleccionada no es válida
                                AlertaOpcionInvalida();
                                break;
                        }
                    }
                } while (seleccion != 0);
            }
            else
            {
                AlertaDatosErroneos();
                goto PantallaInicial;
            }
        }

        //Le da información al usuario sobre el objetivo de esta sección
        public void ContextoRegistroUsuario()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nEsta sección le permitirá dar de alta a un nuevo empleado: " +
                "\n¿Desea comenzar con el proceso (y/n)?\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            DibujoInf();
        }

        //Informa al usuario que el registro del empleado ha sido exitoso
        public void AlertaRegistroExitoso()
        {

            Console.ForegroundColor = ConsoleColor.White;
            DibujoSup();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nEl empleado ha sido registrado con éxito, ¿Desea añadir a otro empleado (y/n)?\n");
            Console.ForegroundColor = ConsoleColor.White;
            DibujoInf();
            Console.WriteLine("\nDigite la opción deseada: \n");
        }

        //Contiene los métodos necesarios para crear un usuario nuevo
        public void CrearUsuario()
        {
            bool seleccion;
            do
            {
            Inicio:
                //Le da al usuario la funcionalidad de esta sección
                ContextoRegistroUsuario();
                
                //Permite al usuario continuar o terminar el programa
                Console.WriteLine("\nDigite su opción: ");
                string proceso = Console.ReadLine();

                //Patrón que previene el ingreso de datos no especificados por el programa
                string pattern = @"^[yn]{1,1}";
                Match CrearRegex = Regex.Match(proceso, pattern);

                //Validación del cumplimiento de las reglas
                bool IsValidRegex = CrearRegex.Success;
                bool IsEmpytRegex = string.IsNullOrEmpty(proceso);
                seleccion = true;

                if (proceso == "y" && IsValidRegex && !IsEmpytRegex)
                {
                    //Recibe información por medio de la consola
                    Console.Clear();
                    conexion.IngresaNombre();
                    conexion.IngresaApaterno();
                    conexion.IngresaAmaterno();
                    conexion.IngresaCorreo();
                    conexion.IngresaPassword();
                    conexion.IngresaSucursal();
                    conexion.IngresaTipoEmpleado();
                    conexion.IngresaTurno();
                    conexion.GuardarDatos();
                    Console.Clear();
                    AlertaRegistroExitoso();
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
                else if (proceso == "n" && IsValidRegex && !IsEmpytRegex)
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
                    AlertaOpcionInvalida();
                }

            } while (seleccion);
        }
    }
}
