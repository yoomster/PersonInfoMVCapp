using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;

namespace PersonInfoMVC.Models
{
    public class PersonModel
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }


        [Display(Name = "Active user")]
        public bool IsActive{ get; set; } = false;
    }
}
