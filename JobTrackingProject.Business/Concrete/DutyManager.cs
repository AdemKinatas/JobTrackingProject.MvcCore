using JobTrackingProject.Business.Abstract;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace JobTrackingProject.Business.Concrete
{
    public class DutyManager : IDutyService
    {
        private readonly IDutyDal _dutyDal;

        public DutyManager(IDutyDal dutyDal)
        {
            _dutyDal = dutyDal;
        }

        public void Add(Duty duty)
        {
            _dutyDal.Add(duty);
        }

        public void Delete(Duty duty)
        {
            _dutyDal.Delete(duty);
        }

        public List<Duty> GetAll(Expression<Func<Duty, bool>> filter = null)
        {
            return _dutyDal.GetAll(filter);
        }

        public Duty GetByFilter(Expression<Func<Duty, bool>> filter)
        {
            return _dutyDal.GetByFilter(filter);
        }

        public void Update(Duty duty)
        {
            _dutyDal.Update(duty);
        }
    }
}