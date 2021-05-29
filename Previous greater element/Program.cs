using System;
using System.Collections.Generic;

namespace Previous_greater_element
{
    public static class AppHelper
    {
        public static void StockSpan(Int32 [] arr,Int32 n)
        {
            Stack<Int32> stack = new Stack<Int32>();
            stack.Push(arr[0]);
            Console.Write("-1 ");
            for(Int32 i=1;i<n;i++)
            {
                while(stack.Count !=0 && stack.Peek()<=arr[i])
                {
                    stack.Pop();
                }
                Int32 span = stack.Count == 0 ? -1 : stack.Peek();
                Console.Write(span + " ");
                stack.Push(arr[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int [] arr={18,12,13,14,11,16};
            AppHelper.StockSpan(arr, arr.Length);
            Console.ReadLine();
        }
    }
}
