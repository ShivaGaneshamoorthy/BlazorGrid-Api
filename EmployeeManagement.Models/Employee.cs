using EmployeeManagement.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Client { get; set; }

        public string AgencyId { get; set; }

        public string AccountId { get; set; }

        [Required(ErrorMessage = "FirstName must be provided")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "armsolution.com",
            ErrorMessage = "DOMAIN NAME MUST BE AT @armsolution.com ")]
        public string Email { get; set; }
        public DateTime AccountStartDate { get; set; }
        public double RefferedAmount { get; set; }
        public double Balance { get; set; }

        public Status Status { get; set; }

        public DateTime StatusDate { get; set; }

        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
