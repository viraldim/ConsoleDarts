using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    struct ShotsLocation
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ShotsLocation(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }
    }
}
