using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        const int POSITION = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder");
            DieRolled d=new DieRolled();
            d.playerRolledDie();
            Console.ReadLine();
        }
    }
}
