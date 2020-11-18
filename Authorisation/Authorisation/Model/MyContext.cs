using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorisation.Model
{
    public class MyContext : IdentityDbContext<AppUser>
    {
        public MyContext() : base() { }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }

        public Microsoft.EntityFrameworkCore.DbSet<Geheim> Geheimen { get; set; }
    }
}
