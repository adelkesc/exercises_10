using System;
using Microsoft.EntityFrameworkCore;
using Entities.dataAccessExercises;

// The DbContext is a bridge between your domain and the database.  It holds properties representing collections of the entitites
// that your application with work with.
// It is the primary class that is responsible for interacting with the database.

namespace dataAccessExercises
{
    public class CatContext : DbContext
    {
        public CatContext(DbContextOptions<CatContext> options) : base(options)
        {
            // No-args
        }

        public DbSet<Cat> Cats {get; set;}
        public DbSet<Order> Orders {get; set;}
        
        // Why Order and not OrderItem?  Only create DbSets for entities you want to query directly.
        // These methods will be the tables.
    }
}