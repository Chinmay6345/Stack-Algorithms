using System;
using System.Collections.Generic;

namespace Generate_numbers_with_given_digits
{
    public static class AppHelper
    {
        public static void GenerateNumbers(Int32 n)
        {
            Queue<String> q = new Queue<String>();
            q.Enqueue("5");
            q.Enqueue("6");
            for(Int32 i=0;i<n;i++)
            {
                String curr = q.Peek();
                Console.Write(q.Dequeue() + " ");
                q.Enqueue(curr + "5");
                q.Enqueue(curr + "6");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AppHelper.GenerateNumbers(5);
            Console.ReadLine();
        }
    }
}
