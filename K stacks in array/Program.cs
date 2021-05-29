using System;
using System.Linq;

namespace K_stacks_in_array
{
    class KStacks
    {
        public Int32[] arr;
        public Int32[] top;
        public Int32[] next;
        public Int32 capacity = 0;
        public Int32 k = 0;
        public Int32 freeTop = 0;

        public KStacks(Int32 k1, Int32 n)
        {
            this.k = k1;
            this.capacity = n;
            this.arr = new Int32[n];
            this.top = new Int32[k];
            this.next = new Int32[capacity];

            this.top = Enumerable.Repeat(-1, k).ToArray<Int32>();
            for (Int32 y = 0; y < (capacity - 1); y++)
            {
                next[y] = y + 1;
            }
            next[capacity - 1] = -1;
        }

        public bool IsFull()
        {
            return freeTop == -1;
        }
        public bool isEmpty(int sn)
        {
            return (top[sn] == -1);
        }
        public void Push(int x, int sn)
        {
            if (IsFull())
            {
                Console.WriteLine("\nStack Overflow\n");
                return;
            }

            int i = freeTop;
            freeTop = next[i];
            next[i] = top[sn];
            top[sn] = i;
            arr[i] = x;
        }

        public int Pop(int sn)
        {
            if (isEmpty(sn))
            {
                Console.WriteLine("\nStack Underflow\n");
                return -1;
            }

            int i = top[sn];
            top[sn] = next[i];
            next[i] = freeTop;
            freeTop = i;
            return arr[i];
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            int k = 3, n = 10;
            KStacks ks = new KStacks(k, n);

            ks.Push(15, 2);
            ks.Push(45, 2);

            ks.Push(17, 1);
            ks.Push(49, 1);
            ks.Push(39, 1);

            ks.Push(11, 0);
            ks.Push(9, 0);
            ks.Push(7, 0);

            Console.WriteLine("Popped element from stack 2 is " + ks.Pop(2));
            Console.WriteLine("Popped element from stack 1 is " + ks.Pop(1));
            Console.WriteLine("Popped element from stack 0 is " + ks.Pop(0));
            Console.ReadLine();
        }
    }
}
