using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using autisamdata.Models;

namespace newadmin.Pages.EditBlogtest2
{
    public class CreateModel : PageModel
    {
        private readonly autisamdata.Models.DatabasetestContext _context;

        public CreateModel(autisamdata.Models.DatabasetestContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Secondblog Secondblog { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Secondblog == null || Secondblog == null)
            {
                return Page();
            }

            _context.Secondblog.Add(Secondblog);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
