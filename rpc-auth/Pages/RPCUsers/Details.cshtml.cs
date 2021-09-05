using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rpc_auth.Data;
using rpc_auth.Models;

namespace rpc_auth.Pages.RPCUsers
{
    public class DetailsModel : PageModel
    {
        private readonly rpc_auth.Data.rpc_authContext _context;

        public DetailsModel(rpc_auth.Data.rpc_authContext context)
        {
            _context = context;
        }

        public RPCUser RPCUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RPCUser = await _context.RPCUser.FirstOrDefaultAsync(m => m.ID == id);

            if (RPCUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
