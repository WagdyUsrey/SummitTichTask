using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SummitTichTask.Models;

namespace SummitTichTask.Data
{
    public class SummitTichTaskContext : DbContext
    {
        public SummitTichTaskContext (DbContextOptions<SummitTichTaskContext> options)
            : base(options)
        {
        }

        public DbSet<SummitTichTask.Models.Reservation> Reservation { get; set; }

        public DbSet<SummitTichTask.Models.Trip> Trip { get; set; }
    }
}
