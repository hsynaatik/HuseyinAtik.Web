using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectImage { get; set; }
        public string ProjectUrl { get; set; }
        public bool ProjectStatus { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
