using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLSP2.Models;

namespace QLSP2.Data
{
  public class QLSP2Context : DbContext
  {
    public QLSP2Context(DbContextOptions<QLSP2Context> options)
        : base(options)
    {
    }

    public DbSet<QLSP2.Models.Product> Product { get; set; } = default!;
  }
}
