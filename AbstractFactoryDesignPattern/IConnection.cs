using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public interface IConnection
    {
        bool Connect();
        bool Disconnect();
        string State { get; }
    }
    public interface ICommand
    {
        void Execute(string query);
    }
    public class Db2Connection:IConnection
    {
        public string State
        {
            get
            {
                return "Open";
            }
        }

        public bool Connect()
        {
            Console.WriteLine("Db2 open connection");
            return true;
        }

        public bool Disconnect()
        {
            Console.WriteLine("Db2 close connection");
            return true;
        }
    }
    public class InterbaseConnection : IConnection
    {
        public string State
        {
            get { return "Open"; }
        }

        public bool Connect()
        {
            Console.WriteLine("Interbase open connection");
            return true;
        }

        public bool Disconnect()
        {
            Console.WriteLine("Interbase close connection");
            return true;
        }
    }

    public class Db2Command : ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine("Db2 execute query");
        }
    }
    public class InterbaseCommand : ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine("Interbase execute query");
        }
    }
    public interface IDatabaseFactory
    {
        IConnection CreateConnection();
        ICommand CreateCommand();
    }
    public class Db2Factory : IDatabaseFactory
    {
        public ICommand CreateCommand()
        {
            return new Db2Command();
        }

        public IConnection CreateConnection()
        {
            return new Db2Connection();
        }
    }
    public class InterbaseFactory : IDatabaseFactory
    {
        public ICommand CreateCommand()
        {
            return new InterbaseCommand();
        }

        public IConnection CreateConnection()
        {
            return new InterbaseConnection();
        }
    }

    public class Factory
    {
        private IDatabaseFactory _databaseFactory;
        private ICommand _command;
        private IConnection _connection;

        public Factory(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _command = _databaseFactory.CreateCommand();
            _connection = _databaseFactory.CreateConnection();
        }
        public void Start()
        {
            _connection.Connect();
            if(_connection.State== "Open")
            {
                _command.Execute("Select ...");
            }
            _connection.Disconnect();
        }
    }
}
