using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace AdvancedRoutingMVC.Constraints
{
    public class GuidConstraint : IRouteConstraint
    {
        public bool Match(
            HttpContext? httpContext,
            IRouter? route,
            string routeKey,
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            if (values.ContainsKey(routeKey))
            {
                return Guid.TryParse(
                    values[routeKey]?.ToString(),
                    out Guid result);
            }

            return false;
        }
    }
}