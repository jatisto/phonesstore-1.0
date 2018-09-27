namespace MyFirstMVC.Models
{
    public class ExchangeRate
    {
        //        String CurrencyCode - код валюты
        //        String CurrencyName - название валюты
        //        Double CurrencyRate - стоимость 1 доллара в текущей валюте

        public int Id { get; set; }
        public string _currencyCode { get; set; }
        public string _currencyName { get; set; }
        public double _currencyRate { get; set; } 
    }
}