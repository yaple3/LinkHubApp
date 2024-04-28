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
    public class IndexModel : PageModel
    {
        private readonly LinkHubApp.Data.LinkHubAppContext _context;

        public IndexModel(LinkHubApp.Data.LinkHubAppContext context)
        {
            _context = context;
        }

        public IList<Links> LinkResources { get;set; }

        public async Task OnGetAsync()
        {
            LinkResources = await _context.LinkResources.ToListAsync();

            // Update DateTime properties with default value to null
            foreach (var linkResource in LinkResources)
            {
                if (linkResource.Date == default(DateTime))
                {
                    linkResource.Date = null;
                }
            }
        }
    }
}
