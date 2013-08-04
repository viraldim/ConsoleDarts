using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    public abstract class GameObject : IMovable , IDrawable
    {
        public abstract void Draw();

        public abstract void Move();
    }
}
