﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Template
{
    public class AutomotiveRobot : RobotTemplate
    {
        private string name;
        public AutomotiveRobot(string name)
        {
            this.name = name;
        }
        public override void GetParts()
        {
            System.Console.WriteLine("Get a carburetor...");
        }
        public override void Test()
        {
            System.Console.WriteLine("Reving the engine...");
        }
        public override void Assemble()
        {
            System.Console.WriteLine("Installing the carburetor...");
        }

        public string GetName()
        {
            return this.name;
        }
        
    }
}
