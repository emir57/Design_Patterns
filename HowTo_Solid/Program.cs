using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace HowTo_Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Force> forces = new List<Force>()
            {
                new Infantry(),
                new Tank(),
            };
            foreach (var force in forces)
            {
                force.Move(4, 56, 21);
            }
        }
    }
    interface IRouteSaver
    {
        void Write(string content);
    }
    class TextSave : IRouteSaver
    {
        public void Write(string content)
        {
            File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "Routes.tx"), content);
        }
    }
    class DbSaver : IRouteSaver
    {
        public void Write(string content)
        {
            //Write Db
            Console.WriteLine("DbSaved!");
        }
    }
    class DeviceSaver : IRouteSaver
    {
        public void Write(string content)
        {
            //Write device
        }
    }
    interface IMovement
    {
        void Move(int x, int y, int z);
    }
    interface ISetup
    {
        void Setup();
    }
    class Force:IMovement,ISetup
    {
        private static IRouteSaver _routeSaver;
        static Force()
        {
            string saverName = ConfigurationManager.AppSettings["SaverType"];
            _routeSaver = (IRouteSaver)Activator.CreateInstance(Type.GetType(saverName));
        }
        public virtual void Setup()
        {
            //Todo setup 
        }
        public virtual void Move(int x,int y,int z)
        {
            //Todo: move saver
            _routeSaver.Write(string.Format("{0} to {1},{2},{3}\n", this.GetType().Name, x, y, z));
        }
    }
    class Tank : Force
    {
        public override void Setup()
        {
            base.Setup();
        }
        public override void Move(int x, int y, int z)
        {
            base.Move(x, y, z);
        }
    }
    class Infantry : Force
    {
        public override void Setup()
        {
            base.Setup();
        }
        public override void Move(int x, int y, int z)
        {
            base.Move(x, y, z);
        }
    }
    class Bastion : ISetup
    {
        public void Setup()
        {
            
        }
    }

}
