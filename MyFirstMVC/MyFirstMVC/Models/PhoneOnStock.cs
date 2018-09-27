using System.ComponentModel.DataAnnotations;

namespace MyFirstMVC.Models
{
    public class PhoneOnStock
    {
        [Display(Name = "Телефон")] public int PhoneId { get; set; }
        public Phone Phone { get; set; }
        
        [Display(Name = "Склад")] public int StockId { get; set; }
        public Stock Stock { get; set; }
        
        [Display(Name = "Количество")] public int Quantity { get; set; }
    }
}