using Microsoft.EntityFrameworkCore;

public class Day6_KTPM_K22BContext(DbContextOptions<Day6_KTPM_K22BContext> options) : DbContext(options)
{
    public DbSet<Day6_KTPM_K22B.Models.Product> Product { get; set; } = default!;
}
