using Core.DataAccess.Abstract;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Abstract
{
    public interface IReportDal:IEntityRepository<Report>
    {
    }
}
