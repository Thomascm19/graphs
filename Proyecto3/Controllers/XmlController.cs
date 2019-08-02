using System.IO;
using System.Web.Mvc;
using System.Xml;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace Proyecto3.Controllers
{
    public class XmlController : Controller
    {
        // GET: Xml
        public ActionResult Transformation()
        {
            return View();
        }

        public ActionResult Xml()
        {
            var path = Server.MapPath("~/Uploads/data.html");

            var doc = new HtmlDocument();
            doc.Load(path);             

            doc.OptionOutputAsXml = true;

            StringWriter xml = new StringWriter();

            XmlTextWriter xw = new XmlTextWriter(xml);
            doc.Save(xw);
            string result = xml.ToString();
            //System.IO.File.WriteAllText(Server.MapPath("~/Uploads/data.xml"),result);

            //Json
            XmlDocument json = new XmlDocument();
            json.LoadXml(result);

            string jsonText = JsonConvert.SerializeXmlNode(json);
            System.IO.File.WriteAllText(Server.MapPath("~/Uploads/data.json"), jsonText);
            return RedirectToAction("Graph", "Graph");
        }

       
    }
}