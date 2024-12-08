using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.CodeAnalysis.Recommendations;
using System.ComponentModel.DataAnnotations;

namespace NutriGuide.Models
{
    public class Nutri
    {
        public int Id { get; set; }
        [Display(Name ="Vi chất")]
        [Required(ErrorMessage = "Dinh dưỡng yêu cầu phải nhập.")]
        public required string Nutrient { get; set; }
        [Required(ErrorMessage = "Triệu chứng yêu cầu phải nhập.")]
        [Display(Name = "Triệu chứng")]
        public required string Symptom { get; set; }
        [Required(ErrorMessage = "Thực phẩm bổ sung yêu cầu phải nhập.")]
        [Display(Name = "Thực phẩm bổ sung")]
        public required string Food2Eat { get; set; }
        [Required(ErrorMessage = "Hàm lượng bổ sung yêu cầu phải nhập.")]
        [Display(Name = "Hàm lượng")]
        public required string Amount2Eat { get; set; }
        [Display(Name = "Tần suất")]
        [Required(ErrorMessage ="Tần suất dùng yêu cầu phải nhập.")]
        public required string Frequency { get; set; }
        [Display(Name ="Ảnh minh họa")]
        public string? Img { get; set; } 
    }
}
