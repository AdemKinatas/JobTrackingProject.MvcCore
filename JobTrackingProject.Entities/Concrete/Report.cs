using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTrackingProject.Entities.Concrete
{
    public class Report:IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }

        public int DutyId { get; set; }
        public Duty Duty { get; set; }
    }
}
