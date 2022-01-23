using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    /// <summary>
    /// Product Interface
    /// </summary>
    public interface IScreen
    {
        void Draw();
    }
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class WinScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Windows Screen");
        }
    }
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class WebScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Web Screen");
        }
    }
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class MobileScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("Mobile Screen");
        }
    }
}
