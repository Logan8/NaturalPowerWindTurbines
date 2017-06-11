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
        /*Function definition
         * Name: Index
         * Arguments: None
         * Type: ViewResult
         * Description: Controller for the default view of KnowledgeItem. Currently calls GetKnowledgeItem and returns a list to the view.
         */
        public ViewResult Index()
        {
            var knowledgeItem = GetKnowledgeItem();


            return View(knowledgeItem);
        }

        /*Function definition
         * Name: IndexShowKnowledgeItem
         * Arguments: id (integer)
         * Type: ActionResult
         * Description: Controller for handling a request for a specfic item in a list of KnowledgeItem
         */
        public ActionResult ShowKnowledgeItem(int id)
        {
            var knowledgeItem = GetKnowledgeItem().SingleOrDefault(k => k.Id == id);

            if (knowledgeItem == null) return HttpNotFound();

            return View(knowledgeItem);
        }

        /*Function definition
         * Name: GetKnowledgeItem
         * Arguments: None
         * Type: IEnumerable<KnowledgeItem>
         * Description: Temporary fucntion for creating a list of type KnowledgeItem to allow testing of displays before implementing databases
         */
        private IEnumerable<KnowledgeItem> GetKnowledgeItem()
        {
            /*var entryStatus = new List<EntryStatus>
            {
                new EntryStatus {Id = 1, Name = "Verified" },
                new EntryStatus {Id = 2, Name = "For Review" },
                new EntryStatus {Id = 3, Name = "Unconfirmed" }
            };

            var knowledgeCategory = new List<KnowledgeCategory>
            {
                new KnowledgeCategory {Id = 1, Name = "Maintenance Issue" },
                new KnowledgeCategory {Id = 2, Name = "BOP Issue" },
                new KnowledgeCategory {Id = 3, Name = "Warranty Issue" }
            };

            var manufacturer = new List<Manufacturer>
            {
                new Manufacturer {Id = 1, Name = "Nordex" },
                new Manufacturer {Id = 2, Name = "Siemens" },
                new Manufacturer {Id = 3, Name = "Senvion" },
                new Manufacturer {Id = 4, Name = "Vestas" }
            };*/

            return new List<KnowledgeItem>
            {
                new KnowledgeItem
                {
                    Id = 1,
                    Details = "This is KnowledgeItem 1",
                    WindFarm = "KnowledgeItem 1 WindFarm",
                    DateOfInformation = DateTime.Today,
                    CreatedBy = "Neil Logan (1)",
                    CreatedOn = DateTime.Today
                },

                new KnowledgeItem
                {
                    Id = 2,
                    Details = "This is KnowledgeItem 2",
                    WindFarm = "KnowledgeItem 2 WindFarm",
                    DateOfInformation = DateTime.Today,
                    CreatedBy = "Neil Logan (2)",
                    CreatedOn = DateTime.Today
                },

                new KnowledgeItem
                {
                    Id = 3,
                    Details = "This is KnowledgeItem 3",
                    WindFarm = "KnowledgeItem 3 WindFarm",
                    DateOfInformation = DateTime.Today,
                    CreatedBy = "Neil Logan (3)",
                    CreatedOn = DateTime.Today
                }
            };
        }
    }
}