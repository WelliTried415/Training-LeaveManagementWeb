﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Training_LeaveManagementWeb.Data;

namespace Training_LeaveManagementWeb.Models
{
    public class LeaveRequestCreateVM : IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}")]
        [DataType(DataType.DateTime)]
        public DateTime? StartDate { get; set; }
        
        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}")]
        [DataType(DataType.DateTime)]
        public DateTime? EndDate { get; set; }

        [Required]
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Request Comments")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date Must Be Before End Date", new[] {nameof(StartDate), nameof(EndDate) });
            }
        }
    }
}
