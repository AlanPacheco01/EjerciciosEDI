using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion
{
    class Main
    {
        //datos para el mapeo
        private int id;
        public int Id { get { return id; } set { id = value; } }
        private string name;
        public string Name { get { return name; } set { name = value; } }
        private string flname;
        public string Flname { get { return flname; } set { flname = value; } }
        private string slname;
        public string Slname { get { return slname; } set { slname = value; } }
        private string correo;
        public string Correo { get { return correo; } set { correo = value; } }
        private string password;
        public string Password { get { return password; } set { password = value; } }
        private string cargo;
        public string Cargo { get { return cargo; } set { cargo = value; } }
        private string sucursal;
        public string Sucursal { get { return sucursal; } set { sucursal = value; } }
        private string turno;
        public string Turno { get { return turno; } set { turno = value; } }

        //Constructor
        public Main(int id, string name, string flname, string slname, string correo, string password, string cargo, string sucursal, string turno)
        {
            this.id = id;
            this.name = name;
            this.flname = flname;
            this.slname = slname;
            this.correo = correo;
            this.password = password;
            this.cargo = cargo;
            this.sucursal = sucursal;
            this.turno = turno;
        }

        public Main()
        {

        }
    }
}
