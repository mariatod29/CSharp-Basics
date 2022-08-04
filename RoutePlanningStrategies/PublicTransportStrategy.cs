using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator
{
    public class PublicTransportStrategy : IRouteStrategy
    {
        public string BuildRoute(string a, string b)
        {
            return "Public Transport Build";
        }
    }
}
