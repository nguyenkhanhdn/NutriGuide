using System.ComponentModel.DataAnnotations;

namespace NutriGuide.Models
{
    public class BMIViewModel
    {
        [Display(Name ="Chiều cao")]
        public float Height { get; set; }

        [Display(Name ="Cân nặng")]
        public float Weight { get; set; }
    }
}
