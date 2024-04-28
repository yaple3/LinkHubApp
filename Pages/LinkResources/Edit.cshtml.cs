using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LinkHubApp.Data;
using LinkHubApp.Models;

namespace LinkHubApp.Pages.LinkResources
{
    public class EditModel : PageModel
    {
        private readonly LinkHubApp.Data.LinkHubAppContext _context;

        public EditModel(LinkHubApp.Data.LinkHubAppContext context)
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

            var linkresources =  await _context.LinkResources.FirstOrDefaultAsync(m => m.Id == id);
            if (linkresources == null)
            {
                return NotFound();
            }
            Links = Links;
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

            _context.Attach(Links).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinkResourcesExists(Links.Id))
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

        private bool LinkResourcesExists(int id)
        {
            return _context.LinkResources.Any(e => e.Id == id);
        }
    }
}
