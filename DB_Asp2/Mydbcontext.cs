using DB_Asp2.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_Asp2
{
    public class Mydbcontext:DbContext
    {
        public Mydbcontext(DbContextOptions<Mydbcontext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; } = null;
    }

}
