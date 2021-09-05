using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace rpc_auth.Models
{
    public class RPCUser
    {
        public int ID { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName{ get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthdate { get; set; }

    }
}
