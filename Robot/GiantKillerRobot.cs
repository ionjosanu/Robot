using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    internal class GiantKillerRobot
    {
       public enum Intesity{Kill, Injure, Burn}
        bool active = false;
        int health = 0;
        Intesity eyeLaserIntesity;
        Target currentTarget;
        Target[] target;
        int nextTarget=1;
        Planets planet;
         public GiantKillerRobot()
        {
            active= true;
            health = 100;
        }
        public bool Active { get { return active; } }
        public int Health { get { return health; } set { health = value; } }
        public Intesity EyeLaserIntesity { get { return eyeLaserIntesity; } set { eyeLaserIntesity = value; } }
     
        List<Target> ListOfTargets = new List<Target>();
        public Target[] Target
        {
            set
            {
                target = value;
                foreach (var item in target)
                {
                    ListOfTargets.Add(item);
                } 
            } 
        }
        public Planets Planet { get { return planet; } set { planet = value; } }
        public Target CurrentTarget
        {
            set { currentTarget = value; }
            get
            {
                if (currentTarget==null)
                {
                    currentTarget = ListOfTargets[0];
                    return currentTarget;
                }
                else
                {
                    return currentTarget;
                }
            } 
        }
        public void FireLaserAt(Target target)
        {
            switch (eyeLaserIntesity)
            {
                case Intesity.Kill:
                    target.Health = 0;
                    break;
                case Intesity.Injure:
                    target.Health = Health-Health/2;
                    break;
                case Intesity.Burn:
                    target.Health = 0;
                    break;
                default:
                    Health = 0;
                    break;
            }
        }
        public void AcquireNextTarget()
        {
            if (nextTarget<ListOfTargets.Count)
            {
                CurrentTarget = ListOfTargets[nextTarget];
            }
            else
            {
                Console.WriteLine("There are no mor targets!");
                planet.ContainsLife = false;
            }
        }
    }
}
