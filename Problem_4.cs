using System;
using System.Collections.Generic;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of dictionary");
            int count = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> output = new Dictionary<int, int>();
            int[] a = new int[100];
            int count1;
            Console.WriteLine("Enter the array elements");
            for(int i = 0; i < count; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 1; i <=9; i++)
            {
                count1 = 0;
                for(int j = 0; j < count; j++) {
                    if (a[j] % i ==0) count1++;
                }
                output.Add(i, count1);

            }
            String s = new String("{");
            foreach (var tuple in output)
            {
                s = s + tuple.Key+":" + tuple.Value+",";
               // Console.WriteLine("," + tuple.Key + ":" + tuple.Value+"\t");
            }
            s = s.Remove(s.Length-1,1) + "}";
            Console.WriteLine(s);
           
        }
    }
}
