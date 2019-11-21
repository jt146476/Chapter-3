using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a door 1, 2, or 3");
            int userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == 1)
            {
                Console.WriteLine("a bomb");
                Console.WriteLine("");
            }

        }
    }
}
