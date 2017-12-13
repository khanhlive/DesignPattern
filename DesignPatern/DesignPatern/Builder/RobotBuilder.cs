using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Builder
{
    public class RobotBuilder : IRobotBuilder
    {
        protected RobotBuildable robot;

        protected List<int> actions;
       
        public void AddAssemble()
        {
            this.actions.Add(3);
        }

        public void AddGetParts()
        {
            this.actions.Add(2);
        }

        public void AddStart()
        {
            this.actions.Add(1);
        }

        public void AddStop()
        {
            this.actions.Add(5);
        }

        public void AddTest()
        {
            this.actions.Add(4);
        }

        public RobotBuildable GetRobot()
        {
            robot.LoadActions(this.actions);
            return this.robot;
        }
    }
}
