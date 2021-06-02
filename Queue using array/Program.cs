using System;

namespace Queue_using_array
{
    public class Queue_1
    {
        private Int32 size;
        private Int32 capacity;

        public Int32[] arr=null;

        public Queue_1(Int32 cap)
        {
            this.capacity = cap;
            arr = new Int32[capacity];
        }

        public Boolean IsFull()
        {
            return size == capacity;
        }

        public Boolean IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(Int32 item)
        {
            if(IsFull())
            {
                return;
            }
            arr[size] = item;
            size++;
        }

        public void IsEmpty(Int32 item)
        {
            if (IsFull())
            {
                return;
            }
            for (Int32 i = 0; i < size - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            size--;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
