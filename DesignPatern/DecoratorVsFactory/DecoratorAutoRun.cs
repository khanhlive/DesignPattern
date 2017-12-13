using DecoratorVsFactory.Decorator;
namespace DecoratorVsFactory
{
    public class DecoratorAutoRun : DesignPaternAutoRun.IAutoRun
    {
        public void Run()
        {
            Decorator.ComponentComputer computer = new Decorator.ConcreteComponent();
            Decorator.Disk disk = new Decorator.Disk();
            Decorator.Monitor monitor = new Decorator.Monitor();
            Decorator.CD cd = new CD();
            //computer
            
            System.Console.WriteLine(computer.Description());

            //computer + disk
            disk.SetComponent(computer);
            System.Console.WriteLine(disk.Description());

            //computer + disk + monitor
            monitor.SetComponent(disk);
            System.Console.WriteLine(monitor.Description());

            //computer + disk + monitor + CD
            cd.SetComponent(monitor);
            System.Console.WriteLine(cd.Description());
            //end
            System.Console.ReadLine();
        }
    }
}
