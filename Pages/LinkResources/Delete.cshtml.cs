using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LinkHubApp.Data;
using LinkHubApp.Models;

namespace LinkHubApp.Pages.LinkResources
{
    public class DeleteModel : PageModel
    {
        private readonly LinkHubApp.Data.LinkHubAppContext _context;

        public DeleteModel(LinkHubApp.Data.LinkHubAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Links Links { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linkresources = await _context.LinkResources.FirstOrDefaultAsync(m => m.Id == id);

            if (linkresources == null)
            {
                return NotFound();
            }
            else
            {
                Links = linkresources;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var linkresources = await _context.LinkResources.FindAsync(id);
            if (linkresources != null)
            {
                Links = linkresources;
                _context.LinkResources.Remove(Links);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
