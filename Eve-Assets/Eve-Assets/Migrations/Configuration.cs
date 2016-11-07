namespace Eve_Assets.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Eve_Assets.DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Eve_Assets.DbContext context)
        {
            #region minerals
            List<Mineral> AllMinerals = new List<Mineral>()
            {
                new Mineral()
                {
                    Name = "Tritanium"
                },
                new Mineral()
                {
                    Name = "Pyerite"
                },
                new Mineral()
                {
                    Name = "Mexallon"
                },
                new Mineral()
                {
                    Name = "Isogen"
                }

            };
            #endregion
            #region ores
            List<Ore> AllOres = new List<Ore>()
            {
                #region veldspar
                new Ore()
                {
                    Name = "Veldspar",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Concentrated Veldspar",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Dense Veldspar",
                    RefineAmount = 100
                },
                #endregion
                #region Scordite
                new Ore()
                {
                    Name = "Scordite",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Condensed Scordite",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Massive Scordite",
                    RefineAmount = 100
                },
                #endregion
                #region Pyroxeres
                new Ore()
                {
                    Name = "Pyroxeres",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Solid Pyroxeres",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Vicous Pyroxeres",
                    RefineAmount = 100
                },
                #endregion
                #region Plagioclase
                new Ore()
                {
                    Name = "Plagioclase",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Azure Plagioclase",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Rich Plagioclase",
                    RefineAmount = 100
                },
                #endregion
                #region Omber
                new Ore()
                {
                    Name = "Omber",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Silverly Omber",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Golden Omber",
                    RefineAmount = 100
                },
                #endregion
                #region Kernite
                new Ore()
                {
                    Name = "Kernite",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Luminous Kernite",
                    RefineAmount = 100
                },
                new Ore()
                {
                    Name = "Fiery Kernite",
                    RefineAmount = 100
                }
                #endregion
            };
            #endregion
            #region mineralAssignments
            #region intArrays
            List<int[]> mineralAssignments = new List<int[]>();
            mineralAssignments.Add(new int[] { 415, 0, 0, 0 });
            mineralAssignments.Add(new int[] { 436, 0, 0, 0 });
            mineralAssignments.Add(new int[] { 457, 0, 0, 0 });
            mineralAssignments.Add(new int[] { 346, 173, 0, 0 });
            mineralAssignments.Add(new int[] { 364, 182, 0, 0 });
            mineralAssignments.Add(new int[] { 381, 190, 0, 0 });
            mineralAssignments.Add(new int[] { 351, 25, 50, 0 });
            mineralAssignments.Add(new int[] { 369, 26, 53, 0 });
            mineralAssignments.Add(new int[] { 387, 27, 55, 0 });
            mineralAssignments.Add(new int[] { 107, 213, 107, 0 });
            mineralAssignments.Add(new int[] { 113, 224, 113, 0 });
            mineralAssignments.Add(new int[] { 118, 235, 118, 0 });
            mineralAssignments.Add(new int[] { 85, 34, 0, 85 });
            mineralAssignments.Add(new int[] { 90, 36, 0, 90 });
            mineralAssignments.Add(new int[] { 94, 38, 0, 94 });
            mineralAssignments.Add(new int[] { 134, 0, 267, 134 });
            mineralAssignments.Add(new int[] { 141, 0, 281, 141 });
            mineralAssignments.Add(new int[] { 148, 0, 294, 148 });
            #endregion
            #region assignment
            List<MineralsRefined> AllMineralsRefined = new List<MineralsRefined>();
            #endregion
            for (int i = 0; i < mineralAssignments.Count; ++i)
            {
                for (int j = 0; j < mineralAssignments[i].Length; ++j)
                {
                    var refined = new MineralsRefined()
                    {
                        Amount = mineralAssignments[i][j],
                        Mineral = AllMinerals[j]
                    };
                    if(AllOres[i].Minerals == null)
                    {
                        AllOres[i].Minerals = new List<MineralsRefined>();
                    }
                    AllOres[i].Minerals.Add(refined);
                    AllMineralsRefined.Add(refined);
                }
            }
            #endregion

            AllOres.ForEach(o => context.Ores.AddOrUpdate(c => c.Name, o));
            AllMineralsRefined.ForEach(o => context.MineralsRefined.AddOrUpdate(c => c.Id, o));
            AllMinerals.ForEach(o => context.Minerals.AddOrUpdate(c => c.Name, o));
            context.SaveChanges();
        }
    }
}
