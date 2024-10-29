using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sesion
{
    class Metodos
    {
        //Instanciando la clase Main
        Main datos = new Main();
        //Lista en donde se guarda la información mapeada
        static List<Main> result = new List<Main>();
        static List<Main> FileA = new List<Main>();
        static List<Main> FileB = new List<Main>();
        static List<Main> cambios = new List<Main>();

        //Método ToString() para convertir de System collection a un string
        public override string ToString()
        {
            return $"{datos.Id} | {datos.Name} | {datos.Flname} | {datos.Slname} | {datos.Correo} | {datos.Password} | {datos.Cargo} | {datos.Sucursal} | {datos.Turno}";
        }

        //Selecciona el archivo más reciente para leerlo
        private string RecentFiles()
        {
            string directoryPath = @"C:\Users\apacheco\source\repos\Sesion\Sesion\Assets";
            string filePattern = "actualizacion_prueba_uno_*.txt";

            // Get all files matching the pattern
            var files = Directory.GetFiles(directoryPath, filePattern);

            // Select the most recent file based on last write time
            var latestFile = files
                .Select(file => new FileInfo(file))
                .OrderBy(fileInfo => fileInfo.CreationTime)
                .FirstOrDefault();

            if (latestFile != null)
            {
                string path = latestFile.FullName;
                return path;
            }
            else
            {
                return "No files found.";
            }
        }
        //Lee el archivo y lo almacena en una colección iterabl
        public void Lectura()
        {
            var file = new StreamReader(RecentFiles());
            var line = string.Empty;
            while ((line = file.ReadLine()) != null)
            {
                string[] items = line.Split('|');
                result.Add(new Main
                {
                    Id = Convert.ToInt32(items[0]),
                    Name = items[1],
                    Flname = items[2],
                    Slname = items[3],
                    Correo = items[4],
                    Password = items[5],
                    Cargo = items[6],
                    Sucursal = items[7],
                    Turno = items[8],
                });
            }
        }
        //Recibe la información nueva que ingresa el usuario
        public void Actualizacion()
        {
            int idConsecutivo = result.Count() + 1;
            string idConsString = Convert.ToString(idConsecutivo);
            Console.WriteLine("Ingrese nombre: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Ingrese apellido paterno: ");
            string inputFlname = Console.ReadLine();
            Console.WriteLine("Ingrese apellido materno: ");
            string inputSlname = Console.ReadLine();
            Console.WriteLine("Ingrese correo: ");
            string inputCorreo = Console.ReadLine();
            Console.WriteLine("Ingrese password: ");
            string inputPassword = Console.ReadLine();
            Console.WriteLine("Ingrese cargo: ");
            string inputCargo = Console.ReadLine();
            Console.WriteLine("Ingrese sucursal: ");
            string inputSucursal = Console.ReadLine();
            Console.WriteLine("Ingrese turno: ");
            string inputTurno = Console.ReadLine();

            List<string> actualizacion = new List<string>
    {
                idConsString,
        inputName,
        inputFlname,
        inputSlname,
        inputCorreo,
        inputPassword,
        inputCargo,
        inputSucursal,
        inputTurno
    };

            if (actualizacion.Count >= 9)
            {
                var nuevoRegistro = new Main
                {
                    Id = Convert.ToInt32(actualizacion[0]),
                    Name = actualizacion[1],
                    Flname = actualizacion[2],
                    Slname = actualizacion[3],
                    Correo = actualizacion[4],
                    Password = actualizacion[5],
                    Cargo = actualizacion[6],
                    Sucursal = actualizacion[7],
                    Turno = actualizacion[8],
                };

                result.Add(nuevoRegistro);

            }

            //return result;
        }

        //Escribe la información actualizada en un archivo txt
        public void Escritura()
        {
            string path = string.Format(@"C:\Users\apacheco\source\repos\Sesion\Sesion\Assets\actualizacion_prueba_uno_{0:yyyy-MM-dd_HH-mm-ss}.txt", DateTime.Now);
            using (var writer = new StreamWriter(path))
            {
                foreach (var item in result)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }
        private string ArchivoPrevio()
        {
            string directoryPath = @"C:\Users\apacheco\source\repos\Sesion\Sesion\Assets";
            string filePattern = "actualizacion_prueba_uno_*.txt";

            // Get all files matching the pattern
            var files = Directory.GetFiles(directoryPath, filePattern);

            // Select the most recent file based on last write time
            var latestFile = files
                .Select(file => new FileInfo(file))
                .OrderBy(fileInfo => fileInfo.CreationTime)
                .LastOrDefault();

            if (latestFile != null)
            {
                string path = latestFile.FullName;
                return path;
            }
            else
            {
                return "No files found.";
            }
        }
        private void ComparaArchivos()

        {
            var fileA = new StreamReader(RecentFiles());
            var lineA = string.Empty;
            while ((lineA = fileA.ReadLine()) != null)
            {
                string[] itemA = lineA.Split('|');
                FileA.Add(new Main
                {
                    Id = Convert.ToInt32(itemA[0]),
                    Name = itemA[1],
                    Flname = itemA[2],
                    Slname = itemA[3],
                    Correo = itemA[4],
                    Password = itemA[5],
                    Cargo = itemA[6],
                    Sucursal = itemA[7],
                    Turno = itemA[8],
                });
            }

            var fileB = new StreamReader(ArchivoPrevio());
            var lineB = string.Empty;
            while ((lineB = fileB.ReadLine()) != null)
            {
                string[] itemB = lineB.Split('|');
                FileB.Add(new Main
                {
                    Id = Convert.ToInt32(itemB[0]),
                    Name = itemB[1],
                    Flname = itemB[2],
                    Slname = itemB[3],
                    Correo = itemB[4],
                    Password = itemB[5],
                    Cargo = itemB[6],
                    Sucursal = itemB[7],
                    Turno = itemB[8],
                });
            }


            if (!FileA.Equals(FileB))
            {

                cambios = FileB.Except(FileA).ToList();
                string changes = string.Format(@"C:\Users\apacheco\source\repos\Sesion\Sesion\Assets\Cambios_{0:yyyy-MM-dd_HH-mm-ss}.txt", DateTime.Now);
                using (var writer = new StreamWriter(changes))
                {
                    writer.WriteLine($"Se han realizado los siguientes cambios a las {DateTime.Now}");
                    writer.WriteLine(cambios.Last());
                }
            }
            else
            {
                string changes = string.Format(@"C:\Users\apacheco\source\repos\Sesion\Sesion\Assets\Cambios_{0:yyyy-MM-dd_HH-mm-ss}.txt", DateTime.Now);
                using (var writer = new StreamWriter(changes))
                {
                    writer.WriteLine($"Sin cambios");

                }
            }

        }
    }
}
