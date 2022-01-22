using System;

namespace FluentInterfacePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Product laptop = FluentProductFactory.Init()
                .SetProductName("Acer")
                .SetCategoryId(1)
                .SetQuantityPerUnit("unit in one")
                .SetUnitPrice(7999)
                .TakeAProduct();
            Console.WriteLine(laptop.ProductName);
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public byte UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
    }
    interface IProductFactory
    {
        Product TakeAProduct();
        IProductFactory SetProductName(string productName);
        IProductFactory SetCategoryId(int categoryId);
        IProductFactory SetUnitsInStock(byte unitInStock);
        IProductFactory SetUnitPrice(decimal unitPrice);
        IProductFactory SetQuantityPerUnit(string quantityPerUnit);
    }
    class ProductFactory : IProductFactory
    {
        private Product _product;
        public ProductFactory(Product product)
        {
            _product = product;
        }

        public IProductFactory SetCategoryId(int categoryId)
        {
            _product.CategoryID = categoryId;
            return this;
        }

        public IProductFactory SetProductName(string productName)
        {
            _product.ProductName = productName;
            return this;
        }

        public IProductFactory SetQuantityPerUnit(string quantityPerUnit)
        {
            _product.QuantityPerUnit = quantityPerUnit;
            return this;
        }

        public IProductFactory SetUnitPrice(decimal unitPrice)
        {
            _product.UnitPrice = unitPrice;
            return this;
        }

        public IProductFactory SetUnitsInStock(byte unitInStock)
        {
            _product.UnitsInStock = unitInStock;
            return this;
        }

        public Product TakeAProduct()
        {
            return _product;
        }
    }
    static class FluentProductFactory
    {
        public static ProductFactory Init()
        {
            return new ProductFactory(new Product());
        }
    }
}
