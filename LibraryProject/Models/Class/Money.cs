using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryProject.Models.Class
{
    public class Money
    {
        [Key]
        public int MoneyID { get; set; }
        public string Month { get; set; }
        public decimal TotalMoney { get; set; }
    }
}