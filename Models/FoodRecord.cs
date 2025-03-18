using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NutriGuide.Models
{
    public class FoodRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Người dùng")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public NCUser User { get; set; }

        [Required, MaxLength(100)]
        [Display(Name ="Thực phẩm")]
        public string FoodName { get; set; }
        [Display(Name ="Chỉ số đường huyết")]
        public float GlycemicIndex { get; set; } // Chỉ số đường huyết của thực phẩm
        [Display(Name ="Ngày ăn")]
        public DateTime DateConsumed { get; set; }
    }
}
