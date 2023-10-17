using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryProject.Models.Class
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Writer { get; set; }
        public DateTime Date { get; set; }
        public string Publisher { get; set; }
        public int Page { get; set; }
        public bool Status { get; set; }
    }
}