using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryProject.Models.Class
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Detail { get; set; }
    }
}