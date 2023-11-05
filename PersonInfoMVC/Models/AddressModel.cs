using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PersonInfoMVC.Models
{
    public class AddressModel
    {
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(6)]
        [Display(Name = "Zip code")]
        public string Zipcode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Country { get; set; }
    }
}
