using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMVC.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Display(Name = "Имя")] public string Name { get; set; }
        [Display(Name = "Отзывы")] public string _comments { get; set; }

        [Display(Name = "Id Phone")] public int? PhoneId { get; set; }
        public Phone Phone { get; set; }
    }
}