using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public class WalkingStrategy : IRouteStrategy
    {
        public string BuildRoute(string a, string b)
        {
            return "Walking Strategy Build";
        }
    }
}
