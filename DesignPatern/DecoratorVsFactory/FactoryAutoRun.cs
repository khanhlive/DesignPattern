namespace DecoratorVsFactory
{
    public class FactoryAutoRun : DesignPaternAutoRun.IAutoRun
    {
        public void Run()
        {
            Factory.ConnectionFactory connectionFactory = new Factory.NormalConnectionFactory(Factory.ConnectionType.MySql);
            Factory.Connection connection = connectionFactory.CreateConnection();
            System.Console.WriteLine("You're connecting with "+connection.Description());
            //secure
            connectionFactory = new Factory.SecureConnectionFactory(Factory.ConnectionType.Oracle);
            connection = connectionFactory.CreateConnection();
            System.Console.WriteLine("You're connecting with " + connection.Description());
            System.Console.ReadLine();
        }
    }
}
