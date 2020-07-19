namespace Building
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countFloors = int.Parse(Console.ReadLine());
            int roomsInFloor = int.Parse(Console.ReadLine());

            for (int i = countFloors; i >= 1 ; i--)
            {
                string typeRoom;
                if (i == countFloors)
                {
                    typeRoom = "L";
                }
                else if (i % 2 == 0)
                {
                    typeRoom = "O";
                }
                else
                {
                    typeRoom = "A";
                }

                for (int num = 0; num < roomsInFloor; num++)
                {
                    Console.Write($"{typeRoom}{i}{num} ");
                }

                Console.WriteLine();
            }
        }
    }
}
