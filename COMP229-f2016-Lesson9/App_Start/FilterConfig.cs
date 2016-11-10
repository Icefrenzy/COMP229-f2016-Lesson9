using System.Web;
using System.Web.Mvc;

namespace COMP229_f2016_Lesson9
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
