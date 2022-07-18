using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EducationManager : IEducationService
    {

        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void Add(Education entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Education entity)
        {
            throw new NotImplementedException();
        }

        public List<Education> GetList()
        {
           return  _educationDal.GetListAll();
        }

        public Education TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Education entity)
        {
            throw new NotImplementedException();
        }
    }
}
