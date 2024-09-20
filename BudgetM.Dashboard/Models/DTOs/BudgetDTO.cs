using BudgetM.Dashboard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetM.Dashboard.Models.DTOs
{
    public class BudgetDTO : BaseDTO
    {
        public string BudgetName { get; set; }
        public BudgetCategory BudgetCategory { get; set; } //ı suppose ıt should be enum

        public decimal BudgetPrice { get; set; }
        public decimal BudgetTotal {  get; set; }

        
		

    }
}