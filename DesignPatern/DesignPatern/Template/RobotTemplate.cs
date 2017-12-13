using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Template
{
    public abstract class RobotTemplate
    {
        public void Go()
        {
            this.Start();
            this.GetParts();
            this.Assemble();
            if (this.TestOK())
            {
                this.Test();
            }
            this.Stop();
        }
        public virtual void Start()
        {
            System.Console.WriteLine("Start...");
        }
        public virtual void GetParts()
        {
            System.Console.WriteLine("Get parts...");
        }
        public virtual void Assemble()
        {
            System.Console.WriteLine("Assembling");
        }
        public virtual void Test()
        {
            System.Console.WriteLine("Testing...");
        }
        public virtual void Stop()
        {
            System.Console.WriteLine("Stop...");
        }
        public virtual bool TestOK()
        {
            return true;
        }
    }
    
}
