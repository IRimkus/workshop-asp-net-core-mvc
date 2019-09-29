using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoWebMvcA.Models
{
    public class CursoWebMvcAContext : DbContext
    {
        public CursoWebMvcAContext (DbContextOptions<CursoWebMvcAContext> options)
            : base(options)
        {
        }

        public DbSet<CursoWebMvcA.Models.Department> Department { get; set; }
    }
}
