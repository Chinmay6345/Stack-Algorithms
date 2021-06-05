using System;

namespace Array_using_Dequeue
{
    class Dequeue
    {
        Int32[] arr = null;
        Int32 capacity;
        Int32 size, front;

        public Dequeue(Int32 c)
        {
            capacity = c;
            arr = new Int32[capacity];
            front = 0;
            size = 0;
        }

        public Boolean IsFull()
        {
            return size == capacity;
        }

        public Boolean IsEmpty()
        {
            return size == 0;
        }

        void deleteFront()
        {
            if (IsEmpty()) return;
            front= (front+1)% capacity;
            size--;
        }
        void deleteRear()
        {
            if (IsEmpty()) return;
            size--;
        }
        int getFront()
        {
            if (IsEmpty()) return -1;
            else return front;
        }
        int getRear()
        {
            if (IsEmpty()) return -1;
            else return (front+size-1)%capacity;
        }
        void insertFront(Int32 x)
        {
            if (IsFull()) return ;
            int front1= (front+capacity-1)% capacity;
            arr[front1] = x;
            size++;
        }
        void insertRear(Int32 x)
        {
            if (IsFull()) return ;
            int newrear= (front+size)% capacity;
            arr[newrear] = x;
            size++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
