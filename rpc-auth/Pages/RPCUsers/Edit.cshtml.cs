using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using rpc_auth.Data;
using rpc_auth.Models;

namespace rpc_auth.Pages.RPCUsers
{
    public class EditModel : PageModel
    {
        private readonly rpc_auth.Data.rpc_authContext _context;

        public EditModel(rpc_auth.Data.rpc_authContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RPCUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RPCUserExists(RPCUser.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RPCUserExists(int id)
        {
            return _context.RPCUser.Any(e => e.ID == id);
        }
    }
}
