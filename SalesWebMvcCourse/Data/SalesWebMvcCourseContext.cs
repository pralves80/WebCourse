using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcCourse.Models;

namespace SalesWebMvcCourse.Data
{
    public class SalesWebMvcCourseContext : DbContext
    {
        public SalesWebMvcCourseContext (DbContextOptions<SalesWebMvcCourseContext> options)
            : base(options)
        {
        }

        // Para que o modelo seja reconhecido pelo framework, tem que add as classes como tipo DBSets aqui. Vai ser 1 dbset para cadas entidade
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
