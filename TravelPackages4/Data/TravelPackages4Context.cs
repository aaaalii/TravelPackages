using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TravelPackages4.Models;

namespace TravelPackages4.Data
{
    public class TravelPackages4Context : Microsoft.EntityFrameworkCore.DbContext
    {
        public TravelPackages4Context (DbContextOptions<TravelPackages4Context> options)
            : base(options)
        {
        }

        public DbSet<TravelPackages4.Models.PackageModel> PackageModel { get; set; } = default!;
    }
}
