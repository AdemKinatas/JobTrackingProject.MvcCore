using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Concrete.EntityFramework;
using JobTrackingProject.DataAccess.Abstract;
using JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTrackingProject.Entities.Concrete;

namespace JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfUrgencyDal: EfEntityRepositoryBase<Urgency,TodoContext>,IUrgencyDal
    {
    }
}
