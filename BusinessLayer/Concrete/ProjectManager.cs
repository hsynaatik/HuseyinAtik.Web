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
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void Add(Project entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Project entity)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetList()
        {
            return _projectDal.GetListAll();
        }

        public List<Project> GetProjectListWithCategory()
        {
            return _projectDal.GetProjectWithCategory();
        }

        public Project TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Project entity)
        {
            throw new NotImplementedException();
        }
    }
}
