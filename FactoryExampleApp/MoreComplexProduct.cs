using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExampleApp
{
    class MoreComplexProduct : IProduct
    {
        private String productType;
        private int cost;
        public MoreComplexProduct()
        {
            this.productType = "MoreComplex";
            this.cost = 200;
        }
        public String getProductType()
        {
            return this.productType;
        }
        public int getCost()
        {
            return this.cost;
        }
    }   
}
