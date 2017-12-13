using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorVsFactory.Decorator
{
    
    public abstract class ComponentComputer
    {
        public abstract string Description();
    }

    public class ConcreteComponent : ComponentComputer
    {
        public override string Description()
        {
            return "Computer";
        }
    }

    public abstract class DecoratorComponent : ComponentComputer
    {
        protected ComponentComputer computer;
        public override string Description()
        {
            if (this.computer != null)
            {
                return this.computer.Description();
            }
            else return string.Empty;
        }

        public void SetComponent(ComponentComputer computer)
        {
            this.computer = computer;
        }
    }

    public class Disk: DecoratorComponent
    {
        public Disk()
        {

        }
        public Disk(ComponentComputer computer)
        {
            this.computer = computer;
        }

        public override string Description()
        {
            return base.Description() + " and a disk";
        }
    }

    public class Monitor : DecoratorComponent
    {
        public Monitor()
        {

        }

        public Monitor(ComponentComputer computer)
        {
            this.computer = computer;
        }
        public override string Description()
        {
            return base.Description() + " and a monitor";
        }
    }

    public class CD: DecoratorComponent
    {
        public CD()
        {

        }
        public CD(ComponentComputer computer)
        {
            this.computer = computer;
        }
        public override string Description()
        {
            return base.Description() + " and a CD";
        }
    }
}
