using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }

        public DbSet<Note_Info> Notes { get; set; }

    }
}
