using System;
namespace practicas
{
    class Pronostico : Main
    {
            
        private int Premonicion()
        {
            var random = new Random();
            int valor = random.Next(0,10);
            return valor;
        }

        public void SuerteSemana()
        {
            switch (Premonicion())
            {
                case 1:
                    Console.WriteLine("Buena suerte");
                    break;
                case 6:
                    Console.WriteLine("Encontraras al amor de tu vida");
                    break;
                case 2:
                    Console.WriteLine("Tendras mucho delicioso");
                    break;
                case 9:
                    Console.WriteLine("tendras mucho dinero");
                    break;
                default:
                    Console.WriteLine("sigue participando");
                    break;
            }
        }
    }
}
