using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    public class Line : IDrawable
    {
        public List<Dot> Dots{ get; set;}

        public Dot Dot
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Line(List<Dot> dots)
        {
            this.Dots = dots;
        }

        public void Draw()
        {
            foreach (var dot in Dots)
            {
                Console.Write(dot);
            }
        }
    }
}
