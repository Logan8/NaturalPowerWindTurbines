using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NaturalPowerWindTurbines.Models;
using NaturalPowerWindTurbines.ViewModels;

/* Class definition
 * Name: KnowledgeItem
 * Type: Controller
 * Description: This is the controller for the main entity of the web application. It is responsible for handling requests for pages displaying a KnowledgeItem
 */

namespace NaturalPowerWindTurbines.Controllers
{
    public class KnowledgeItemController : Controller
    {
        /* Variable definition
         * Name: Dispose_context
         * Type: ApplicationDbContext
         * Description: Used to access databases.
         */
        private ApplicationDbContext _context;

        /* Class constructor
         * Name: KnowledgeItemController
         * Arguments: None
         * Description: Initiates _context
         */
        public KnowledgeItemController()
        {
            _context = new ApplicationDbContext();
        }

        /* Function definition
         * Name: Dispose
         * Arguments: disposing (boolean)
         * Type: Void
         * Description: Clean up of variable _context
         */
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        /* Function definition
         * Name: Index
         * Arguments: None
         * Type: ViewResult
         * Description: Controller for the default view of KnowledgeItem. Currently calls GetKnowledgeItem and returns a list to the view.
         */
        public ViewResult Index()
        {
            var knowledgeItem = _context.KnowledgeItem;


            return View(knowledgeItem);
        }

        /* Function definition
         * Name: IndexShowKnowledgeItem
         * Arguments: id (integer)
         * Type: ActionResult
         * Description: Controller for handling a request for a specfic item in a list of KnowledgeItem
         */
        public ActionResult ShowKnowledgeItem(int id)
        {
            var knowledgeItem = _context.KnowledgeItem.SingleOrDefault(k => k.Id == id);

            if (knowledgeItem == null) return HttpNotFound();

            return View(knowledgeItem);
        }
    }
}