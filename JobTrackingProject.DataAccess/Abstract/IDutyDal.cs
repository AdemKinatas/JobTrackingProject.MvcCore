using Core.DataAccess.Abstract;
using JobTrackingProject.Entities.Concrete;

namespace JobTrackingProject.DataAccess.Interfaces
{
    public interface IDutyDal : IEntityRepository<Duty>
    {
    }
}