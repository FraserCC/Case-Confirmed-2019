using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaseConfirmed.Models;

namespace CaseConfirmed.Controllers
{
    public class CasesController : Controller
    {
        // GET: Cases/Random
        public ActionResult Random()
        {
            var MyCase = new Models.Cases() { Subject = "Broken Record" };
            return  RedirectToAction("Index","Home",new { page = 1, sortBy = "Subject"} );
        //    return Content("");
           // return  HttpNotFoundResult();
    //        return new EmptyResult();


        }
        public ActionResult Edit(int id)
        {
            return Content("My ID is" + id);
        }
        public  ActionResult Index(int? PageIndex, string SortBy)
        {
            if (!PageIndex.HasValue)
            {
                PageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(SortBy))
            {
                SortBy = "Subject";
            }
            return Content(String.Format("PageIndex={0}&SortBy={1}", PageIndex, SortBy));
        }
    }
}