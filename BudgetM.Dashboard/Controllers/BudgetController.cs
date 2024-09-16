using BudgetM.Dashboard.Enums;
using BudgetM.Dashboard.Models.DTOs;
using BudgetM.Dashboard.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudgetM.Dashboard.Controllers
{
    public class BudgetController : Controller
    {
        // GET: Budget
        public ActionResult Index()
        {
            var budgetList = BudgetOP.GetAll();

            ViewBag.Needs = budgetList.Where(x => x.BudgetCategory == BudgetCategory.Needs).ToList();
            ViewBag.Wants = budgetList.Where(x => x.BudgetCategory == BudgetCategory.Wants).ToList();
            ViewBag.Culture = budgetList.Where(x => x.BudgetCategory == BudgetCategory.Culture).ToList();
            ViewBag.Unexpected = budgetList.Where(x => x.BudgetCategory == BudgetCategory.Unexpected).ToList();

            return View(budgetList);
        }

		public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(BudgetDTO budgerDTO)
        {
            BudgetOP.Add(budgerDTO);
            return RedirectToRoute("BudgetList");  

        }


        public ActionResult Delete(Guid id)
        {
            BudgetOP.Delete(id);
            return RedirectToRoute("BudgetList");
		}
    }
}