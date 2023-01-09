using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PurchaseRequest.Web.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set;  }

        [Display(Name = "Request Comments")]
        public string? RequestComments { get; set; }

        [Display(Name = "Purchase Items")]
        public string? PurchaseItems { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "Manufacturer")]
        public string? Manufacturer { get; set; }

        [Display(Name = "Model Purchase")]
        public string? ModelPurchase { get; set; }

        [Display(Name = "Rating")]
        public string? Rating { get; set; }

        [Display(Name = "Power")]
        public string? Power { get; set; }

        [Display(Name = "Unit")]
        public string? Unit { get; set; }

        [Display(Name = "Quantity")]
        public int? Quantity { get; set; }

        [Display(Name = "Vendor Name")]
        public string? VendorName { get; set; }

        [Display(Name = "Vendor Address")]
        public string? VendorAddress { get; set; }

        [Display(Name = "Amount of Production")]
        public int? AmountProduction { get; set; }

        [Display(Name = "Prepayment")]
        public int? Prepayment { get; set; }

        [Display(Name = "Balance Payment")]
        public int? BalancePayment { get; set; }

        [Display(Name = "Delivery Date")]
        public DateTime? DeliveryDate { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date Must Be Before End Date", new[] {nameof(StartDate), nameof(EndDate)});
            }
        }
    }
}
