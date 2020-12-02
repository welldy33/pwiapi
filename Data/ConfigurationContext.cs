using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pwiapi.Models;
using Microsoft.EntityFrameworkCore;

namespace pwiapi.Data
{
    public class ConfigurationContext:DbContext
    {
        public ConfigurationContext(DbContextOptions<ConfigurationContext> opt) : base(opt) { 
        }
        public DbSet<Emp> commands { get; set; }
    }
}
