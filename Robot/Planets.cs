using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public enum PlanetEnum { Earth, Mars, Mercury }
    internal class Planets
    {
        bool containsLife = false;
        PlanetEnum planetType;
        public Planets(PlanetEnum planetType)
        {
            this.planetType = planetType;
        }
        public bool ContainsLife
        {
            get 
            {
               return containsLife;
            }
            set
            {
                containsLife = value;
            }
        }
    }
}
