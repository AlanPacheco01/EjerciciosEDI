using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class TiendaModel
    {
        private long id; //se crea campo para posterior conexión con la BD, técnica autoincrementativa
        private string nombre;   //Muestra la información del empleado en la consola
        private string aPaterno;
        private string aMaterno;
        private string correo; //Información para validar la cuenta
        private string password;
        private string tipoEmpleado; //Ej. cajero, gerente
        private string sucursal;
        private string turno; //Matutino, Vespertino

        //Variables para registrar los cambios realizados en el sistema por un usuario
        private string _registroCambiosCorreo;
        private string _registroCambiosPassword;

        public string GetRegistroCambiosPassword()
        {
            return _registroCambiosPassword;
        }

        public void SetRegistroCambiosPassword(string _registroCambiosPassword)
        {
            this._registroCambiosPassword = _registroCambiosPassword;
        }

        public string GetRegistroCambiosCorreo()
        {
            return _registroCambiosCorreo;
        }

        public void SetRegistroCambiosCorreo(string _registroCambiosCorreo)
        {
            this._registroCambiosCorreo = _registroCambiosCorreo;
        }
        
        public TiendaModel()
        {

        }
        public TiendaModel(long id, string nombre, string aPaterno, string aMaterno, string correo, string password, string tipoEmpleado, string sucursal, string turno)
        {
            this.id = id;
            this.nombre = nombre;
            this.aPaterno = aPaterno;
            this.aMaterno = aMaterno;
            this.correo = correo;
            this.password = password;
            this.tipoEmpleado = tipoEmpleado;
            this.sucursal = sucursal;
            this.turno = turno;
        }
        
        public long GetId()
        {
            return id;
        }
        public void SetId(long id) 
        {
            this.id = id;
        }

        public string GetNombre() 
        {
            return nombre;
        }
        public string GetApaterno() 
        {
            return aPaterno;
        }
        public string GetAmaterno() 
        {
            return aMaterno;
        }

        public void SetNombre(string nombre) 
        {
            this.nombre = nombre;
        }
        public void SetApaterno(string aPaterno) 
        {
            this.aPaterno = aPaterno;
        }
        public void SetAmaterno(string aMaterno) 
        {
            this.aMaterno = aMaterno;
                
        }

        public string GetCorreo() 
        { 
            return correo; 
        }
        public string GetPassword() 
        { 
            return password; 
        }
        public string GetTipoEmpleado() 
        { 
            return tipoEmpleado; 
        }
        public string GetSucursal() 
        { 
            return sucursal; 
        }
        public string GetTurno() 
        { 
            return turno; 
        }

        public void SetCorreo(string correo) 
        { 
            this.correo = correo; 
        }
        public void SetPassword(string password) 
        { 
            this.password = password; 
        }
        public void SetTipoEmpleado(string tipoEmpleado) 
        { 
            this.tipoEmpleado = tipoEmpleado; 
        }
        public void SetSucursal(string sucursal) 
        { 
            this.sucursal = sucursal; 
        }
        public void SetTurno(string turno) 
        { 
            this.turno = turno; 
        }
    }
}
