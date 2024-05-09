using System;

namespace Program
{
    public class DbCommand
    {
        private string DbConnection;
        private string Instruction;

        public DbCommand(ref string connection)
        {
            if (String.IsNullOrEmpty(connection)) throw new ArgumentNullException();
            DbConnection = connection;
        }

        public DbCommand(string instruction)
        {
            if (String.IsNullOrEmpty(instruction)) throw new ArgumentNullException();
            Instruction = instruction;
        }

        public virtual void Execute()
        {
            Console.WriteLine("This opens the server");
            Console.WriteLine("This runs the server");
            Console.WriteLine("This closes the server");
        }
    }

    public class SqlConnection : DbCommand
    {
        public SqlConnection(ref string connection) : base(connection)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("This opens the SQL server");
            Console.WriteLine("This runs the SQL server");
            Console.WriteLine("This closes the SQL server");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string connection = "connection";
            DbCommand server = new DbCommand(ref connection);
            server.Execute();
            SqlConnection sqlConnection = new SqlConnection(ref connection);
            sqlConnection.Execute();
        }
    }
}
