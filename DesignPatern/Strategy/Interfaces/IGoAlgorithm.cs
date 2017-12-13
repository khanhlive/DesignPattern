namespace Strategy.Interfaces
{
    public interface IGoAlgorithm
    {
        void Go();
    }

    public class GoByDrivingAlgorithm : IGoAlgorithm
    {
        public void Go()
        {
            System.Console.WriteLine("Now, I'm driving");
        }
    }
    public class GoByFlyingAlgorithm : IGoAlgorithm
    {
        public void Go()
        {
            System.Console.WriteLine("Now, I'm flying at 200 mph");
        }
    }
    public class GoByFlyingFastAlgorithm : IGoAlgorithm
    {
        public void Go()
        {
            System.Console.WriteLine("Now, I'm flying fast at 1000 mph");
        }
    }
}
