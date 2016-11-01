using Eve_Assets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eve_Assets
{
    public class OreDbContext : DbContext
    {
        public DbSet<Ore> Ores { get; set; }
        public DbSet<MineralsRefined> MineralsRefined { get; set; }
        public DbSet<Mineral> Minerals { get; set; }
    }
}