using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTrackingProject.MvcWebUI.Areas.Admin.Models
{
    public class UrgencyUpdateViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Açıklama : ")]
        [Required(ErrorMessage ="Açıklama alanı gereklidir!")]
        public string Description { get; set; }
    }
}
