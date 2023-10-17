using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryProject.Models.Class
{
    public class Punish
    {
        [Key]
        public int PunishID { get; set; }
        public int Member { get; set; }
        public DateTime BeginDate  { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Money { get; set; }
        public bool Status { get; set; }
    }
}