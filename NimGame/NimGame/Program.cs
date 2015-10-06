using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimGame
{
    class Program
    {
        static void Main(string[] args)
        {
            HashOfBoards hob = new HashOfBoards();
            System.Console.WriteLine(hob.ToString());
            System.Console.WriteLine(new Board(1, 2, 3).ToString());
        }
    }
}
