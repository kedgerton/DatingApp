using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

// This is a the availability for a connection string
// DbContext will interact with the database | session and Query
public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    // AppUsers is where the properties | column Names are
    // Users will be the name of the Database Table
    public DbSet<AppUser> Users { get; set; }
}
