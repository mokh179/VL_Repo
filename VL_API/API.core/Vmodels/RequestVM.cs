using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.core.Vmodels
{
   public class RequestVM
    {
        [Required(ErrorMessage = "Mobile_No is required.")]
        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Only 11 Number allowed.")]
        public string MobileNo { get; set; }
    }
}
