using Core.Entity.Abstract;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace JobTrackingProject.Entities.Concrete
{
    public class AppUser : IdentityUser<int>,IEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public List<Duty> Duties { get; set; }
    }
}