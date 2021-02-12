using JobTrackingProject.Business.Abstract;
using JobTrackingProject.DataAccess.Abstract;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JobTrackingProject.Business.Concrete
{
    public class ReportManager : IReportService
    {
        IReportDal _reportDal;

        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }

        public void Add(Report report)
        {
            _reportDal.Add(report);
        }

        public void Delete(Report report)
        {
            _reportDal.Delete(report);
        }

        public List<Report> GetAll(Expression<Func<Report, bool>> filter = null)
        {
            return _reportDal.GetAll(filter);
        }

        public Report GetByFilter(Expression<Func<Report, bool>> filter)
        {
            return _reportDal.GetByFilter(filter);
        }

        public void Update(Report report)
        {
            _reportDal.Update(report);
        }
    }
}
