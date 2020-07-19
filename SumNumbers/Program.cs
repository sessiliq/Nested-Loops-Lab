namespace SumNumbers
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int beginNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int result = int.Parse(Console.ReadLine());
            int combinationNumber = 0;

            for (int i = beginNumber; i < endNumber + 1; i++)
            {
                for (int j = beginNumber; j < endNumber + 1; j++)
                {
                    combinationNumber++;

                    if (i + j == result)
                    {
                        Console.WriteLine($"Combination N:{combinationNumber} ({i} + {j} = {result})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinationNumber} combinations - neither equals {result}");
        }
    }
}
