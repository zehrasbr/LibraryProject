using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryProject.Models.Class
{
    public class Members
    {
        [Key]
        public int MembersID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string TelNo { get; set; }
        public string School { get; set;}
    }
}