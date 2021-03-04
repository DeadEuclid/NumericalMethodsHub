using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DustInTheWind.ConsoleTools.TabularData;
using MathExtentions;

namespace ConsoleTest
{
    class Program
    {
        static NumericalMethods.Expression expression;
        
        static void Main(string[] args)
        {
            expression = Expression;
            var metods = new NumericalMethods();
            metods.EulersMethod(Expression,1,2,1,5,0);
            

        }
        static double Expression(double x, double y)
        {

            return (1 + x * y) / Math.Pow(x, 2);
        }
    }
}
