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
    public class WorkExperienceManager : IWorkExperienceService
    {

        IWorkExperienceDal _workExperienceDal;

        public WorkExperienceManager(IWorkExperienceDal workExperienceDal)
        {
            _workExperienceDal = workExperienceDal;
        }

        public void Add(WorkExperience entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(WorkExperience entity)
        {
            throw new NotImplementedException();
        }


        public List<WorkExperience> GetList()
        {
            return _workExperienceDal.GetListAll();
        }

        public WorkExperience TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(WorkExperience entity)
        {
            throw new NotImplementedException();
        }
    }
}
