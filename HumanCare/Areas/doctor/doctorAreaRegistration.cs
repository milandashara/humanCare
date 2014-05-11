using System.Web.Mvc;

namespace HumanCare.Areas.doctor
{
    public class doctorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "doctor";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "doctor_default",
                "doctor/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
