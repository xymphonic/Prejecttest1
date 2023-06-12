using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using autisamdata.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Projecttest1.Pages
{
    public class newblogModel : PageModel
    {
        private readonly DatabasetestContext _context;

        public List<News> News { get; set; }

        public newblogModel(DatabasetestContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            // Retrieve the news records from the database
            News = await _context.News.ToListAsync();

            if (News == null)
            {
                // Handle the case when no news records are found
                return NotFound();
            }

            return Page();
        }
    }
}
