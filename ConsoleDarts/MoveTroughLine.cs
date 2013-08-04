using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    class MoveThroughLine : GameObject, ICountable
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
                return this.y;
            }
        }

        public MoveThroughLine(int x, string content)
        {
            this.x = x;
            this.content = content;
            this.ruler = LineTypes.AllLines[x];
        }

        public override void Draw()
        {
            Console.SetCursorPosition(0, x);
            foreach (var dot in ruler.Dots)
            {
                dot.Content = Dot.ContentToString(Strings.emptyString);
            }
            ruler.Dots[y].Content = content;
            ruler.Draw();
        }

        public override void Move()
        {
            if (isGoingRight)
            {
                if (y < Console.WindowWidth / 2 - 1)
                {
                    y++;
                }
                else
                {
                    isGoingRight = false;   
                }
            }

            if (!isGoingRight)
            {
                if (y > 0)
                {
                    y--;
                }
                else
                {
                    isGoingRight = true;
                }
            }
        }

        public int[] Count()
        {
            int[] point = new int[2];
            point[0] = ruler.Dots[y].Level;
            point[1] =  ruler.Dots[y].X;
            return point;
        }
    }
}