using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GRTAPI.Models;

namespace GRTAPI.Data
{
    public class GRTAPIContext : DbContext
    {
        public GRTAPIContext (DbContextOptions<GRTAPIContext> options)
            : base(options)
        {
        }

        public DbSet<GRTAPI.Models.Marca> Marca { get; set; }
    }
}
