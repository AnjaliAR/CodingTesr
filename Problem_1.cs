
using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation to perform on the 2 numbers: + or - or * or /");
            String operation= Console.ReadLine();
            CalCulator sq = new CalCulator();
           
            if(operation=="+")
                Console.WriteLine("The sum is"+sq.Add(a, b));
            if (operation == "*")
                Console.WriteLine("The product is:"+sq.Multiply(a, b));
            if (operation == "-")
                Console.WriteLine("the difference is"+sq.Subtract(a, b));
            if (operation == "/")
                Console.WriteLine("the quotient is"+sq.Division(a, b));
            
        }
    }
}
