using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Builder
{
    public class CookieRobotBuilder : RobotBuilder
    {
        public CookieRobotBuilder()
        {
            this.robot = new CookieRobotBuildable();
            this.actions = new List<int>();
        }
        
    }
}
