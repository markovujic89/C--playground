using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definition.ExceptionHandling
{
    public class PlayWithExceptions
    {
        public void TestExceptionThrow()
        {
            int n = 0;
            for (int i = 0; i < 100001; i++)
            {
                if(i%100 == 0)
                {
                    var task = new Task(() =>
                    {
                        n++;
                        Console.WriteLine("Count {n}");
                    });
                }

                if(i == 100000)
                {
                    throw new Exception("Exception is thrown accidently");
                }
                
            }
        }
    }
}
