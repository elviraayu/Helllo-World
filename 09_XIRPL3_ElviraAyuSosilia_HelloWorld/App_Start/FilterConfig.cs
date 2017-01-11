using System.Web;
using System.Web.Mvc;

namespace _09_XIRPL3_ElviraAyuSosilia_HelloWorld
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
