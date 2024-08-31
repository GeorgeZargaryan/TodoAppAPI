using System;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Models.Model;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // modelBuilder.UseCollation("Latin1_General_CI_AS");
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        optionsBuilder.UseSqlServer("Server=localhost; Database=TodoApi; User Id=sa; Password=Something2005; TrustServerCertificate=True; MultipleActiveResultSets=true");
    }
}


    public DbSet<TodoTask> Tasks { get; set; }
    // public DbSet<Question> Question { get; set; }

}