using System.ComponentModel.DataAnnotations;

namespace ApiWithLogging.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
    }
}
