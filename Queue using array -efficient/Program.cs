using System;

namespace Queue_using_array__efficient
{
    class Queue1
    {
        public int front1;
        public int rear1;
        public int size;
        int capacity;
        int[] array;

        public Queue1(int capacity)
        {
            this.capacity = capacity;
            front1 = this.size = 0;
            rear1 = capacity - 1;
            array = new int[capacity];
        }


        bool isFull(Queue1 queue)
        {
            return (queue.size == queue.capacity);
        }


        bool isEmpty(Queue1 queue)
        {
            return (queue.size == 0);
        }


        void enqueue(int item)
        {
            if (isFull(this))
                return;
            rear1 = (rear1 + 1) % capacity;
            array[rear1] = item;
            this.size = this.size + 1;

        }

        int dequeue()
        {
            if (isEmpty(this))
                return -1;

            int item = array[front1];
            front1 = (front1 + 1)
                        % this.capacity;
            size = size - 1;
            return item;
        }

        int front()
        {
            if (isEmpty(this))
                return -1;

            return array[front1];
        }

        int rear()
        {
            if (isEmpty(this))
                return -1;

            return array[rear1];
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
