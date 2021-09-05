using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rpc_auth.Data;
using rpc_auth.Models;

namespace rpc_auth.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly rpc_auth.Data.rpc_authContext _context;

        public IndexModel(rpc_auth.Data.rpc_authContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
