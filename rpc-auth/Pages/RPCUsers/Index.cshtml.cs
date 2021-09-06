using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rpc_auth.Data;
using rpc_auth.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace rpc_auth.Pages.RPCUsers
{
    public class IndexModel : PageModel
    {
        private readonly rpc_auth.Data.rpc_authContext _context;
        [BindProperty(SupportsGet = true)]
        public static bool SignedIn { get; set; }
        [BindProperty(SupportsGet =true)]
        public string Tryusername { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Trypassword{ get; set; }
        [BindProperty(SupportsGet = true)]
        public RPCUser SignedUser { get; set; }
        


        public IndexModel(rpc_auth.Data.rpc_authContext context)
        {
            _context = context;

        }

        public IList<RPCUser> RPCUser { get;set; }



        public async Task OnGetAsync()
        {
            RPCUser = await _context.RPCUser.ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            SignedUser = await _context.RPCUser.FirstOrDefaultAsync(m => m.username == Tryusername);

            if (SignedUser == null)
            {
                return Page();
            }
            SignedIn = true;
            RPCUser = await _context.RPCUser.ToListAsync();
            return Page();
            //await _context.SaveChangesAsync();
        }
    }
}
