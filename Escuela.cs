using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Timers;
using MaestroMain;




    Maestro maestro = new Maestro();

do
{
    Console.WriteLine("Seleccione la operación que desea realizar " +
        "\n1. Crear un alumno \n2. Mostrar los datos de los alumnos existentes " +
        "\n3. Buscar a un alumno " +
        "\n4. Eliminar a un alumno " +
        "\n5. Actualizar la información de un alumno");
    
    string selOperacion = Console.ReadLine();
    bool operacionOk = int.TryParse(selOperacion, out int result);
    if (operacionOk)
    {
        switch (Convert.ToInt16(selOperacion))
        {
            case 1:
                maestro.CrearAlumno();
                maestro.AgregarAlumno();
                break;
            case 2:
                maestro.MostrarAlumnos();
                break;
            case 3:
                maestro.BuscarAlumno();
                break;
            case 4:
                maestro.EliminarAlumno();
                break;
            case 5:
                maestro.ActualizarAlumno();
                break;
        }
    }
    else
    {
        break;
    }



//maestro.BuscarAlumno();

} while (true);



namespace MaestroMain
{


    class Maestro
    {
        //herramientas adicionales
        //List<string> alumnos = new List<string>();
        Dictionary<Tuple<string, string, string>, Tuple<string, string, string, string>> datos = new Dictionary<Tuple<string, string, string>, Tuple<string, string, string, string>>();
        string ingresaNombre = "Ingrese el nombre del alumno";
        string ingresaApaterno = "Ingrese el apellido paterno del alumno";
        string ingresaAmaterno = "Ingrese el apellido materno del alumno";
        string ingresaCorreo = "Ingrese el correo del alumno";
        string ingresaTelefono = "Ingrese el teléfono del alumno";
        string ingresaGrupo = "Ingrese el grupo del alumno";
        string ingresaGrado = "Ingrese el grado del alumno";
        string ingresoTexto = @"[a-zA-ZáéíóúÁÉÍÓÚ]";
        string ingresoGrado = @"^[1-6]{1,1}$";
        string ingresoGrupo = @"^[A-Fa-f]{1,1}$";
        string ingresoTelefono = @"[0-9]{10}";
        string ingresoCorreo = @"[\.a-zA-Z0-9.-_]+[@a-zA-Z]+[\.a-z]";
        string alertaTexto = "Este campo no se puede dejar en blanco y solo admite letras";
        string alertaNumero = "Este campo no se puede dejar vacío y solo admite números";
        string alertaTelefono = "Ingresa un número de teléfono válido";
        string alertaCorreo = "Ingresa un correo válido";

        //Datos alumno
        public string nombre;
        public string aPaterno;
        public string aMaterno;
        public string correo;
        public string grupo;
        public string telefono;
        public string grado;

        public Maestro()
        {

        }


        public Maestro(string nombre, string aPaterno, string aMaterno, string correo, string grupo, string telefono, string grado)
        {
            this.nombre = nombre;
            this.aPaterno = aPaterno;
            this.aMaterno = aMaterno;
            this.correo = correo;
            this.grupo = grupo;
            this.telefono = telefono;
            this.grado = grado;

        }



        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApaterno()
        {
            return aPaterno;
        }
        public void setApaterno(string aPaterno)
        {
            this.aPaterno = aPaterno;
        }

        public string getAmaterno()
        {
            return aMaterno;
        }
        public void setAMaterno(string aMaterno)
        {
            this.aMaterno = aMaterno;
        }

        public string getCorreo()
        {
            return correo;
        }
        public void setCorreo(string correo)
        {
            this.correo = correo;
        }
        public string getGrupo()
        {
            return grupo;
        }
        public void setGrupo(string grupo)
        {
            this.grupo = grupo;
        }
        public string getTelefono()
        {
            return telefono;
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public string getGrado()
        {
            return grado;
        }
        public void setGrado(string grado)
        {
            this.grado = grado;
        }

        /*
         Métodos crear nuevo alumno
         */
        public void CrearAlumno()
        {
            /*
             debe validar que se ingresen solo letras caracteres con acento
            debe validar que no se dejen espacios en blanco
             */
            do
            {
                Console.WriteLine(ingresaNombre);
                string nuevoNombre = Console.ReadLine();
                Match llenadoCampoNombre = Regex.Match(nuevoNombre, ingresoTexto);
                if (llenadoCampoNombre.Success)
                {
                    Console.WriteLine("Nombre Registrado");
                    setNombre(nuevoNombre);
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine(alertaTexto);
                }
            } while (true);

            do
            {
                Console.WriteLine(ingresaApaterno);
                string nuevoApaterno = Console.ReadLine();
                Match llenadoCampoAP = Regex.Match(nuevoApaterno, ingresoTexto);
                if (llenadoCampoAP.Success)
                {
                    setApaterno(nuevoApaterno);
                    Console.WriteLine("Apellido Paterno Registrado");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine(alertaTexto);
                }

            } while (true);

            do
            {
                Console.WriteLine(ingresaAmaterno);
                string nuevoAmaterno = Console.ReadLine();
                Match llenadoCampoAM = Regex.Match(nuevoAmaterno, ingresoTexto);
                if (llenadoCampoAM.Success)
                {
                    setAMaterno(nuevoAmaterno);
                    Console.WriteLine("Apellido Materno Registrado");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine(alertaTexto);
                }

            } while (true);

            do
            {
                Console.WriteLine(ingresaGrado);
                string nuevoGrado = Console.ReadLine();
                Match llenadoCampoG = Regex.Match(nuevoGrado, ingresoGrado);
                if (llenadoCampoG.Success)
                {
                    setGrado(nuevoGrado);
                    Console.WriteLine("Grado Registrado");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine(alertaNumero);
                }

            } while (true);

            do
            {
                Console.WriteLine(ingresaGrupo);
                string nuevoGrupo = Console.ReadLine();
                Match llenadoCampoGr = Regex.Match(nuevoGrupo, ingresoGrupo);
                if (llenadoCampoGr.Success)
                {
                    setGrupo(nuevoGrupo);
                    Console.WriteLine("Grupo Registrado");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Los grupos válidos son A,B,C,D,E y F");
                }

            } while (true);

            do
            {
                Console.WriteLine(ingresaCorreo);
                string nuevoCorreo = Console.ReadLine();
                Match llenadoCampoC = Regex.Match(nuevoCorreo, ingresoCorreo);
                if (llenadoCampoC.Success)
                {
                    setCorreo(nuevoCorreo);
                    Console.WriteLine("Correo Registrado");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;

                }
                else
                {
                    Console.WriteLine(alertaCorreo);
                }

            } while (true);

            do
            {

                Console.WriteLine(ingresaTelefono);
                string nuevoTelefono = Console.ReadLine();
                Match llenadoCampoT = Regex.Match(nuevoTelefono, ingresoTelefono);
                if (llenadoCampoT.Success)
                {
                    setTelefono(nuevoTelefono);
                    Console.WriteLine("Teléfono Registrado");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine(alertaTelefono);
                }

            } while (true);

        }

        public void AgregarAlumno()
        {
            datos.Add(Tuple.Create(nombre, aPaterno, aMaterno), Tuple.Create(grado, grupo, correo, telefono));
            var arregloDiccionario = from entry in datos orderby entry.Key.Item2 ascending select entry;

        }

        public void ActualizarAlumno()
        {
            Console.WriteLine("Ingrese el apellido paterno del alumno: ");
            string paramBusqueda = Console.ReadLine();
            Match paramBusquedaOk = Regex.Match(paramBusqueda, ingresoTexto);
            foreach (var name in datos)
            {
                if (paramBusqueda == name.Key.Item2 && paramBusquedaOk.Success)
                {
                    EliminarAlumno();
                    CrearAlumno();
                }
                else if (!paramBusquedaOk.Success)
                {
                    Console.WriteLine("este campo solo admite letras");
                }
                else
                {
                    Console.WriteLine($"El alumno con el apellido {paramBusqueda} no existe");
                }
            }
        }

        public void BuscarAlumno()
        {
            Console.WriteLine("Ingrese el apellido paterno del alumno: ");
            string paramBusqueda = Console.ReadLine();
            Match paramBusquedaOk = Regex.Match(paramBusqueda,ingresoTexto);
            foreach (var name in datos)
            {
                if (paramBusqueda == name.Key.Item2 && paramBusquedaOk.Success)
                {
                    Console.WriteLine("Datos del alumno: " +
                        $"\nNombre(s): {name.Key.Item1} " +
                        $"\nApellido Paterno: {name.Key.Item2}" +
                        $"\nApellido Materno: {name.Key.Item3}" +
                        $"\nGrado: {name.Value.Item1}" +
                        $"\nGrupo: {name.Value.Item2}" +
                        $"\nCorreo: {name.Value.Item3}" +
                        $"\nTeléfono {name.Value.Item4}");
                } 
                else if (!paramBusquedaOk.Success) 
                {
                    Console.WriteLine("este campo solo admite letras");
                }
                else
                {
                    Console.WriteLine($"El alumno con el apellido {paramBusqueda} no existe");
                }
            }
        }

        public void EliminarAlumno()
        {
            Console.WriteLine("Ingrese el apellido paterno del alumno: ");
            string paramBusqueda = Console.ReadLine();
            Match paramBusquedaOk = Regex.Match(paramBusqueda, ingresoTexto);
            foreach (var name in datos)
            {
                if (paramBusqueda == name.Key.Item2 && paramBusquedaOk.Success)
                {
                    datos.Remove(name.Key);
                }
                else if (!paramBusquedaOk.Success)
                {
                    Console.WriteLine("este campo solo admite letras");
                }
                else
                {
                    Console.WriteLine($"El alumno con el apellido {paramBusqueda} no existe");
                }
            }

        }

        public void MostrarAlumnos()
        {

            foreach (var alumno in datos)
            {
                //Console.WriteLine(datos.);
                Console.WriteLine($"Nombre(s): {alumno.Key.Item1} \nApellido Paterno: {alumno.Key.Item2} \nApellido Materno: {alumno.Key.Item3} " +
                    $"\nGrado: {alumno.Value.Item1} \nGrupo: {alumno.Value.Item2} \nCorreo: {alumno.Value.Item3} \nTeléfono: {alumno.Value.Item4}");

            }


        }

    }
}


