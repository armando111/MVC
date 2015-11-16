namespace EasyPTC.Web.Controllers
{
    using System.Web.Mvc;

    public class TestController : Controller
    {
        //test/Details/5

        public ActionResult Details(int id)
        {
            return View(id);
        }

    }
}