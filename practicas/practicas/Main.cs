using System;

namespace practicas
{
    class Main
    {

        public int CoinToss()
        {
            var random = new Random();
            int toss = random.Next(-1, 1);
            return toss;
        }


        private string Result()
        {
            string result;
            if (CoinToss() == 1)
            {
                result = "águila";
            }
            else
            {
                result = "sol";
            }

            return result;
        }

        
        public void Contexto()
        {
            Console.WriteLine("Se va a lanzar una moneda 3 veces, si ganas 2 de 3 conseguiras un premio");
        }
        public string UserChoice()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Escoge entre águila o sol");
            Console.ForegroundColor = ConsoleColor.White;
            string userChoice = Console.ReadLine();
            return userChoice;
        }

        public void GameResult()
        {

            if (CoinTossRepeat()==2)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Gana el jugador");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Gana el ordenador");
            }
        }
       
        private int CoinTossRepeat()
        {
            int j = 0;
            for (int i = 1; i < 3; i++)
            {
                CoinToss();
                Result();
                if (Result().Equals(UserChoice()))
                {
                    j++;
                }
            }
            return j;
          
        }

    }
}
