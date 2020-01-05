using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
    }
}