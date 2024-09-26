using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DAL.Entites;
using System.Reflection.Metadata;

namespace DAL.DB
{
    public class ApplicationDBcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=socialtrain;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>()
                .HasMany(b => b.posts) //POSTS ==navigation properties in blog class
                .WithOne(i => i.user); //blog is navpar in table posts 
               

        }


        public DbSet<user> users {  get; set; }

        public DbSet<post>posts { get; set; }

        //DbSet<comment> coment { get; set; }

        //DbSet<like> like { get; set; }


    }
}
