using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class FactoryCreatorSingleton
    {
        private static FactoryCreatorSingleton instance = null;

        // constructor - note that it is declared private so that only this class can instantiate itself
        private FactoryCreatorSingleton()
        {
            // nothing to do
        }

        // get a reference to the sole instance of this class, creating it if necessary
        public static FactoryCreatorSingleton GetInstance()
        {
            if (instance == null)
                instance = new FactoryCreatorSingleton();

            return instance;
        }
        public ILaptopFactory GetLaptopFactory(string make)
        {
            switch (make)
            {
                case "dell":
                    return new DellLaptopFactory();

                case "lenovo":
                    return new LenovoLaptopFactory();

                case "apple":
                    return new AppleLaptopFactory();

                default:
                    return null;
            }
        }
    }
}
