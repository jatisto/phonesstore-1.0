using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMVC.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Имя")] 
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Отзывы")] 
        public string _comments { get; set; }

        [Display(Name = "Телефон")] public int? PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}