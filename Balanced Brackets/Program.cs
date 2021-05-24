using System;
using System.Collections.Generic;

namespace Balanced_Brackets
{
    public static class AppHelper
    {
        public static Boolean isMatching(Char a, Char b)
        {
            return ((a == '(' && b == ')') || (a == '[' && b == ']') || (a == '{' && b == '}'));
        }

        public static Boolean IsBalanced(String str)
        {
            Stack<Char> stack = new Stack<Char>();
            for (Int32 i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '{' || str[i] == '[')
                {
                    stack.Push(str[i]);
                }
                else if (str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    if (stack.Count == 0)
                        return false;
                    else if (isMatching(stack.Peek(), str[i]))
                        stack.Pop();
                    else
                        return false;
                }
            }
            return stack.Count == 0 ? true : false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String str = "([])(){}(())()()";
            Console.WriteLine(AppHelper.IsBalanced(str));
            Console.ReadLine();
        }
    }
}
