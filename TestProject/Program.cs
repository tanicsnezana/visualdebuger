using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's create function y = 5x^2 - 4x + 2
            Function f = new Function();

            f.Parameter.Add(new FunctionParameter('+', 5, 2));
            f.Parameter.Add(new FunctionParameter('-', 4, 1));
            f.Parameter.Add(new FunctionParameter('+', 2, 0));

            //Let's create function y = 2x
             Function f2 = new Function();

            f2.Parameter.Add(new FunctionParameter('+', 2, 1));

            Console.WriteLine("The End :)");
        }
    }
}
