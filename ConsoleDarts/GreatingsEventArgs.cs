using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarts
{
    public class GreatingsEventArgs
    {
        public EventArgs e = null;
        public delegate void GreatingsEventHandler
            (GreatingsEventArgs b, EventArgs e);
        public event GreatingsEventHandler Greatings;

        public void Message(int score)
        {
            if (score >= 30)
            {
                if (Greatings != null)
                {
                    Greatings(this, e);
                } 
            }
        }
    }
}
