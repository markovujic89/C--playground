using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Definition.Patterns
{
    internal class FactoryPattern
    {
    }

    //In this example, we have an interface called IProductFactory that defines a method for creating different types of products.
    //    We also have two concrete implementations of IProductFactory called ConcreteProductAFactory and ConcreteProductBFactory.
    //    Each factory implementation creates a different type of product, either ConcreteProductA or ConcreteProductB.

    //We also have an interface called IProduct that defines a Name property for the products.
    //    We then have two concrete implementations of IProduct called ConcreteProductA and ConcreteProductB.

    public interface IProductFactory
    {
        IProduct CreateProduct();
    }

    // Implementation of the interface for creating ConcreteProductA
    public class ConcreteProductAFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }

    // Implementation of the interface for creating ConcreteProductB
    public class ConcreteProductBFactory : IProductFactory
    {
        public IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }

    // Interface for the products
    public interface IProduct
    {
        string Name { get; }
    }

    // Implementation of ConcreteProductA
    public class ConcreteProductA : IProduct
    {
        public string Name => "Product A";
    }

    // Implementation of ConcreteProductB
    public class ConcreteProductB : IProduct
    {
        public string Name => "Product B";
    }


    //The client code can use the factory objects to create products without needing to know the specific implementation details of the products.
    //    Here's an example of client code using the factory pattern:
    public class Client
    {
        private readonly IProductFactory _productFactory;

        public Client(IProductFactory productFactory)
        {
            _productFactory = productFactory;
        }

        public void DoWork()
        {
            // Use the factory to create a new product
            IProduct product = _productFactory.CreateProduct();

            Console.WriteLine($"Created {product.Name}");
        }
    }
}
