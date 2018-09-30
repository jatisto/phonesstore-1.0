using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMVC.Models
{
    public class RatingModel
    {
        public int Id { get; set; }
        
        public string Star { get; set; }
        
        [Display(Name = "Id Phone")] public int? PhoneId { get; set; }
        public Phone Phone { get; set; }
        
//        public IEnumerable<string> Rating()
//        {
//            return new List<string>
//            {
//                "★",
//                "★★",
//                "★★★",
//                "★★★★",
//                "★★★★★",
//            };
//        }
    }
}