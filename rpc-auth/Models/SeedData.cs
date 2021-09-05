using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpc_auth.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace rpc_auth.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new rpc_authContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<rpc_authContext>>()))
            {
                // Look for any movies.
                if (context.RPCUser.Any())
                {
                    return;   // DB has been seeded
                }

                context.RPCUser.AddRange(
                    new RPCUser
                    {
                        username = "seyerman",
                        password = "seyerman",
                        FirstName="Juan",
                        LastName ="Reyes",
                        Birthdate=DateTime.Parse("1995-4-1"),
                    },

                    new RPCUser
                    {
                        username = "favellaneda",
                        password = "favellaneda",
                        FirstName = "Fabio",
                        LastName = "Avellaneda",
                        Birthdate = DateTime.Parse("1987-9-6"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
