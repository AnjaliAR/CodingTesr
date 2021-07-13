using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <=a ; i=i+2)
            {
                Console.WriteLine(i);
            }
          


        }

    }
}
