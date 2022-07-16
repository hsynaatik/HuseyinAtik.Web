using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutDetails1 { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string AboutDetails2 { get; set; }
        public bool AboutStatus { get; set; }
   
    }
}
