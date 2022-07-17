using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
        public List<About> GetAboutWithUser()
        {
            using (var context = new Context())
            {
                return context.Abouts.Include(x => x.User).ToList();

            }
        }
    }
}
