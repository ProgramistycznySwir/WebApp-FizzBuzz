using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WebApp_FizzBuzz.Models;

namespace WebApp_FizzBuzz.Data
{
    public class FizzBuzzContext : DbContext
    {
        public DbSet<FizzBuzzEntry> FizzBuzzEntries { get; set; }

        public FizzBuzzContext(DbContextOptions options)
            : base(options)
            { }
    }
}
