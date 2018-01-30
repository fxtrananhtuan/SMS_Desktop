using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DTO
{
    public class DTO_Account
    {

        public string ID { get; set; }
        [Required(ErrorMessage = "Please Enter Email Address")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        public string email { get; set; }
        public DateTime create_date { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Name must be between 6 and 20 characters")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Street is required")]
        public string street { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Suburb is required")]
        public string city { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "State is required")]
        public string state { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Post code is required")]
        public int zip { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone Number is required")]
        public string Phone { get; set; }
        public bool Active { get; set; }
    }
}
