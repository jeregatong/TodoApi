using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class TodoContextFactory : IDesignTimeDbContextFactory<TodoContext>
{
    public TodoContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<TodoContext>();
        optionsBuilder.UseSqlite("Data Source=todo.db"); // or your real DB connection string

        return new TodoContext(optionsBuilder.Options);
    }
}
