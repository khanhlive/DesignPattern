using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Builder
{
    public class BuilderAutoRun : DesignPaternAutoRun.IAutoRun
    {
        public void Run()
        {
            RobotBuilder robotBuilder;
            RobotBuildable robot;
            string response = "a";
            Console.WriteLine("Create Cookie robot [c], Automotive robot [a]?");
            response = Console.ReadLine();
            if (response.Equals("c"))
            {
                robotBuilder = new CookieRobotBuilder();
            }
            else
            {
                robotBuilder = new AutomotiveRobotBuilder();
            }
            ////Start process
            robotBuilder.AddStart();
            robotBuilder.AddGetParts();
            robotBuilder.AddAssemble();
            robotBuilder.AddTest();
            robotBuilder.AddStop();

            robot = robotBuilder.GetRobot();
            robot.Go();
            Console.ReadLine();
        }
    }
}
