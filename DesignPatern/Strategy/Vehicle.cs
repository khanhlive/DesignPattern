namespace Strategy
{
    public abstract class Vehicle
    {
        private Interfaces.IGoAlgorithm goAlgorithm;
        public Vehicle() { }
        public void SetAlgorithm(Interfaces.IGoAlgorithm algorithm)
        {
            this.goAlgorithm = algorithm;
        }

        public void Go()
        {
            this.goAlgorithm.Go();
        }
    }

    public class StreetRacer : Vehicle
    {
        public StreetRacer()
        {
            this.SetAlgorithm(new Interfaces.GoByDrivingAlgorithm());
        }

    }
    public class FormularOne : Vehicle
    {
        public FormularOne()
        {
            this.SetAlgorithm(new Interfaces.GoByDrivingAlgorithm());
        }

    }
    public class Helicopter : Vehicle
    {
        public Helicopter()
        {
            this.SetAlgorithm(new Interfaces.GoByFlyingAlgorithm());
        }

    }
    public class Jet : Vehicle
    {
        public Jet()
        {
            this.SetAlgorithm(new Interfaces.GoByFlyingFastAlgorithm());
        }

    }
}
