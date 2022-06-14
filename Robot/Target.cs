using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public enum TargetEnum {Animal, Human, Superhero, Alien, Robot }
    public class Target
    {
        int health = 0;
        TargetEnum targetType;
        bool isAlive = false;
        public Target(TargetEnum targetType)
        {
            this.targetType = targetType;
            health = 100;
            isAlive = true;
        }
        public int Health { get { return health; } set { health = value; } }
        public bool IsAlive
        {
            get
            {
                if (health>0)
                {
                    isAlive = true;
                    return isAlive;
                }
                else
                {
                    isAlive=false;
                    return isAlive;
                }
            } set { isAlive = value; }
        }
    }
}
