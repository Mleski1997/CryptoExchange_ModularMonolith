﻿using CryptoExchange.Modules.Users.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.DAL
{
    public class UserDbContext : IdentityDbContext<User>
    {

        
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
           
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            
         
 
            modelBuilder.HasDefaultSchema("users");
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName ="ADMIN"
                },

                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },

            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);
            base.OnModelCreating(modelBuilder);

        }
    }
}