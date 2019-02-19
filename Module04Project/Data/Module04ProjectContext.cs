using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Module04Project.Models
{
    public class Module04ProjectContext : DbContext
    {
        public Module04ProjectContext (DbContextOptions<Module04ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Module04Project.Models.Movie> Movie { get; set; }
    }
}
