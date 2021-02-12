using Core.Entity.Abstract;
using System;
using System.Collections.Generic;

namespace JobTrackingProject.Entities.Concrete
{
    public class Duty : IEntity
    {
        public int Id { get; set; }
        public string DutyName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }

        public List<Report> Reports { get; set; }
    }
}