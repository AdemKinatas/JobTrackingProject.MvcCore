using Core.Entity.Abstract;
using System.Collections.Generic;

namespace JobTrackingProject.Entities.Concrete
{
    public class Urgency : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public List<Duty> Duties { get; set; }
    }
}