using System;
namespace LinQ
{
    class Burbuja
    {
       
        public string[]  BubbleSort(string[] input)
        {
            for (var j = 0; j<input.Length; j++)
            {
                for (int i = 0; i < input.Length-1-j; i++)
                {
                    var sort = string.CompareOrdinal(input[i], input[i + 1])<0;

                    if (sort)
                    {
                        var temp = input[i];
                        input[i] = input[i+1];
                        input[i+1] = temp;                        
                    }
                }
            }
            return input;
        }

        public int[] BubbleSort(int[] input)
        {
            int n = input.Length;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < (n - 1 - i); j++)
                {
                    var sort = input[j] > input[j + 1];
                    if (sort)
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
            return input;
        }
    }
}
