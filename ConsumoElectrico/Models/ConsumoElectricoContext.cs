using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ConsumoElectrico.Models
{
    public class ConsumoElectricoContext : DbContext
    {
        public DbSet<CargoFijo> CargosFijo { get; set; }
        public DbSet<LecturaDistrib> LecturasDistribs { get; set; }
        public DbSet<LecturaPropia> LecturasPropias { get; set; }
        public DbSet<PrecioEnergia> PreciosEnergia { get; set; }
    }
}