using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Flue : Insekt
    {
        public Flue(double vægt, string køn) : base("Flue", vægt, køn)
        {

        }
        public bool ErByttedyr()
        {
            return true;
        }
    }
}
