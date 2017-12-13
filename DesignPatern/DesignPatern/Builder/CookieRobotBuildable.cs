using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Builder
{
    public class CookieRobotBuildable : RobotBuildable
    {

        public override void GetParts()
        {
            System.Console.WriteLine("Getting flour ad sugar...");
        }
        public override void Test()
        {
            System.Console.WriteLine("Crunching a cookie...");
        }
        public override void Assemble()
        {
            System.Console.WriteLine("Baking a cookie...");
        }
    }
}
