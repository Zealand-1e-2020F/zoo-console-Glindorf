using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Tiger : Pattedyr, IRovdyr
    {
        public Tiger(double vægt, string køn) : base("Tiger", vægt, køn)
        {

        }
        public bool ErRovdyr()
        {
            return true;
        }
    }
}
