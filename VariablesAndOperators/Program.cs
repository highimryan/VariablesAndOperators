using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ValueTuple;

namespace VariablesAndOperators
{
    class Program
    {
        static (int, string) Method()
        {
            return (17, "cats");
        }

        static void Main(string[] args)
        {
            var myTuple = Method();

            (var i, var s) = myTuple;

            Console.WriteLine($"{i} {myTuple.cats}");
        }
    }
}
