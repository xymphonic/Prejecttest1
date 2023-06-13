using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using autisamdata.Models;

namespace newadmin.Pages
{
    public class EditModel : PageModel
    {
        private readonly autisamdata.Models.DatabasetestContext _context;

        public EditModel(autisamdata.Models.DatabasetestContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Partnership Partnership { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Partnership == null)
            {
                return NotFound();
            }

            var partnership =  await _context.Partnership.FirstOrDefaultAsync(m => m.Id == id);
            if (partnership == null)
            {
                return NotFound();
            }
            Partnership = partnership;
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

            _context.Attach(Partnership).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartnershipExists(Partnership.Id))
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

        private bool PartnershipExists(int id)
        {
          return (_context.Partnership?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
