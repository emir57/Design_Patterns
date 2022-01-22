using System;
using System.Linq.Expressions;
using System.Reflection;

namespace FluentInterfacePrinciple2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ironTank = FluentFactory<Tank>.Init(new Tank())
                .GiveAValue(t=>t.Type, "T81")
                .GiveAValue(t=>t.Range, 450.50M)
                .GiveAValue(t=>t.Side, "Aliens")
                .Take();
            var burki = FluentFactory<Player>.Init(new Player())
                .GiveAValue(p=>p.NickName, "burkii")
                .GiveAValue(p=>p.LastLevel, 30)
                .Take();
            Console.WriteLine(ironTank.Type);
            Console.WriteLine(ironTank.Range);
            Console.WriteLine(ironTank.Side);
        }
    }
    interface IFactory<T>
    {
        //IFactory<T> GiveAValue(string propertyName, object value);
        IFactory<T> GiveAValue(Expression<Func<T, object>> property, object value);
        T Take();
    }
    class Factory<T> : IFactory<T>
    {
        private T _entity;
        public Factory(T entity)
        {
            _entity = entity;
        }

        public IFactory<T> GiveAValue(Expression<Func<T, object>> property, object value)
        {
            PropertyInfo pInfo = null;
            if (property.Body is MemberExpression)
            {
                pInfo = (property.Body as MemberExpression).Member as PropertyInfo;
            }
            else
            {
                pInfo = (((UnaryExpression)property.Body).Operand as MemberExpression).Member as PropertyInfo;
            }
            pInfo.SetValue(_entity, value);
            return this;
        }

        //public IFactory<T> GiveAValue(string propertyName, object value)
        //{
        //    var pInfo = _entity.GetType().GetProperty(propertyName);
        //    if (pInfo != null)
        //    {
        //        pInfo.SetValue(_entity, value);
        //    }
        //    return this;
        //}

        public T Take()
        {
            return _entity;
        }
    }
    static class FluentFactory<T>
        where T:class,new()
    {
        public static Factory<T> Init(T entity)
        {
            return new Factory<T>(entity);
        }
    }
    class Player
    {
        public string NickName { get; set; }
        public int LastLevel { get; set; }
    }
    class Tank
    {
        public string Type { get; set; }
        public decimal Range { get; set; }
        public string Side { get; set; }
    }
}
