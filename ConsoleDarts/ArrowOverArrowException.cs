using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    class ArrowOverArrowException : ApplicationException
    {
        public ArrowOverArrowException(string msg)
            : base(msg)
        {
        }
    }
}
