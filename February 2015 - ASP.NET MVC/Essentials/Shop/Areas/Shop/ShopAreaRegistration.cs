using System.Web.Mvc;

namespace Shop.Areas.Shop
{
    public class ShopAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Shop";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Shop_default",
                "{action}/{id}",
                new { controller = "Shop", action = "Products", id = UrlParameter.Optional }
            );
        }
    }
}