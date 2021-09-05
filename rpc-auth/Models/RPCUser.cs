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
        public string username { get; set; }
        public string password { get; set; }
        [Display(Name = "First Name")] 
        public string FirstName { get; set; }
        [Display(Name = "Last Name")] 
        public string LastName{ get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

    }
}
