using JobTrackingProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.MvcWebUI.Areas.Admin.Models
{
    public class DutyListViewModel
    {
        public int Id { get; set; }
        public string DutyName { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }
    }
}
