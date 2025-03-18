using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace NutriGuide.Models
{
    public class NCUser
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        [Display(Name="Tên người dùng")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBirth { get; set; } 

        [Required, MaxLength(10)]
        
        [Display(Name = "Giới tính")]

        public string Gender { get; set; } // Nam / Nữ

        public ICollection<HealthRecord> HealthRecords { get; set; }
    }
}
