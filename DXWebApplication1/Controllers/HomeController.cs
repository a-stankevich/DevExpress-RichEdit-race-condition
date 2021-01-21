using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            return View();
        }

        public ActionResult RichEditPartial() {
            return PartialView("_RichEditPartial");
        }

        public ActionResult CustomActionPartial(string operation) {
            if(operation == "Save Document") {
                RichEditExtension.SaveCopy("RichEditTest", Server.MapPath("~/Documents/savedDocument.rtf"));
            }            
            return PartialView("_RichEditPartial");
        }

        [HttpPost]
        public ActionResult ExportFile() {
          return RichEditExtension.ExportToPDF("RichEdit1", "ExportedDocument");
        }
    }
}