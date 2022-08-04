using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public class Navigator
    {
        private readonly IRouteStrategy routeStrategy;

        public Navigator(IRouteStrategy routeStrategy)
        {
            this.routeStrategy = routeStrategy;
        }

        public string MakeRoute(string a, string b)
        {
            string route = routeStrategy.BuildRoute(a, b);
            return route;
        }
    }
}
