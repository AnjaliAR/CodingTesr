using System;

namespace program1
{
    class Program
    {
        static void Main()
        {
            int x;
            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the numbers are:");
            for(int i = 1; i <= x * 2; i++)
            {
                if(i % 2 == 1){ Console.WriteLine(i); }
            }

        }
    }
}
