namespace Definition.SOLID
{
    internal class InterfaceSegregationPrinciple
    {

        public void ClientCode(IMovable movable)
        {
            movable.Move();
        }

        // Usage
        //Car1 car = new Car1();
        //Plane plane = new Plane();

        //ClientCode(car); // Output: The car is moving
        //ClientCode(plane); // Output: The plane is moving
    }

    // Interface segregation principle
    public interface IMovable
    {
        void Move();
    }

    public interface IFlyable
    {
        void Fly();
    }

    // Classes implementing interfaces
    public class Car1 : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving");
        }
    }

    public class Plane : IMovable, IFlyable
    {
        public void Move()
        {
            Console.WriteLine("The plane is moving");
        }

        public void Fly()
        {
            Console.WriteLine("The plane is flying");
        }
    }



}
