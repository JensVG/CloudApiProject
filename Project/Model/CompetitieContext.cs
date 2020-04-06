
    public class CompetitieContext : DbContext
    {
        public CompetitieContext(DbContextOptions<CompetitieContext> options) : base(options)
        {

        }
        public DbSet<Ploeg> Ploegen { get; set; }
        public DbSet<Speler> Spelers { get; set; }
    }