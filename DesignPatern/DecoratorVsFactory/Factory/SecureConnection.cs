namespace DecoratorVsFactory.Factory
{
    public class SecureOracleConnection : Connection
    {
        public override string Description()
        {
            return "Secure Oracle";
        }
    }
    public class SecureSqlServerConnection : Connection
    {
        public override string Description()
        {
            return "Secure Sql Server";
        }
    }
    public class SecureMySqlConnection : Connection
    {
        public override string Description()
        {
            return "Secure MySql";
        }
    }
}
