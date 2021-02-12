using Core.DataAccess.Concrete.EntityFramework;
using JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using JobTrackingProject.DataAccess.Interfaces;
using JobTrackingProject.Entities.Concrete;

namespace JobTrackingProject.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfDutyDal : EfEntityRepositoryBase<Duty, TodoContext>, IDutyDal
    {
    }
}