using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pwiapi.Models;
namespace pwiapi.Data
{
    public class LineContext : DbContext
    {
        public LineContext(DbContextOptions<LineContext> opt):base(opt)
        {
        }
        public DbSet<Line> CMN_LINE { get; set; } //Table Name 
    }
}
