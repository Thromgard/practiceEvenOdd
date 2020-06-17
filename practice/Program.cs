using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer : ");
            var ans = Console.ReadLine();
            var nbr = Convert.ToInt32(ans);
            if (nbr % 2 == 0) {
                Console.WriteLine($"The number {nbr} is even");
            } else
            {
                Console.WriteLine($"The number {nbr} is odd");
            }
        }
    }
}
