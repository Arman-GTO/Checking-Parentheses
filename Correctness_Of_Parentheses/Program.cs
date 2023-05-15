using System;
using System.Collections.Generic;

namespace Correctness_Of_Parentheses
{
    internal class Program
    {
        static bool? CheckParentheses(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if (c == '(')
                    stack.Push('.'); // Open Paretheses mean Push to the Stack

                else if (c == ')')
                {
                    if (stack.Count == 0)
                        return false;
                    stack.Pop(); // Close Paretheses mean Pop from the Stack
                }
                else
                    return null;
            }
            return stack.Count == 0; // Check if all open Parentheses are Closed
        }

        static void Main()
        {
            while (true)
            {
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("  Please enter your string of parentheses: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string input = Console.ReadLine(); // Gettin input String of Parentheses
                Console.ForegroundColor = ConsoleColor.Blue;

                bool? isCorrect = CheckParentheses(input);
                if (isCorrect == null)
                    Console.Write("  Invalid input! Enter a phrase including only open or close parentheses e.g. (())\n");
                else if (isCorrect == true)
                    Console.WriteLine("    Nice");
                else
                    Console.WriteLine("    What The Hell");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n  R: restart   |   ESC: exit\n");
                Console.CursorVisible = false;
                while (true)
                {
                    bool flag = false;
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.R:
                            Console.Clear();
                            flag = true;
                            break;
                        case ConsoleKey.Escape:
                            return;
                        default:
                            Console.SetCursorPosition(0, Console.CursorTop);
                            Console.Write(' ');
                            Console.SetCursorPosition(0, Console.CursorTop);
                            break;
                    }
                    if (flag) break;
                }
            }
        }
    }
}
