using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMVC.Models
{
    public class RatingModel
    {
        public int Id { get; set; }

        [Display(Name = "Id Phone")] public int? PhoneId { get; set; }
        public Phone Phone { get; set; }

        public int? SymbolStarlId { get; set; }
        public StarSymbol SymbolStar { get; set; }
    }
}