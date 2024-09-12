using Colledge.Domen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colledge.Infrastructure.Data;

public class ColledgeContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public ColledgeContext(DbContextOptions<ColledgeContext> opt) : base(opt)
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
        //Database.Migrate();
    }

}
