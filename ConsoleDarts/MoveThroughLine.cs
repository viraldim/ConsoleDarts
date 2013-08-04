using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    class MoveThroughLine
    {
        private int x;
        private int y = 0;
        private Line ruler;
        private string content;
        private bool isGoingRight = true;

        public int Y
        {
            get 
            {
                return this.x;
            }
        }

        public MoveThroughLine(int x, string content)
        {
            this.x = x;
            this.content = content;
            this.ruler = LineTypes.AllLines[x];
        }

        public void Drow()
        {
            Console.SetCursorPosition(0, x);
            foreach (var dot in ruler.Dots)
            {
                dot.Content = "  ";
            }
            ruler.Dots[y].Content = "<>";
            ruler.Drow();
        }

        public void Move()
        {
            if (y < Console.WindowWidth-2 && isGoingRight)
            {
                y += 2;
            }
            else
            {
                isGoingRight = false;
            }

            if (y > 2 && !isGoingRight)
            {
                y -= 2;
            }
            else
            {
                isGoingRight = true;
            }
        }
    }
}
