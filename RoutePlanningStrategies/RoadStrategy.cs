using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public class RoadStrategy : IRouteStrategy
    {
        public string BuildRoute(string a, string b)
        {
            return "Road Strategy Build";
        }
    }
}
