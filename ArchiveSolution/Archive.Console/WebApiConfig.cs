using System.Web.Http;

namespace Archive.Console
{
    public static class WebApiConfig
    {
        public static void RegisterRoutes(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                    "Default", 
                    "api/{controller}/{id}",
                    new { id = RouteParameter.Optional });
        }
    }
}
