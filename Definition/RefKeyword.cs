using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definition
{
    public class RefKeyword
    {
        public void UpdateValueByReference(ref int number)
        {
            number = 99;
        }
    }
}
