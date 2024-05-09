using System;

namespace Polymorphism
{
    public abstract class DbConnection
    {
        private string ConnectionString;

        public DbConnection(string connection)
        {
            if (String.IsNullOrEmpty(connection))
                throw new ArgumentNullException();
            ConnectionString = connection;
        }

        public TimeSpan TimeSpan { get; set; }


        public abstract void Open();

        public abstract void Close();

    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) : base(connection)
        {
        }
        public override void Open()
        {
            Console.WriteLine("Opened connection");
        }

        public override void Close() 
        {
            Console.WriteLine("Closed connection");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection) : base(connection)
        {
        }
        public override void Open()
        {
            Console.WriteLine("Opened connection");
        }

        public override void Close()
        {
            Console.WriteLine("Closed connection");
        }
    }
}
