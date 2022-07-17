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
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Add(Skill entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Skill entity)
        {
            throw new NotImplementedException();
        }

        public List<Skill> GetList()
        {
            return _skillDal.GetListAll();
        }

        public Skill TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Skill entity)
        {
            throw new NotImplementedException();
        }
    }
}
