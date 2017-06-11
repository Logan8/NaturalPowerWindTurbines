﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NaturalPowerWindTurbines.Models;
using NaturalPowerWindTurbines.ViewModels;
using System.Data.Entity;

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
         * Name: New
         * Arguments: None
         * Type: ViewResult
         * Description: Controller for view to create new KnowledgeItem
         */
        public ViewResult New()
        {
            var entryStatus = _context.EntryStatus.ToList();
            var knowledgeCategory = _context.KnowledgeCategory.ToList();
            var manufacturer = _context.Manufacturer.ToList();

            var viewModel = new KnowledgeItemFormViewModel
            {
                EntryStatus = entryStatus,
                KnowledgeCategory = knowledgeCategory,
                Manufacturer = manufacturer
            };

            return View("KnowledgeItemForm", viewModel);
        }

        /* Function definition
         * Name: Create
         * Arguments: None
         * Type: ActionResult
         * Description: Controller to create new KnowledgeItem
         */
        [HttpPost]
        public ActionResult Save(KnowledgeItem knowledgeItem)
        {
            if (knowledgeItem.Id == 0) _context.KnowledgeItem.Add(knowledgeItem);
            else
            {
                var knowledgeItemFromDb = _context.KnowledgeItem.Single(k => k.Id == knowledgeItem.Id);

                knowledgeItemFromDb.WindFarm = knowledgeItem.WindFarm;
                knowledgeItemFromDb.Details = knowledgeItem.Details;
                knowledgeItemFromDb.DateOfInformation = knowledgeItem.DateOfInformation;
                knowledgeItemFromDb.ManufacturerId = knowledgeItem.ManufacturerId;
                knowledgeItemFromDb.EntryStatusId = knowledgeItem.EntryStatusId;
                knowledgeItemFromDb.KnowledgeCateogoryId = knowledgeItem.KnowledgeCateogoryId;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "KnowledgeItem");
        }

        /* Function definition
         * Name: Index
         * Arguments: None
         * Type: ViewResult
         * Description: Controller for the default view of KnowledgeItem. Currently calls GetKnowledgeItem and returns a list to the view.
         */
        public ViewResult Index()
        {
            var knowledgeItem = _context.KnowledgeItem
                .Include(k => k.EntryStatus)
                .Include(k => k.KnowledgeCateogory)
                .Include(k => k.Manufacturer)
                .ToList();


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

            var viewModel = new KnowledgeItemShowViewModel
            {
                KnowledgeItem = knowledgeItem,
                EntryStatus = _context.EntryStatus.ToList(),
                Manufacturer = _context.Manufacturer.ToList(),
                KnowledgeCategory = _context.KnowledgeCategory.ToList()
            };


            return View("KnowledgeItemShow", viewModel);
        }

        public ActionResult EditKnowledgeItem(int id)
        {
            var knowledgeItem = _context.KnowledgeItem.SingleOrDefault(k => k.Id == id);

            if (knowledgeItem == null) return HttpNotFound();


            var viewModel = new KnowledgeItemFormViewModel
            {
                KnowledgeItem = knowledgeItem,
                EntryStatus = _context.EntryStatus.ToList(),
                Manufacturer = _context.Manufacturer.ToList(),
                KnowledgeCategory = _context.KnowledgeCategory.ToList()
            };

            return View("KnowledgeItemForm", viewModel);
        }
    }
}