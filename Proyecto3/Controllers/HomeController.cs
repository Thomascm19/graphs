using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Subir(HttpPostedFileBase file)
        {
            string archivo = (file.FileName).ToLower();

            try
            {
                file.SaveAs(Server.MapPath("~/Uploads/" + archivo));
            }
            catch (Exception e)
            {
               
            }           
        }
    }
}