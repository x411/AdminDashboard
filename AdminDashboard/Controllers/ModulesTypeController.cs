using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminDashboard.Models;

namespace AdminDashboard.Controllers
{
    public class ModulesTypeController : Controller
    {
        private TestEntities db = new TestEntities();
        // GET: ModulesType
        public ActionResult Index()
        {
            List<WEB_GET_LIST_MODULUES_TYPE_Result> lst = new List<WEB_GET_LIST_MODULUES_TYPE_Result>();
            lst = db.WEB_GET_LIST_MODULUES_TYPE().ToList();

            return View(lst);
        }

        public ActionResult getList()
        {
            List<WEB_GET_LIST_MODULUES_TYPE_Result> lst = new List<WEB_GET_LIST_MODULUES_TYPE_Result>();
            lst = db.WEB_GET_LIST_MODULUES_TYPE().ToList();

            return PartialView(lst);
        }
    }
}