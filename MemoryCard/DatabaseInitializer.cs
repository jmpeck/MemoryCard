using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MemoryCard.DAL;
using MemoryCard.Models;

namespace MemoryCard
{
    internal class DatabaseInitializer :
        DropCreateDatabaseIfModelChanges<MemoryCardContext>

    {
        protected override void Seed(MemoryCardContext context)
        {
        }
    }
}