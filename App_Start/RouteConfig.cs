using Microsoft.AspNet.FriendlyUrls;
using System.Web.Routing;

namespace HTTP5101A_N01371157_Bonus_Q1
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
        }
    }
}
