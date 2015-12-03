using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Income
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Income Name")]
        public string IncomeName { get; set; }

        [Display(Name = "Income Amount")]
        public decimal IncomeAmount { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Income Date")]
        public DateTime IncomeDate { get; set; }

        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserId { get; set; }
    }
}