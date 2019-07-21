using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;

namespace Proyecto3.Controllers
{
    public class XmlController : Controller
    {
        // GET: Xml
        public ActionResult Transformation()
        {
            return View();
        }

        public string Xml()
        {

            var path = Server.MapPath("~/Uploads/data.html");

            var doc = new HtmlDocument();
            doc.Load(path);

            var node = doc.DocumentNode.SelectSingleNode("//body");

            return node.OuterHtml;
        }

       
    }
}