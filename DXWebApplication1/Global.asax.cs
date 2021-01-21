using DevExpress.Web.Office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace DXWebApplication1 {
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication {
        protected void Application_Start() {
            AreaRegistration.RegisterAllAreas();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            ModelBinders.Binders.DefaultBinder = new DevExpress.Web.Mvc.DevExpressEditorsBinder();

            DevExpress.Web.ASPxWebControl.CallbackError += Application_Error;

            DocumentManager.AutoSaving += DocumentManager_AutoSaving;
            DevExpress.Web.Office.Internal.WorkSessionAdminTools.AutoSaved += WorkSessionAdminTools_AutoSaved;
            DevExpress.Web.Office.Internal.WorkSessionAdminTools.ModifiedChanged += WorkSessionAdminTools_ModifiedChanged;
        }

        private static void WorkSessionAdminTools_ModifiedChanged(DevExpress.Web.Office.Internal.IWorkSession workSession, DevExpress.Web.Office.Internal.DocumentDiagnosticEventArgs e) {
            //System.Threading.Thread.Sleep(5000);
        }

        private static void WorkSessionAdminTools_AutoSaved(DevExpress.Web.Office.Internal.IWorkSession workSession, DevExpress.Web.Office.Internal.DocumentDiagnosticEventArgs e) {
            
        }

        private static void DocumentManager_AutoSaving(IDocumentInfo documentInfo, DocumentSavingEventArgs e) {
            
        }

        protected void Application_Error(object sender, EventArgs e) {
            Exception exception = System.Web.HttpContext.Current.Server.GetLastError();
            //TODO: Handle Exception
        }
    }
}