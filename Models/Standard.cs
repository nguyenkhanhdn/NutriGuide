﻿using System.ComponentModel.DataAnnotations;

namespace NutriGuide.Models{
    public class Standard
    {
        public int Id { get; set; }
        [Display(Name ="Tuổi")]
        public required string Age { get; set; }
        [Display(Name = "Cân nặng")]
        public required string Weight { get; set; }
        [Display(Name = "Chiều cao")]
        public required string Height { get; set; }
        [Display(Name = "Giới tính")]
        public required string Gender {  get; set; } 
    }
}
