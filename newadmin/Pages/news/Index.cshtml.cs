using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using autisamdata.Models;

namespace newadmin.Pages.test
{
    public class IndexModel : PageModel
    {
        private readonly autisamdata.Models.DatabasetestContext _context;

        public IndexModel(autisamdata.Models.DatabasetestContext context)
        {
            _context = context;
        }

        public IList<News> News { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.News != null)
            {
                News = await _context.News.ToListAsync();
            }
        }
    }
}
