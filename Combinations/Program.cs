namespace Combinations
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;

            for (int i = 0; i < number + 1; i++)
            {
                for (int j = 0; j < number + 1; j++)
                {
                    for (int k = 0; k < number + 1; k++)
                    {
                        if (i + j + k == number)
                        {
                            combinationsCounter++;
                        }
                    }
                }
            }

            Console.WriteLine(combinationsCounter);
        }
    }
}
