using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    /// <summary>
    /// base klasse for dyr i zoo
    /// </summary>
    public abstract class Dyr
    {
        public string Navn { get; }
        public double Vægt { get; }
        public string Køn { get; }

        /// <summary>
        /// default constructor
        /// </summary>


        /// <summary>
        /// cosntructor som tager dyrenavn, vægt og køn som parameter
        /// </summary>
        /// <param name="navn">navnet på typen af dyr</param>
        public Dyr(string navn, double vægt, string køn)
        {
            this.Navn = navn;
            this.Vægt = vægt;
            this.Køn = køn;
        }

        public override string ToString()
        {
            return $"Her er en {Navn}. Den vejer {Vægt} kg og er {Køn}.";
        }
    }
}
