using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.core.Models
{
   public  class Request
    {
        [Key]
        public int requestID { get; set; }
        public int mobileNumber { get; set; }
        public DateTime requestDate { get; set; }
    }
}
