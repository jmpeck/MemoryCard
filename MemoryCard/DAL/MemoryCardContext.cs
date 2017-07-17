using MemoryCard.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MemoryCard.DAL
{
    public class MemoryCardContext : DbContext
    {
       
        public MemoryCardContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}