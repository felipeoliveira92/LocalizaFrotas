using LocalizaFrotasDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizaFrotasInfra.Repository.EF
{
    public class FrotaContext : DbContext
    {
        public FrotaContext(DbContextOptions<FrotaContext> options)
           : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
