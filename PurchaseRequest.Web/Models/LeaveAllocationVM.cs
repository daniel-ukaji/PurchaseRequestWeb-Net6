﻿using System.ComponentModel.DataAnnotations;
namespace PurchaseRequest.Web.Models;
using System.Xml.Linq;

public class LeaveAllocationVM
{
    [Required]
    public int Id { get; set; }

    [Display(Name = "Number of Days")]
    [Required]
    [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
    public int NumberOfDays { get; set; }

    [Required]
    [Display(Name = "Allocation Period")]
    public int Period { get; set; }
    public LeaveTypeVM? LeaveType { get; set; }
}