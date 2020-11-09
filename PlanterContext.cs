using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PlanteCenter
{
   public class PlanterContext : DbContext
    {
        
        
            public PlanterContext(DbContextOptions<PlanterContext> options)
                : base(options)
            {

            }

            public DbSet<Planter> planters { get; set; }
        
    }
}
