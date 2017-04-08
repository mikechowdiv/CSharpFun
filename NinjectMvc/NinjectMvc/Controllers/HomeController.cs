using NinjectMvc.Abstract;
using System.Web.Mvc;

namespace NinjectMvc.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        private IBook _book;

        public HomeController(IBook book)
        {
            this._book = book;
        }

        public ActionResult Index()
        {
            string bookinfo = this._book.GetBookInformation();
            return View(bookinfo as object);
        }
    }
}