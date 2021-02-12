using Core.Entity.Abstract;
using Microsoft.AspNetCore.Identity;

namespace JobTrackingProject.Entities.Concrete
{
    public class AppRole : IdentityRole<int>,IEntity
    {
    }
}