using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _844_Backspace_String_Compare
{
    public static class AppHelper
    {
        public static bool AreEqual(String s, String t)
        {
            Stack<Char> s1 = new Stack<Char>();
            Stack<Char> s2 = new Stack<Char>();

            foreach (Char c in s)
            {
                if (c != '#')
                    s1.Push(c);
                else if (s1.Count != 0)
                    s1.Pop();
            }

            foreach (Char c in t)
            {
                if (c != '#')
                    s2.Push(c);
                else if (s2.Count != 0)
                    s2.Pop();
            }
            return s1.SequenceEqual(s2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool isvalid=  AppHelper.AreEqual("a##c","#a#c");
            Console.ReadLine();
        }
    }
}
