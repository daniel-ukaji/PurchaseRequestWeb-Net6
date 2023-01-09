using System.ComponentModel.DataAnnotations;

namespace PurchaseRequest.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Purchase Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Range(1, 25, ErrorMessage = "Please Enter A Valid Number")]
        public int? DefaultDays { get; set; }
    }
}
