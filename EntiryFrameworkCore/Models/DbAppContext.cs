using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EntiryFrameworkCore.Models {
    public class MyContext : DbContext {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options) { }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            // Role
            modelBuilder.Entity<Role>().HasData(new Role { RoleId = 1, Name = "Administrator", Descriptions = "A Super User is a person from the department who has a profound understanding of internal processes and is responsible for knowledge management inside of the department", Date_Created = DateTime.Now });
            modelBuilder.Entity<Role>().HasData(new Role { RoleId = 2, Name = "User", Descriptions = "A simple user is the user who is a daily user based on the settings and authorizations provided by the Super User and has limited access due to that.", Date_Created = DateTime.Now });

            // Users
            modelBuilder.Entity<User>().HasData(new User {
                UserId = 1,
                RoleId = 1,
                First_Name = "Juan",
                Last_Name = "Dela Cruz",
                Email = "juan.delacruz@gmail.com",
                Username = "j.delacruz",
                Password = "1234567890",
                Status = 1,
                Date_Created = DateTime.Now
            }, new User {
                UserId = 2,
                RoleId = 2,
                First_Name = "Steve",
                Last_Name = "Maps",
                Email = "steve.maps@yahoo.com",
                Username = "s.maps",
                Password = "1234567890",
                Status = 1,
                Date_Created = DateTime.Now
            });
        }
    }
}
