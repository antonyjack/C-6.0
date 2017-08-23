using System;
using System.Linq;

namespace Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "James";
            Console.WriteLine($"Name is {Name}");

            int[] Ranks = new int[]{3, 4, 5, 6};
            Console.WriteLine($"{Ranks.Any()}");

            string Message = $@"Name is {Name}.
             Last rank is {Ranks.FirstOrDefault()}";

            Console.WriteLine(Message);
        }
    }
}
