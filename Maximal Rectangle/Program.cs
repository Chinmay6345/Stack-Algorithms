using System;
using System.Collections.Generic;

namespace Maximal_Rectangle
{
    public static class AppHelper
    {
        public static int largestHist(List<int> buildings)
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

        public static int maxRectangle(int R, int C, int [][] mat)
        {
            int res = largestHist(R, C, mat[0]);

            for (int i = 1; i < R; i++)
            {

                for (int j = 0; j < C; j++)

                    if (mat[i][j] == 1)
                        mat[i][j] += mat[i - 1][j];

                res = Math.Max(res, largestHist(mat[i]));
            }
            return res;
        }

        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
