using Core.DataAccess.Concrete.EntityFramework;
using JobTrackingProject.DataAccess.Abstract;
using JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserDal : EfEntityRepositoryBase<AppUser, TodoContext>, IAppUserDal
    {
    }
}
