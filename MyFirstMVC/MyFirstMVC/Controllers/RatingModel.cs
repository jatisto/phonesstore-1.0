using System.Collections.Generic;

namespace MyFirstMVC.Controllers
{
    public class RatingModel
    {
        public int Id { get; set; }
        public IEnumerable<string> Rating()
        {
            return new List<string>
            {
                "★",
                "★★",
                "★★★",
                "★★★★",
                "★★★★★",
            };
        }
    }
}