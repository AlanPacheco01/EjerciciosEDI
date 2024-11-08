using System;
using System.Linq;
namespace LinQ
{
    class Program
    {

        static void Main(string[] args)
        {
            var datos = new Datos();
            var qS = new QuickSort();
            var bubble = new Burbuja();

            var arr = datos.Numeros();
            var n = datos.Numeros().Length;

            ////10 megas y 7.38 segundos
            //qS.Quicksort(arr, 0, n - 1);

            //foreach (var a in arr)
            //{

            //    Console.WriteLine(a);
            //}


            //// 10 megas y 8 segundos
            //bubble.BubbleSort(arr);
            //foreach (var b in arr)
            //{
            //    Console.WriteLine(b);
            //}




            var numQuery = 
                from num in arr
                where   num%2 != 0  && num > 80 && num < 90
                select num;

            var arreglo = bubble.BubbleSort(numQuery.ToArray());
            

            //foreach (var r in numQuery)
            //{

            //    Console.WriteLine(r);
            //}

            foreach (var r in arreglo)
            {

                Console.WriteLine(r);
            }


            //var searchParam = "2024-02-";

            ////var stringQuery =
            ////    from cadena in datos.CommonNames()
            ////    where cadena.Contains(searchParam) 
            ////    select cadena;

            //var dateQuery =
            //    from chain in datos.UnionFechas()
            //    where chain.Key.Contains(searchParam) || chain.Value.Contains("Valentina")
            //    select chain;

            //foreach (var consulta in dateQuery)
            //{
            //    Console.WriteLine(consulta);
            //}

            //foreach (var a in datos.UnionFechas())
            //{
            //    Console.WriteLine(a);
            //}



            Console.ReadLine();
        }


    }
}


