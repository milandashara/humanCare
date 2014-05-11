using System.Web.Mvc;

namespace HumanCare.Areas.clericalStaff
{
    public class clericalStaffAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "clericalStaff";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "clericalStaff_default",
                "clericalStaff/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
