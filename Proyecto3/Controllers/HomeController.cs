using System.Web;
using System.Web.Mvc;

namespace Proyecto3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subir(HttpPostedFileBase file)
        {

            if (file != null)
            {
                string fileName = (file.FileName).ToLower();

                try
                {
                    file.SaveAs(Server.MapPath("~/Uploads/" + fileName));
                    return RedirectToAction("Transformation", "Xml");
                }
                catch
                {
                    ViewBag.UploadError = "Error al cargar el archivo";
                    return View("Index");
                }

            }
            else
            {
                ViewBag.UploadError = "Error al cargar el archivo";
                return View("Index");
            }
        }
    }
}