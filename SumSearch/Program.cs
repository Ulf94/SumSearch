using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var searcher = new SumSearchC();
            var number = new List<int>() { 10,15,3,7};
            var k = 17;
            Console.WriteLine(searcher.IsSumExist(number, k));

            Console.ReadKey();  
        }
    }
}
