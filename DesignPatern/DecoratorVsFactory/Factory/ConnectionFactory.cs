namespace DecoratorVsFactory.Factory
{
    public class NormalConnectionFactory : ConnectionFactory
    {

        public NormalConnectionFactory() : base()
        {
        }
        public NormalConnectionFactory(ConnectionType connectionType) : base(connectionType)
        {
        }
        public override Connection CreateConnection()
        {
            switch (this.connectionType)
            {
                case ConnectionType.Oracle:
                    return new OracleConnection();
                case ConnectionType.SqlServer:
                    return new SqlServerConnection();
                case ConnectionType.MySql:
                    return new MySqlConnection();
                default: return new MySqlConnection();
            }
        }
    }

    public class SecureConnectionFactory : ConnectionFactory
    {
        public SecureConnectionFactory():base()
        {

        }
        public SecureConnectionFactory(ConnectionType connectionType) : base(connectionType)
        {

        }
        public override Connection CreateConnection()
        {
            switch (this.connectionType)
            {
                case ConnectionType.Oracle:
                    return new SecureOracleConnection();
                case ConnectionType.SqlServer:
                    return new SecureSqlServerConnection();
                case ConnectionType.MySql:
                    return new SecureMySqlConnection();
                default: return new SecureMySqlConnection();
            }
        }
    }

    public abstract class ConnectionFactory
    {
        protected ConnectionType connectionType;
        public ConnectionFactory()
        {

        }
        public ConnectionFactory(ConnectionType connectionType)
        {
            this.connectionType = connectionType;
        }
        public abstract Connection CreateConnection();
    }

    public enum ConnectionType
    {
        Oracle,
        SqlServer,
        MySql
    }
}
