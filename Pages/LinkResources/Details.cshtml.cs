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
    public class DetailsModel : PageModel
    {
        private readonly LinkHubApp.Data.LinkHubAppContext _context;

        public DetailsModel(LinkHubApp.Data.LinkHubAppContext context)
        {
            _context = context;
        }

        public Links Links { get; set; }/* = default!;*/

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
    }
}
