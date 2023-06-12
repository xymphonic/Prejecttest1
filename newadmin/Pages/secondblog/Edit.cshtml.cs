using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using autisamdata.Models;

namespace newadmin.Pages.EditBlogtest2
{
    public class EditModel : PageModel
    {
        private readonly autisamdata.Models.DatabasetestContext _context;

        public EditModel(autisamdata.Models.DatabasetestContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Secondblog Secondblog { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Secondblog == null)
            {
                return NotFound();
            }

            var secondblog =  await _context.Secondblog.FirstOrDefaultAsync(m => m.Id == id);
            if (secondblog == null)
            {
                return NotFound();
            }
            Secondblog = secondblog;
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

            _context.Attach(Secondblog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SecondblogExists(Secondblog.Id))
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

        private bool SecondblogExists(int id)
        {
          return (_context.Secondblog?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
