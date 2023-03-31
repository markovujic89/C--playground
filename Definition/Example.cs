namespace Definition
{
    public class Example
    {
        public void AsAndIsOperators()
        {
            // is operator

            object objIs = new { text = "Hello, world!", number = 5 };
            object objAs = "Text 123";

            if (objIs is string) // check if obj is of type string
            {
                Console.WriteLine("The object is a string.");
            }
            else
            {
                Console.WriteLine("The object is not a string.");
            }

            Console.WriteLine("===========as===is==========================");
            // as operator
            var test = objAs as string;

            if(test!=null)
            {
                Console.WriteLine("As operator, objAs is string");
            }
        }
    }
}