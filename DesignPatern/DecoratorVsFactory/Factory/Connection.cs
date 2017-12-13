namespace DecoratorVsFactory.Factory
{
    public abstract class Connection
    {
        public abstract string Description();
    }

    public class OracleConnection:Connection
    {
        public override string Description()
        {
            return "Oracle";
        }
    }
    public class SqlServerConnection : Connection
    {
        public override string Description()
        {
            return "Sql Server";
        }
    }
    public class MySqlConnection : Connection
    {
        public override string Description()
        {
            return "MySql";
        }
    }
}
