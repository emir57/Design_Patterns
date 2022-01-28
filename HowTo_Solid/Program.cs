﻿using System;
using System.IO;

namespace HowTo_Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Force t80 = new Tank();
            t80.Setup();
            t80.Move(10, 20, 33);
            t80.Move(22,35,32);
            Force redTeam = new Infantry();
            redTeam.Setup();
            redTeam.Move(15, 10, 40);
        }
    }
    class RouteSaver
    {
        public void WriteToFile(string content)
        {
            File.AppendAllText(Path.Combine(Environment.CurrentDirectory, "Routes.tx"), content);
        }
    }
    class Force
    {
        private RouteSaver _routeSaver = new();
        public virtual void Setup()
        {
            //Todo setup 
        }
        public virtual void Move(int x,int y,int z)
        {
            //Todo: move saver
            _routeSaver.WriteToFile(string.Format("{0} to {1},{2},{3}\n", this.GetType().Name, x, y, z));
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

}