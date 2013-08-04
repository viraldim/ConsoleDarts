using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    public static class ConsoleProcesses
    {
        public static Singleton Singleton
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void ConsoleSetter()
        {
            Singleton api = Singleton.Instance;
            api.Start();
        }

        public static void ColorSetter(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public static void PrintResult(int shots , int[] score)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("Your current score is: " + score[0] + new String(' ', 18) + "Shots: " + (3-shots));
            Console.SetCursorPosition(0, 0);
        }
    }
}
