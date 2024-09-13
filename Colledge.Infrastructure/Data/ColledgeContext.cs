using Colledge.Domen.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colledge.Infrastructure.Data;

public class ColledgeContext : IdentityDbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Schedule> Schedules { get; set; }


    public ColledgeContext(DbContextOptions<ColledgeContext> opt) : base(opt)
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
        //Database.Migrate();
    }

}
