using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        // Navigation property for one-to-many relationship
        public ICollection<Employee>? Employees { get; set; }
    }
}
// close