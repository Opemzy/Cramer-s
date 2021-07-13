using System;

namespace Cramer_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for each variable");//asks the user to input values for each variable
            int a,b,c,d,e,f;//declare the variables a,b,c,d,e,f
            a = Convert.ToInt32(Console.ReadLine());//initialize the variable a
            b = Convert.ToInt32(Console.ReadLine());//initialize the variable b
            c = Convert.ToInt32(Console.ReadLine());//initialize the variable c
            d = Convert.ToInt32(Console.ReadLine());//initialize the variable d
            e = Convert.ToInt32(Console.ReadLine());//initialize the variable e
            f = Convert.ToInt32(Console.ReadLine());//initialize the variable f

            double g = (a*d) - (c*b);//calculation for Determinant
            double h = (e*d) - (b*f);//calculation for determinant x
            double i = (a*f) - (e*c);//calculation for determinant y

            double x = h/g;//calculation for x
            double y = i/g;//calculation for y
            if (g == 0)
            {
                System.Console.WriteLine("The equation has no solution");
            }
            else
            {
                Console.WriteLine("x = " + x);
                System.Console.WriteLine("y = " + y);
            }
        }
    }
}
