using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    enum ScreenModal
    {
        Windows,
        Web,
        Mobile
    }
    class Creator
    {
        /// <summary>
        /// Factory Method
        /// </summary>
        /// <param name="screenModal">Screen Type</param>
        /// <returns>Main product reference</returns>
        public IScreen ScreenFactory(ScreenModal screenModal)
        {
            IScreen screen = null;
            switch (screenModal)
            {
                case ScreenModal.Windows:
                    screen = new WinScreen();
                    break;
                case ScreenModal.Web:
                    screen = new WebScreen();
                    break;
                case ScreenModal.Mobile:
                    screen = new MobileScreen();
                    break;
            }
            return screen;
        }
    }
    
    
    //Version 2 (recommended)
    abstract class Creator2
    {
        public abstract IScreen ScreenFactory();
    }
    class WinScreenCreator : Creator2
    {
        public override IScreen ScreenFactory()
        {
            return new WinScreen();
        }
    }
    class WebScreenCreator : Creator2
    {
        public override IScreen ScreenFactory()
        {
            return new WebScreen();
        }
    }
    class MobileScreenCreator : Creator2
    {
        public override IScreen ScreenFactory()
        {
            return new MobileScreen();
        }
    }
}
