using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a make - lenovo or dell or apple");
            String make = Console.ReadLine();

            Console.WriteLine("Enter a budget");
            int budget = Convert.ToInt32(Console.ReadLine());

            //This singleton decides which factory to "fire up", based on the make (Dell, Lenovo etc.) that the customer requests
            FactoryCreatorSingleton myFactoryCreator = FactoryCreatorSingleton.GetInstance();

            ILaptopFactory requestedMakeFactory = myFactoryCreator.GetLaptopFactory(make);
            
            //Here the appropriate factory will produce the laptop based on the budget
            ILaptop requestedLaptop = requestedMakeFactory.MakeLaptop(budget);

            //ILaptop myLaptop = ProductFactory.makeProduct(budget);
            Console.WriteLine("Creating a laptop from " + requestedMakeFactory.GetFactoryName()+ " of make " + requestedLaptop.GetMake() + " \n"
                + " and model " + requestedLaptop.GetModel());

            Console.ReadLine(); 
        }
    }
}