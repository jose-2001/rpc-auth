using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rpc_auth.Models;

namespace rpc_auth.Data
{
    public class rpc_authContext : DbContext
    {
        public rpc_authContext (DbContextOptions<rpc_authContext> options)
            : base(options)
        {
        }

        public DbSet<rpc_auth.Models.User> User { get; set; }
    }
}
