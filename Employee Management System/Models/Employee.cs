using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_System.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department is required.")]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Job title is required.")]
        public string JobTitle { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "Salary must be greater than zero.")]
        public decimal Salary { get; set; }
    }
}