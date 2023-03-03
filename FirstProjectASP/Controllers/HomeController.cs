using FirstProjectASP.DAL;
using FirstProjectASP.Models;
using System.Linq;
using System.Web.Mvc;

namespace FirstProjectASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewData["Articles"] = DbQueries.GetArticles();
            ViewData["Header"] = DbQueries.GetHeader();
            return View();
        }

        public ActionResult About(int id)
        {
            Article art= new Article();
            art = DbQueries.GetArticles().Where(x => x.Id == id).FirstOrDefault();
            //todo split in paragraphs

            ViewData["Articles"] = art;
            ViewData["Header"] = DbQueries.GetHeader();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}