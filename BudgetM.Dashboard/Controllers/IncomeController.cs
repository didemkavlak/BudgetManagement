using BudgetM.Dashboard.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudgetM.Dashboard.Controllers
{
    public class IncomeController : Controller
    {
        // GET: Income
        public ActionResult Index()
        {
            var incomeList = IncomeOP.GetAll();

            return View(incomeList);
        }
    }
}