using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definition.SOLID
{
    internal class DependencyInversionPrinciple
    {
        public void ClientCode()
        {
            IEngine engine = new GasEngine(); // Dependency Injection
            Car car = new Car(engine);
            car.Start();
        }
    }

    public class Car
    {
        private readonly IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public void Start()
        {
            _engine.Start();
        }
    }

    // Abstraction that defines the contract for the dependency
    public interface IEngine
    {
        void Start();
    }

    // Low-level module that implements the abstraction
    public class GasEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting gas engine");
        }
    }

    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting electric engine");
        }
    }
}
