using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LinkHubApp.Models;

namespace LinkHubApp.Data
{
    public class LinkHubAppContext : DbContext
    {
        public LinkHubAppContext (DbContextOptions<LinkHubAppContext> options)
            : base(options)
        {
        }

        public DbSet<LinkHubApp.Models.Links> LinkResources { get; set; } = default!;
    }
}
