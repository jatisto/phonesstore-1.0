using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        [Remote(action: "CheckName", controller: "Validation", ErrorMessage = "Эй! Уф, нэ пеши сюда ето имя:-[ Оно уже есь же, эсь жи!!")]
        [Display(Name = "Название компании")]
        public string Name { get; set; }

        [EmailAddress]
        [Display(Name = "Почта компании")]
        public string _emailCompany { get; set; }

        //[Range(typeof(DateTime), "01/01/1975 01:01", "01/01/2019 01:01")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Дата создания компании")]
        public DateTime _dataCreateCompany { get; set; }

        public int? _CompanyId { get; set; }
        public Company _Company { get; set; }

        public IEnumerable<Company> CompaniesEnumerable { get; set; }

        public IEnumerable<Phone> Phones { get; set; }
    }
}