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
            Force t80 = new Tank();
            t80.Move(3,5,6);
            Force specialForces = new Paratrooper();
            if (((ILocationControl)specialForces).Check())
            {
                specialForces.Setup();
                specialForces.Move(3, 6, 10);
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
    interface ILocationControl
    {
        bool Check();
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
    class Paratrooper : Force, ILocationControl
    {
        public override void Setup()
        {
            base.Setup();
        }
        public override void Move(int x, int y, int z)
        {
            base.Move(x, y, z);
        }
        public bool Check()
        {
            return false;
        }
    }

}
