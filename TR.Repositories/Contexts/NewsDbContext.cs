using Microsoft.EntityFrameworkCore;
using technicalRadiation.Models.Entities;

namespace technicalRadiation.Repositories.Contexts
{
    public class NewsDbContext : DbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasOne(m => m.UserFrom)
                .WithMany(u => u.MessagesSent);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.UserTo)
                .WithMany(u => u.MessagesReceived);
        }

        public DbSet<NewsItem> NewsItems { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<NewsItemAuthor> NewsItemAuthors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NewsItemCategory> NewsItemCategories { get; set; }
    }
}