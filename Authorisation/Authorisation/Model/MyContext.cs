using Microsoft.EntityFrameworkCore;

namespace Authorisation.Model
{
    public class MyContext : DbContext
    {
        public MyContext() : base() { }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }

        public Microsoft.EntityFrameworkCore.DbSet<Geheim> Geheimen { get; set; }
    }
}
