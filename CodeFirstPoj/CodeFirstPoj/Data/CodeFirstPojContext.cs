using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirstPoj.Models;

namespace CodeFirstPoj.Data
{
    public class CodeFirstPojContext : DbContext
    {
        public CodeFirstPojContext (DbContextOptions<CodeFirstPojContext> options)
            : base(options)
        {
        }

        public DbSet<CodeFirstPoj.Models.Movie> Movie { get; set; } = default!;
    }
}
