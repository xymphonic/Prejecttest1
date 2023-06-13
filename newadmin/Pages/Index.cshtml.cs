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
    public class IndexModel : PageModel
    {
        private readonly autisamdata.Models.DatabasetestContext _context;

        public IndexModel(autisamdata.Models.DatabasetestContext context)
        {
            _context = context;
        }

        public IList<Partnership> Partnership { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Partnership != null)
            {
                Partnership = await _context.Partnership.ToListAsync();
            }
        }
    }
}
