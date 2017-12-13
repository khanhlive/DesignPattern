using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatern.Builder
{
    public class RobotBuildable: IRobotBuildable
    {
        protected List<int> actions;
        public void LoadActions(List<int> actions)
        {
            this.actions = actions;
        }
        public void Go()
        {
            foreach (var action in actions)
            {
                switch (action)
                {
                    case 1:
                        this.Start();
                        break;
                    case 2:
                        this.GetParts();
                        break;
                    case 3:
                        this.Assemble();
                        break;
                    case 4:
                        this.Test();
                        break;
                    case 5:
                        this.Stop();
                        break;
                }
            }
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
    }
}
