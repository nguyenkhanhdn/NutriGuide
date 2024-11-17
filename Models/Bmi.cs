using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriGuide.Models
{
    public class Bmi
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tuổi của trẻ yêu cầu nhập")]
        [Column("Age")]
        [Display(Name = "Tuổi của trẻ")]
        public string Age { get; set; }
        
        [Display(Name ="Chỉ số BMI của bé trai")]
        [Required(ErrorMessage = "Chỉ số BMI bé gái cần phải nhập")]
        public float MaleBmi{ get; set; }
        
        [Display(Name = "Chỉ số BMI của bé gái")]
        [Required(ErrorMessage = "Chỉ số BMI bé gái cần phải nhập")]
        public float FenaleBmi { get; set; }
    }
}
