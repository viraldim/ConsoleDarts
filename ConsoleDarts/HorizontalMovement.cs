using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    public class HorozontalMovement : GameObject
    {
        private int x;
        private Line ruler;
        private string content = Dot.ContentToString(Strings.lineString);
        private bool isGoingDown = true;

        public int X
        {
            get
            {
                return this.x;
            }
        }
        public HorozontalMovement(int x, Line ruler)
        {
            this.x = x;
            this.ruler = ruler;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(0, x);
            foreach (var dot in this.ruler.Dots)
            {
                dot.Content = Dot.ContentToString(Strings.lineString);
            }
            ruler.Draw();
        }

        public override void Move()
        {
            if (x + 2 < Console.WindowHeight && isGoingDown)
            {
                Console.SetCursorPosition(0, x);
                foreach (var dot in LineTypes.AllLines[x].Dots)
                {
                    dot.Content = Dot.ContentToString(Strings.emptyString);
                }
                LineTypes.AllLines[x].Draw();
                x++;
                this.ruler = LineTypes.AllLines[x];
            }
            else
            {
                isGoingDown = false;
            }

            if (x > 0 && !isGoingDown)
            {
                Console.SetCursorPosition(0, x);
                foreach (var dot in LineTypes.AllLines[x].Dots)
                {
                    dot.Content = Dot.ContentToString(Strings.emptyString);
                }
                LineTypes.AllLines[x].Draw();
                x--;
                this.ruler = LineTypes.AllLines[x];
            }
            else
            {
                isGoingDown = true;
            }
        }
    }
}
