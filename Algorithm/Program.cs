using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm alg = new Algorithm();
            Console.WriteLine(alg.chunkArrayInGroups(new string[] { "a", "b", "c", "d", "e"}, 2));
        }
    }
}
