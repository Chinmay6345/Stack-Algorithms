using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_area_in_a_rectangle
{
    public static class AppHelper
    {
        public static int LargestRectangleUnderSkyline(List<int> buildings)
        {
            Int32 maxArea = 0;
            Stack<Int32> stack = new Stack<Int32>();
            buildings.Add(0);
            List<Int32> ext = new List<Int32>(buildings);
            for (Int32 i = 0; i < ext.Count; i++)
            {
                Int32 height = ext[i];
                while (stack.Count != 0 && ext[stack.Peek()] >= height)
                {
                    Int32 pHeight = ext[stack.Pop()];
                    Int32 width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                    maxArea = Math.Max(maxArea, (width * pHeight));
                }
                stack.Push(i);
            }
            return maxArea;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 1, 3, 3, 2, 4, 1, 5, 3, 2 };
            Console.WriteLine(AppHelper.LargestRectangleUnderSkyline(arr.ToList()));
            Console.ReadLine();
        }
    }
}
