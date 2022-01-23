using System;
using System.Collections.Generic;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            IScreen screenMobile = creator.ScreenFactory(ScreenModal.Mobile);
            IScreen screenWeb = creator.ScreenFactory(ScreenModal.Mobile);
            IScreen screenWindows = creator.ScreenFactory(ScreenModal.Mobile);
            //screenMobile.Draw();

            Creator2[] creators = new Creator2[]
            {
                new WinScreenCreator(),
                new MobileScreenCreator(),
                new WebScreenCreator()
            };
            creators[1].ScreenFactory().Draw();
        }
    }
}
