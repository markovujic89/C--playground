using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definition.Delegate
{
    public delegate void Print(string text);

    public class DelegateExample
    {
        public void ErrorMessage(string errorMessage) 
        {

            Console.WriteLine($"This is a error message {errorMessage}.");
        }

        public void DebugMessage(string debugMessage)
        {

            Console.WriteLine($"This is a debug message {debugMessage}.");
        }

        public void PrintText(Action<string> action, string text) 
        {
            action.Invoke(text);

            Console.WriteLine("the delegat is called, and text is printed");
        }
    }
}
