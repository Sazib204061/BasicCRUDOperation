﻿using BasicCRUDOperation.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUDOperation.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
