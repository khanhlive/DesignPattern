using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Template
{
    public class CookieRobot : RobotTemplate
    {
        private string name;
        public CookieRobot(string name)
        {
            this.name = name;
        }
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

        public override bool TestOK()
        {
            return false;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
