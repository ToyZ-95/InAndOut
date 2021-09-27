using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expenses
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Expense { get; set; }

        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Amount must be greater than 0!")]
        public double Amount { get; set; }
    }
}
