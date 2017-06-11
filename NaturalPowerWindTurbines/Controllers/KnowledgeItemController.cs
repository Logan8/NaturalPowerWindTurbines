using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NaturalPowerWindTurbines.Models;

namespace NaturalPowerWindTurbines.Controllers
{
    public class KnowledgeItemController : Controller
    {
        // GET: KnowledgeItem
        public ActionResult Index()
        {
            var knowledgeItem = new KnowledgeItem() { Details = "A Wind Turbine" };

            return View(knowledgeItem);
        }
    }
}