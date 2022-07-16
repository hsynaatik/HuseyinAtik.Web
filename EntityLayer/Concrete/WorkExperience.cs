using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WorkExperience
    {
        [Key]
        public int WorkId { get; set; }
        public string WorkTitle { get; set; }
        public string WorkDescription { get; set; }
        public DateTime WorkStartDate { get; set; }
        public DateTime WorkFinishDate { get; set; }
        public bool WorkStatus { get; set; }
    }
}
