using Core.DataAccess.Concrete.EntityFramework;
using JobTrackingProject.DataAccess.Abstract;
using JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfReportDal:EfEntityRepositoryBase<Report,TodoContext>,IReportDal
    {
    }
}
