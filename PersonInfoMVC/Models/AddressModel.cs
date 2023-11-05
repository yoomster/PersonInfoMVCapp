using System.ComponentModel.DataAnnotations;

namespace PersonInfoMVC.Models
{
    public class AddressModel
    {
        [Required]
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
