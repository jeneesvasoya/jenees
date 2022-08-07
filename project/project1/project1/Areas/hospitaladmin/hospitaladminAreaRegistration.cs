using System.Web.Mvc;

namespace project1.Areas.hospitaladmin
{
    public class hospitaladminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "hospitaladmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "hospitaladmin_default",
                "hospitaladmin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}