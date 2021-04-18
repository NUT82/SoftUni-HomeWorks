namespace Dictionary.Data
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<BulgarianWord> BulgarianWords { get; set; }

        public DbSet<EnglishWord> EnglishWords { get; set; }

        public DbSet<EnglishWordBulgarianWord> EnglishWordsBulgarianWords { get; set; }

        public DbSet<UserTranslateWord> UserTranslateWords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=DictionaryGame;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTranslateWord>().HasKey(x => new { x.UserId, x.TranslateWordId });
        }
    }
}