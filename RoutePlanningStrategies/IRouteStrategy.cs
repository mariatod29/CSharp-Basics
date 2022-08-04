using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public interface IRouteStrategy
    {
        string BuildRoute(string a, string b);
    }
}
