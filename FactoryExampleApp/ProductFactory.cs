using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExampleApp
{
    class ProductFactory
    {
        //private Product myProduct;
        public ProductFactory() { }
        public static IProduct makeProduct(int budget)
        {
            if (budget < 100)
            {
                return new SimpleProduct();
            }
            else if (budget >= 100 && budget < 200)
            {
                return new ComplexProduct();
            }
            else
            {
                return new MoreComplexProduct();
            }
        }
    }


}
