using Eve_Assets.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Eve_Assets
{
    public class DbContextSeeder : DropCreateDatabaseIfModelChanges<DbContext>
    {
        protected override void Seed(DbContext context)
        {
            List<Mineral> AllMinerals = new List<Mineral>()
            {
                new Mineral()
                {
                    Name = "Tritanium"
                }

            };

            List<Ore> AllOres = new List<Ore>()
            {
                new Ore()
                {
                    Name = "Veldspar",
                    RefineAmount = 100
                }
            };

            List<MineralsRefined> AllMineralsRefined = new List<MineralsRefined>()
            {
                new MineralsRefined()
                {
                    Amount = 1000,
                    Mineral = AllMinerals[0]
                }
            };
            AllOres[0].Minerals = AllMineralsRefined;

            context.Ores.AddRange(AllOres);
            context.MineralsRefined.AddRange(AllMineralsRefined);
            context.Minerals.AddRange(AllMinerals);
            base.Seed(context);
        }
    }
}