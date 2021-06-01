using System;
using System.Collections.Generic;

namespace _155_MinStack
{
    public class MinStack
    {

        Stack<Int32> ms = null;
        Stack<Int32> axs = null;

        public MinStack()
        {
            ms = new Stack<Int32>();
            axs = new Stack<Int32>();
        }

        public void Push(int val)
        {
            if (ms.Count == 0)
            {
                ms.Push(val);
                axs.Push(val);
                return;
            }
            ms.Push(val);
            if (axs.Peek() >= ms.Peek())
            {
                axs.Push(val);
            }

        }

        public void Pop()
        {
            if (ms.Peek() == axs.Peek())
            {
                axs.Pop();
            }
            ms.Pop();
        }

        public int Top()
        {
            return ms.Peek();
        }

        public int GetMin()
        {
            return axs.Peek();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
