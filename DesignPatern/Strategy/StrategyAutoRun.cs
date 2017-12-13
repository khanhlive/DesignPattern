using System;
using System.Collections.Generic;

namespace Strategy
{
    public class StrategyAutoRun : DesignPaternAutoRun.IAutoRun
    {
        public void Run()
        {
            List<Strategy.Vehicle> list = new List<Strategy.Vehicle>();
            list.Add(new Strategy.StreetRacer());
            list.Add(new Strategy.FormularOne());
            list.Add(new Strategy.Helicopter());
            list.Add(new Strategy.Helicopter());
            list.Add(new Strategy.Jet());
            foreach (var item in list)
            {
                item.Go();
            }
            Console.ReadLine();

            Strategy.Jet jet = new Strategy.Jet();
            jet.SetAlgorithm(new Strategy.Interfaces.GoByDrivingAlgorithm());
            jet.Go();
            jet.SetAlgorithm(new Strategy.Interfaces.GoByFlyingAlgorithm());
            jet.Go();
            jet.SetAlgorithm(new Strategy.Interfaces.GoByFlyingFastAlgorithm());
            jet.Go();
            jet.SetAlgorithm(new Strategy.Interfaces.GoByDrivingAlgorithm());
            jet.Go();
            Console.ReadLine();
            
        }
    }
}
