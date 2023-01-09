using System.ComponentModel.DataAnnotations.Schema;

namespace PurchaseRequest.Web.Data
{
    public class LeaveRequest : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public DateTime DateRequested { get; set; }
        public string? RequestComments { get; set; }

        public string? PurchaseItems { get; set; }
        public string? Description { get; set; }
        public string? Manufacturer { get; set; }
        public string? ModelPurchase { get; set; }
        public string? Rating { get; set; }
        public string? Power { get; set; }
        public string? Unit { get; set; }
        public int? Quantity { get; set; }
        public string? VendorName { get; set; }
        public string? VendorAddress { get; set; }
        public int? AmountProduction { get; set; }
        public int? Prepayment { get; set; }
        public int? BalancePayment { get; set; }
        public DateTime? DeliveryDate { get; set; }


        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public string RequestingEmployeeId { get; set; }
    }
}
