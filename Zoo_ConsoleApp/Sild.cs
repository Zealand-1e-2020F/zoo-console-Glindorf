using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Sild : Fisk
    {
        public Sild(double vægt, string køn, double længde) : base("Sild", vægt, køn, længde)
        {

        }
        public bool ErByttedyr()
        {
            return true;
        }
    }
}
