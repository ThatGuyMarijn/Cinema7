using System;
using System.Collections.Generic;
using System.Text;
using Cinema7.Data.Models;
using Cinema7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinema7.Data
{
    public class CinemaDbContext : IdentityDbContext
    {

        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Films> Films { get; set; }
        public virtual DbSet<FilmVertoningen> FilmVertoningen { get; set; }
        public virtual DbSet<Reserveringen> Reserveringen { get; set; }
        public virtual DbSet<ReserveringenVertoningen> ReserveringenVertoningen { get; set; }
        public virtual DbSet<Zalen> Zalen { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "LevelOne", NormalizedName = "LEVELONE", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "LevelTwo", NormalizedName = "LEVELTWO", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "LevelThree", NormalizedName = "LEVELTHREE", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "LevelFour", NormalizedName = "LEVELFOUR", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "LevelFive", NormalizedName = "LEVELFIVE", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
        }
        
    }
}
