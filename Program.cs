using System;

namespace Prepare
{
    class Program
    {
        public static int EvenFibonnaci(int n)
        {
            int[] fibonnaci = new int[n];
            int evenSum = 0;
            int normalSum = 0; // optional for In the code comments leave the actual sum you found so we can compare whether you found the right answer.
       
            fibonnaci[0] = 0;
            fibonnaci[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonnaci[i] = fibonnaci[i - 1] + fibonnaci[i - 2];
                normalSum += fibonnaci[i]; // optional for the actual sum
                if (fibonnaci[i] % 2 == 0) // If number is even
                    evenSum += fibonnaci[i];
            }

            return evenSum; 
        }

        static void Main(string[] args) 
        {
            EvenFibonnaci(10);
        }
    }
}

