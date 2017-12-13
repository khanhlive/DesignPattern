namespace DesignPaternAutoRun
{
    public class AutoRunFactory
    {
        protected AutoRunModule runModule;
        public void CreateModule(AutoRunModule autoRunModule) {
             
        }
    }

    public enum AutoRunModule
    {
        Strategy=1,
        Decorator=2,
        Factory=3
    }
}
