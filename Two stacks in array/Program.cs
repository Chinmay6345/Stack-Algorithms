using System;

namespace Two_stacks_in_array
{
    class TwoStacks
    {
        Int32 capacity;
        Int32 top1;
        Int32 top2;
        Int32[] arr;

        public TwoStacks(Int32 n)
        {
            this.arr = new Int32[n];
            this.top1 = -1;
            this.top2 = capacity;
            this.capacity = n;
        }

        public void Push1(Int32 x)
        {
            if (top1 < top2 - 1)
            {
                arr[top1] = x;
                top1++;
            }
        }

        public void Push2(Int32 x)
        {
            if (top1 < top2 - 1)
            {
                arr[top2] = x;
                top2--;
            }
        }

        public void Pop1()
        {
            if (top1 != -1)
            {
                Int32 res = arr[top1];
                top1--;
            }
        }

        public void Pop2()
        {
            if (top2 < capacity)
            {
                int x = arr[top2];
                top2++;

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
