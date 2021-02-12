using JobTrackingProject.Business.Abstract;
using JobTrackingProject.DataAccess.Abstract;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class UrgencyManager : IUrgencyService
    {
        IUrgencyDal _urgencyDal;

        public UrgencyManager(IUrgencyDal urgencyDal)
        {
            _urgencyDal = urgencyDal;
        }

        public void Add(Urgency urgency)
        {
            _urgencyDal.Add(urgency);
        }

        public void Delete(Urgency urgency)
        {
            _urgencyDal.Delete(urgency);
        }

        public List<Urgency> GetAll(Expression<Func<Urgency, bool>> filter = null)
        {
            return _urgencyDal.GetAll(filter);
        }

        public Urgency GetByFilter(Expression<Func<Urgency, bool>> filter)
        {
            return _urgencyDal.GetByFilter(filter);
        }

        public void Update(Urgency urgency)
        {
            _urgencyDal.Update(urgency);
        }
    }
}
