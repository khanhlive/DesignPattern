using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Builder
{
    public class AutomotiveRobotBuilder : RobotBuilder
    {
        public AutomotiveRobotBuilder()
        {
            this.robot = new AutomotiveRobotBuildable();
            this.actions = new List<int>();
        }
    }
}
