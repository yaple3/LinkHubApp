using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LinkHubApp.Data;
using LinkHubApp.Models;

namespace LinkHubApp.Pages.LinkResources
{
    public class CreateModel : PageModel
    {
        private readonly LinkHubApp.Data.LinkHubAppContext _context;

        public CreateModel(LinkHubApp.Data.LinkHubAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Links Links { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LinkResources.Add(Links);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
