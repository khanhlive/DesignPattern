using DesignPatern.Template;

namespace DesignPatern
{
    class Program
    {
        static void Main(string[] args)
        {
            //// strategy
            //DesignPaternAutoRun.IAutoRun strategyRun = new Strategy.StrategyAutoRun();
            //strategyRun.Run();

            /////decorator
            //DesignPaternAutoRun.IAutoRun decoratorRun = new DecoratorVsFactory.DecoratorAutoRun();
            //decoratorRun.Run();

            ////factory
            //DesignPaternAutoRun.IAutoRun factory = new DecoratorVsFactory.FactoryAutoRun();
            //factory.Run();

            /////singleton
            //DesignPaternAutoRun.IAutoRun singleton = new Singleton.SingletonAutoRun();
            //singleton.Run();
            ////flyweight
            //DesignPaternAutoRun.IAutoRun flyweight = new Flyweight.FlyweightAutoRun();
            //flyweight.Run();


            //adapter
            DesignPaternAutoRun.IAutoRun adapterRun = new Adapter.AdapterAutoRun();
            adapterRun.Run();
            
        }
    }
    
}
