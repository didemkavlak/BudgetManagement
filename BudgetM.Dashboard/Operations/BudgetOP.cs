
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BudgetM.Dashboard.Models.DTOs;
using BudgetM.Dashboard.Enums;

namespace BudgetM.Dashboard.Operations
{
    public class BudgetOP
    {

        private static List<BudgetDTO> list = new List<BudgetDTO>();

        public static List<BudgetDTO> GetAll()
        {
            

            return GetList();


        }

        public static bool Add(BudgetDTO budgetDTO)
        {

            try
            {
                list.Add(budgetDTO);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

		public static bool Delete(Guid id)
		{
			try
			{
				var result = list.FirstOrDefault(x => x.Id == id);
				list.Remove(result);

				return true;
			}
			catch (Exception)
			{

				return false;
			}



		}


		public static List<BudgetDTO> GetList()
        {
            if(list == null || list.Count ==0 )
            {
                list.Add(new BudgetDTO()
                {
                    BudgetName = "Rentt",
                    BudgetCategory = BudgetCategory.Needs,
                    BudgetPrice = 12000,
                    BudgetTotal = 80000,

                });

                list.Add(new BudgetDTO() { BudgetName = "Groceriess", BudgetCategory= BudgetCategory.Needs , BudgetPrice = 1000 });

                list.Add(new BudgetDTO() { BudgetName = "Groceriess", BudgetCategory = BudgetCategory.Wants , BudgetPrice = 1000 });
                
                list.Add(new BudgetDTO() { BudgetName = "Rent", BudgetCategory = BudgetCategory.Unexpected , BudgetPrice = 1500 });
                
                list.Add(new BudgetDTO() { BudgetName = "Utilities", BudgetCategory = BudgetCategory.Culture , BudgetPrice = 200 });


            }

            


            return list;
        }

    


    }
}