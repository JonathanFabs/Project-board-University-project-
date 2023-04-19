﻿using JonathanCw2.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JonathanCw2.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company>Companies { get; set; }
        public DbSet<User>Users { get; set; }
        public DbSet<Ticket>Tickets { get; set; }
        public DbSet<Project>Projects { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
