using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using autisamdata.Models;

namespace newadmin.Pages.EditBlogtest2
{
    public class DetailsModel : PageModel
    {
        private readonly autisamdata.Models.DatabasetestContext _context;

        public DetailsModel(autisamdata.Models.DatabasetestContext context)
        {
            _context = context;
        }

      public Secondblog Secondblog { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Secondblog == null)
            {
                return NotFound();
            }

            var secondblog = await _context.Secondblog.FirstOrDefaultAsync(m => m.Id == id);
            if (secondblog == null)
            {
                return NotFound();
            }
            else 
            {
                Secondblog = secondblog;
            }
            return Page();
        }
    }
}
