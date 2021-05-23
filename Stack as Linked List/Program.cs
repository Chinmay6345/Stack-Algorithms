using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_as_Linked_List
{
    public class Node
    {
        public Node next;
        public Int32 data;

        public Node(Int32 val)
        {
            this.data = val;
            this.next = null;
        }
    }

    public class MyStack
    {
        public Node head;
        public Int32 size;

        public MyStack()
        {
            head = null;
            size = 0;
        }

        public void Push(Int32 data)
        {
            Node temp = new Node(data);
            temp.next = head;
            head = temp;
            size = size + 1;
        }

        public void Pop()
        {
            if(head==null)
            {
                Console.WriteLine("Stack empty");
                return;
            }
            int res = head.data;
            Console.WriteLine(res+ " ");
            Node p = head;
            head = head.next;
            p = null;
            size = size - 1;
        }

        public void Peek()
        {
            if(head==null)
            {
                Console.WriteLine("Stack empty");
                return;
            }
            Console.WriteLine("Peek element " + head.data);
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        public void Size()
        {
            Console.WriteLine("Size " + size);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStack s=new MyStack();
            s.Push(5);
            s.Push(10);
            s.Push(20);
            s.Pop();
            s.Size();
            s.Peek();
            s.IsEmpty();
            Console.ReadLine();
        }
    }
}
