using System;
using Microsoft.EntityFrameworkCore;

namespace Waterman.Models
{
    public class TodoContext: DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
    }
}
