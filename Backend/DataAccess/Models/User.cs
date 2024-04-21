using System.ComponentModel.DataAnnotations;

namespace Backend.DataAccess.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Email { get; set; }
        [Required]
        public required string Password { get; set; }
        public List<string>? UrgentandImportant { get; set; }
        public List<string>? NotUrgentandImportant { get; set; }
        public List<string>? UrgentandNotImportant { get; set; }
        public List<string>? NotUrgentandNotImportant { get; set; }
    }
}
