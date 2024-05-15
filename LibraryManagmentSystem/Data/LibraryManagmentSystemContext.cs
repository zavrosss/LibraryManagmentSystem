using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryManagmentSystem.Models;

namespace LibraryManagmentSystem.Data
{
    public class LibraryManagmentSystemContext : DbContext
    {
        public LibraryManagmentSystemContext(DbContextOptions<LibraryManagmentSystemContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryManagmentSystem.Models.Library> Library { get; set; } = default!;
    }
}
