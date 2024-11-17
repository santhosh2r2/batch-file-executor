using Unit.Tests.Models;

namespace Unit.Tests;
public class Database_Reset
{
    [Fact]
    public void DeleteDatabase()
    {
        
        var context = new BatchFileExecutorContext();
        var db = context.Database;
        db.EnsureDeleted();

    }
    [Fact]
    public void CreateDatabase()
    {

        var context = new BatchFileExecutorContext();
        var db = context.Database;
        db.EnsureCreated();

    }
}