using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    public class DotTypes
    {
        public static readonly List<Dot> AllDots = null;
        protected IList<Dot> dots;

        static DotTypes()
        {
            AllDots = new List<Dot>()
            {
                new Dot(0, ConsoleColor.Black),
                new Dot(1, ConsoleColor.White),
                new Dot(2, ConsoleColor.Green),
                new Dot(3, ConsoleColor.Red),
                new Dot(4, ConsoleColor.Green),
                new Dot(5, ConsoleColor.White),
                new Dot(6, ConsoleColor.Red),
                new Dot(7, ConsoleColor.Green),
                new Dot(8, ConsoleColor.Red),
                new Dot(9, ConsoleColor.White),
                new Dot(10, ConsoleColor.Red)
            };
        }
        public DotTypes()
        {
            this.dots = new List<Dot>();
        }

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

        //public DotTypes(IEnumerable<Dot> dotList)
        //    : this()
        //{
        //    foreach (var dot in dotList)
        //    {
        //        this.dots.Add(dot);
        //    }
        //}

        //public Dot this[int index]
        //{
        //    get
        //    {
        //        return this.dots[index];
        //    }
        //    set
        //    {
        //        this.dots[index] = value;
        //    }
        //}
    }
}
