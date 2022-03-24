using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCcrudTurismo.Models
{
    public class PassageiroContext: DbContext
    {
        public PassageiroContext(DbContextOptions<PassageiroContext> options) : base(options) 
        {
        
        }

        public DbSet<Passageiro> Passageiros { get; set; }

    }
}
