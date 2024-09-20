using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetM.Dashboard.Models.DTOs
{
	public class IncomeDTO : BaseDTO
	{

		public decimal Income { get; set; }
		public string IncomeName { get; set; }
	}
}