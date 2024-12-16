using System;

namespace TuljaBhavani_Theertham.Models
{
   public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options){ }
    }
}
