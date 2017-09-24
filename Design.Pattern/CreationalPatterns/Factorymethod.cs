using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.CreationalPatterns
{
    public interface IProduct
    {
        decimal GetTaxPercentage();
    }

    public class Computer : IProduct
    {
        public decimal GetTaxPercentage()
        {
            return 0.02M;    
        }
    }

    public class Food : IProduct
    {
        public decimal GetTaxPercentage()
        {
            return 0.01M;
        }
    }

    public interface IProductFactory
    {
        IProduct CreateProduct(string productName);
    }

    public class ProductFactoryImpl : IProductFactory
    {
        public IProduct CreateProduct(string productName)
        {
            if(productName == "Food")
            {
                return new Food();
            }else if(productName == "Computer")
            {
                return new Computer();
            }
            else
            {
                throw new Exception($"IProductfactory can not create product {productName}");
            }
        }
    }


}
