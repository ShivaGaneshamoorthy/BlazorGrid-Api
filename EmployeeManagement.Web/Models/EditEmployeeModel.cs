using EmployeeManagement.Models;
using EmployeeManagement.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
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
            ErrorMessage = "Only @armsolution.com is allowed")]
        public string Email { get; set; }
        [CompareProperty("Email", ErrorMessage = "Email and Confirm Email must match")]

        public string ConfirmEmail { get; set; }

        public DateTime AccountStartDate { get; set; }
        public double RefferedAmount { get; set; }
        public double Balance { get; set; }

        public Status Status { get; set; }

        public DateTime StatusDate { get; set; }
      
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ValidateComplexType]
        public Department Department { get; set; } = new Department();
    }
}
