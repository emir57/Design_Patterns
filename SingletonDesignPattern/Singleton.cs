using System;

namespace SingletonDesignPattern
{
    class Singleton
    {
        private static Singleton _instance { get; set; }
        public Guid Id { get; }
        private static object _lockObject = new object();
        private Singleton(Guid id)
        {
            Id = id;
        }
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton(Guid.NewGuid());
                    }
                }
            }
            return _instance;
        }
    }
}
