using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definition.Structures
{
    public interface IPrice
    {
        double CalculatePrice(int minPrice, int maxPrice);
    }
}
