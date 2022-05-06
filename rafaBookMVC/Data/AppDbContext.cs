﻿using Microsoft.EntityFrameworkCore;
using rafaBookMVC.Models;

namespace rafaBookMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } 
    }
}
