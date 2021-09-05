using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace rpc_auth.Models
{
    public class User
    {
        public int ID { get; set; }
        public string username { get; set; }
        private string password { get; set; }
        private string FirstName { get; set; }
        private string LastName{ get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

    }
}
