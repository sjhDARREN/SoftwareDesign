using System;

namespace FactoryExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a budget");
            int budget = Convert.ToInt32(Console.ReadLine());             
            
            IProduct myProduct = ProductFactory.makeProduct(budget);
            Console.WriteLine("Creating New Product from Product Factory of type:" + myProduct.getProductType() + " which costs " + myProduct.getCost() );
           
            Console.ReadLine();
        }
    }
}