using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MayTheFourth.State.Contexts;

public class MayTheFourthDbContextFactory : IDesignTimeDbContextFactory<MayTheFourthDbContext>
{
    public MayTheFourthDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MayTheFourthDbContext>();
        optionsBuilder.UseSqlite("Data Source=wwwroot/maythefourth.db");
        return new MayTheFourthDbContext(optionsBuilder.Options);
    }
}