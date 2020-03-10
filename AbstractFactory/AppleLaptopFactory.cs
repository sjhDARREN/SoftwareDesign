using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class AppleLaptopFactory : ILaptopFactory
    {
        String factoryName = "Apple Factory";
        public ILaptop MakeLaptop(int budget)
        {
            AppleLaptop apple = new AppleLaptop();
            if (budget < 300)
            {
                apple.SetModel("Macbook Pro");
            }
            else
            {
                apple.SetModel("Macbook Air");
            }
            return apple;
        }
        public string GetFactoryName()
        {
            return this.factoryName;
        }
    }
}
