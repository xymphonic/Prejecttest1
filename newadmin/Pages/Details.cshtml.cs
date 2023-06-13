using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using autisamdata.Models;

namespace newadmin.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly autisamdata.Models.DatabasetestContext _context;

        public DetailsModel(autisamdata.Models.DatabasetestContext context)
        {
            _context = context;
        }

      public Partnership Partnership { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Partnership == null)
            {
                return NotFound();
            }

            var partnership = await _context.Partnership.FirstOrDefaultAsync(m => m.Id == id);
            if (partnership == null)
            {
                return NotFound();
            }
            else 
            {
                Partnership = partnership;
            }
            return Page();
        }
    }
}
