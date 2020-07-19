namespace Trip
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                double price = double.Parse(Console.ReadLine());

                while (true)
                {
                    price -= double.Parse(Console.ReadLine());

                    if (price <= 0)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}
