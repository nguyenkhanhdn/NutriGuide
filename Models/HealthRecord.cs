using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NutriGuide.Models
{
    public class HealthRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Người dùng")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public NCUser User { get; set; }

        [Required]
        [Display(Name ="Ngày đo")]
        public DateTime DateRecorded { get; set; }
        [Display(Name ="Chỉ số đường huyết")]
        public float BloodSugar { get; set; } // Chỉ số đường huyết (mg/dL)

        [Display(Name = "Huyết áp tâm thu")]
        public int SystolicPressure { get; set; } // Huyết áp tâm thu (mmHg)
        [Display(Name = "Huyết áp tâm trương")]
        public int DiastolicPressure { get; set; } // Huyết áp tâm trương (mmHg)
    }
}
