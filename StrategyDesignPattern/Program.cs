using System;

namespace StrategyDesignPattern
{
    //Strategy
    interface ISerializable
    {
        void Serialize(string str);
        void DeSerialize(string str);
    }
    class XmlSerializer : ISerializable
    {
        public void DeSerialize(string str)
        {
            Console.WriteLine("Xml DeSerialize");
        }

        public void Serialize(string str)
        {
            Console.WriteLine("Xml Serialize");
        }
    }
    class BinarySerializer : ISerializable
    {
        public void DeSerialize(string str)
        {
            Console.WriteLine("Binary DeSerialize");
        }

        public void Serialize(string str)
        {
            Console.WriteLine("Binary Serialize");
        }
    }
    class JsonSerializer : ISerializable
    {
        public void DeSerialize(string str)
        {
            Console.WriteLine("Json DeSerialize");
        }

        public void Serialize(string str)
        {
            Console.WriteLine("Json Serialize");
        }
    }
    class Serializer
    {
        private ISerializable _serializable;
        public Serializer(ISerializable serializable)
        {
            _serializable = serializable;
        }
        public void Serialize(string str)
        {
            _serializable.Serialize(str);
        }
        public void DeSerialize(string str)
        {
            _serializable.DeSerialize(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Serializer serializer = new Serializer(new BinarySerializer());
            serializer.DeSerialize("serializable object");
        }
    }
}
