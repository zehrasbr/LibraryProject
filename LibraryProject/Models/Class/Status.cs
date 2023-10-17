using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryProject.Models.Class
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public int Book { get; set; }
        public int Member { get; set; }
        public int Employee { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}