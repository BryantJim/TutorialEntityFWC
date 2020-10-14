using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Fluent_API_one_to_many
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EFCore-Aplicada;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne<Grade>(s => s.Grade)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.CurrentGradeId);
        }

        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
