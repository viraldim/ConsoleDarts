using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    public class Dot : IDrawable
    {
        private int x;
        private int y;
        private ConsoleColor color;
        private const int width = 2;
        private string content;
        private int level;

        public string Content 
        {
            set
            {
                this.content = value;
            }
        }

        public int Level
        {
            get 
            {
                return this.level;
            }
        }

        public int X
        {
            get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }
        }

        public ConsoleColor Color
        {
            get { return this.color; }
        }

        public Dot(int x, int y, int level, ConsoleColor color, string content)
        {
            this.x = x;
            this.y = y;
            this.level = level;
            this.color = color;
            this.content = content;
        }

        public Dot(int x, int y, int level, ConsoleColor color)
            : this(x, y, level, color, Dot.ContentToString(Strings.emptyString))
        { 
        }

        public Dot(int level, ConsoleColor color)
            : this(0, 0, level, color, Dot.ContentToString(Strings.emptyString))
        { 
        }

        public static string ContentToString(Strings strings)
        {
            string content = null;
            switch (strings)
            {
                case Strings.emptyString:
                    content = "  ";
                    break;
                case Strings.lineString:
                    content = "==";
                    break;
                case Strings.shotString:
                    content = "<>";
                    break;
            }
            return content;
        }

        public void Draw()
        {
            Console.BackgroundColor = color;
            Console.Write(content);
        }

        public override string ToString()
        {
            Console.BackgroundColor = color;
            return content;
        }
    }
}
