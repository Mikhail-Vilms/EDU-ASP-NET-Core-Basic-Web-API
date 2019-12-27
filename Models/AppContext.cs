using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    // DataBase context
    public class TodoApiContext : DbContext
    {
        public TodoApiContext(DbContextOptions<TodoApiContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> ToDoItems { get; set; }
    }
}
