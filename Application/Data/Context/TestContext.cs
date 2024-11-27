using Application.Data.Models;

using Microsoft.EntityFrameworkCore;

namespace Application.Data.Context;

public class TestContext() : DbContext
{
    public DbSet<TestEntity>? Entities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString());
    }
}