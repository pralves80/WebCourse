﻿using System;
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

        public DbSet<Department> Department { get; set; }

        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
