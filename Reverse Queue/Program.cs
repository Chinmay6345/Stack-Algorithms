using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Queue
{
    public static class AppHelper
    {
        public static void Reverse(ref Queue<Int32>q)
        {
            if(!q.Any())
            {
                return;
            }
            Int32 x = q.Peek();
            q.Dequeue();
            Reverse(ref q);
            q.Enqueue(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Int32> q = new Queue<Int32>(new Int32[] { 1, 2, 3, 4, 5 });
            AppHelper.Reverse(ref q);
            Console.WriteLine(String.Join(" ",q.Select(g => g)));
            Console.ReadLine();
        }
    }
}
