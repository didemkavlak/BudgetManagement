using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetM.Dashboard.Models.DTOs
{
    public class BaseDTO
    {

        public BaseDTO() 
        {
            Id = Id == Guid.Empty || Id == null ? Guid.NewGuid() : Id;
        }

        public Guid? Id { get; set; }
    }
}