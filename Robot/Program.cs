using System;

namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiantKillerRobot robot = new GiantKillerRobot();
            
            robot.Target = new Target[] { new Target(TargetEnum.Animal), new Target( TargetEnum.Human) };
            
            Planets earth = new Planets(PlanetEnum.Earth);

            robot.Planet = earth;

            while (robot.Active && earth.ContainsLife)
            {
                if (robot.CurrentTarget.IsAlive)
                    robot.FireLaserAt(robot.CurrentTarget);
                else
                    robot.AcquireNextTarget();
            }
        }
    }
}
