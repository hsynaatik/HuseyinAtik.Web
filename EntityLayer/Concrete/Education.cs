using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        public string EducationTitle { get; set; }
        public DateTime EducationStartDate { get; set; }
        public DateTime EducationFinishDate { get; set; }
        public string EducationDescription { get; set; }
        public bool EducationStatus { get; set; }
    }
}
