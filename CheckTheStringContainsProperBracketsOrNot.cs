using System;

/*
 * Author : Devendra Parmar
 * Question : A given string contains the bracket characters '(', ')', '{', '}',
 * '<', ‘>', '[' and ']',
 * Write a C# programme to check the said string is valid or not. The input 
 * string will be valid when open brackets and closed brackets are same type 
 * of brackets.
 * Or
 * open brackets will be closed in proper order.
 */

namespace CheckTheStringContainsTheProperBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here : ");
            string brack = Console.ReadLine()!;

            Stack<char> ch = new Stack<char>();

            foreach (var item in brack.ToCharArray())
            {
                if (item == '(')
                {
                    ch.Push(')');
                }else if(item == '<')
                {
                    ch.Push('>');
                }
                else if (item == '[')
                {
                    ch.Push(']');
                }
                else if (item == '{')
                {
                    ch.Push('}');
                }
                else if(ch.Count == 0 || ch.Pop() != item)
                {
                    Console.WriteLine(false);
                }
            }
                
            Console.WriteLine(ch.Count == 0 ? true :  false);
        }
    }
}
