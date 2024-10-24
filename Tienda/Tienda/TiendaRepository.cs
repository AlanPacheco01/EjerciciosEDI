using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Tienda
{
    class TiendaRepository<T>
    {
        public ObservableCollection<T> usuarios;
        public ObservableCollection<T> registroCambios;


        public void Prueba()
        {
            
        }


        public TiendaRepository()
        {
            usuarios = new ObservableCollection<T>();
            registroCambios = new ObservableCollection<T>();
        }
        


        public T Add(T item)
        {
            usuarios.Add(item);
            return item;
        }

        //public List<string> Remove(List<string> item)
        //{
        //    usuarios.Remove(item);
        //    return item;
        //}

        //public IEnumerableList<string> GetAll()
        //{
        //    return usuarios;
        //}

        //public IEnumerator<T> GetEnumerator()
        //{
        //    return usuarios;
        //}


    }
}
