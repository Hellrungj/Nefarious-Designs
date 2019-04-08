using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NefariousDesigns.Models
{
    public class AddDbContext: DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
        {

        }

        public DbSet<Shirt> Shirts { get; set; }
    }
}
