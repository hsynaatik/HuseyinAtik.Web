using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string UserName { get; set; } 
        public string UserSurname { get; set; } 
        public string FullName{ get { return UserName + " " + UserSurname; } } 
        public DateTime BirthDay { get; set; }
        public string WebSiteUrl { get; set; }
        public string UserImageUrl { get; set; }
        public string UserPhone { get; set; }
        public string UserCity { get; set; }
        public string UserDegree { get; set; }
        public string UserMail { get; set; }
        public bool UserStatus { get; set; }

        public int SocialMediaId { get; set; }
        public SocialMedia SocialMedia { get; set; }


    }
}
