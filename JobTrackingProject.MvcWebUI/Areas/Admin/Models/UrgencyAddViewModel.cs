using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.MvcWebUI.Areas.Admin.Models
{
    public class UrgencyAddViewModel
    {
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama alanı boş geçilemez!")]
        public string Description { get; set; }
    }
}
