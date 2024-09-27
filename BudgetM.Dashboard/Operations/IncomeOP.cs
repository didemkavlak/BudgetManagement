using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BudgetM.Dashboard.Models.DTOs;

namespace BudgetM.Dashboard.Operations
{
	public class IncomeOP
	{
		
		private static List<IncomeDTO> list = new List<IncomeDTO>();

		public static List<IncomeDTO> GetAll()
		{
			return GetList();
		
		}



		public static List<IncomeDTO> GetList()
		{  
			if (list == null || list.Count == 0)
			{
				list.Add(new IncomeDTO(){

					Income = 15000,
					IncomeName = "Salary"

				});

				list.Add(new IncomeDTO() { IncomeName="Rent", Income=2000 });


			}
			
			
			return list;
		
		}


	}
}